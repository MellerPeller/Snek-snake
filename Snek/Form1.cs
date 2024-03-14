using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snek
{
    public partial class Form1 : Form
    {
        const int SIZE_SNAKE = 32;
        const int SIZE_food = 36;

        List<PictureBox> tailPieces = new List<PictureBox>();
        Random rng = new Random();
        int i = 0;
        string direction = "Right";
        int score = 0;


        bool isIntersectingWithTail()
        {
            return tailPieces.Where(i => i.Bounds.IntersectsWith(Snake.Bounds)).Count() > 0;
        }

        public Form1()
        {
            InitializeComponent();
        }

       

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            moveTail();

            if (direction == "Right")
            {
                Snake.Left += SIZE_SNAKE;
            }
            else if (direction == "Left")
            {
                Snake.Left -= SIZE_SNAKE;
            }
            else if (direction == "Down")
            {
                Snake.Top += SIZE_SNAKE;
            }
            else if (direction == "Up")
            {
                Snake.Top -= SIZE_SNAKE;
            }
            if (Snake.Left >= ClientSize.Width)
            {
                timer1.Stop();
                MessageBox.Show("YOU SUCK");
            }
            if (Snake.Right < 0)
            {
                timer1.Stop();
                MessageBox.Show("YOU SUCK");
            }
            if (Snake.Top < 0)
            {
                timer1.Stop();
                MessageBox.Show("YOU SUCK");
            }
            if (Snake.Bottom >= ClientSize.Height)
            {
                timer1.Stop();
                MessageBox.Show("YOU SUCK");
            }
            if (isIntersectingWithTail())
            {
                timer1.Stop();
                MessageBox.Show("YOU SUCK");
            }

            if (Snake.Bounds.IntersectsWith(Food.Bounds))
            {
              Food.Location = new Point(rng.Next(0, ClientSize.Width - SIZE_SNAKE), rng.Next(0, ClientSize.Height - SIZE_SNAKE));                
                addTail();
                score = score + 1;
                label2.Text = score.ToString();

                

                if(timer1.Interval > 50 )
                timer1.Interval = timer1.Interval - (score / 2); 

                else if (timer1.Interval > 2)
                {
                    timer1.Interval = timer1.Interval - 1;
                }

            }

        }

       

        private void Form1_Load(object sender, EventArgs e)
        {
            ClientSize = new Size(SIZE_SNAKE * 20, SIZE_SNAKE * 15);
            Snake.Size = new Size(SIZE_SNAKE, SIZE_SNAKE);
            Food.Size = new Size(SIZE_food, SIZE_food);

            Food.Location = new Point(rng.Next(0, ClientSize.Width - SIZE_food), rng.Next(0, ClientSize.Height - SIZE_food));
            Snake.Location = new Point(0, 0);
            
              
        }

        void addTail()
        {
            PictureBox box = new PictureBox();

            box.Location = Snake.Location;
            box.Size = Snake.Size;
            box.BackColor = Food.BackColor;

            Controls.Add(box);

            tailPieces.Add(box);

        }


        void moveTail()
        {
            if(tailPieces.Count > 0) 
            {
                tailPieces[i].Location = Snake.Location;

                i = i + 1;  

                if(i >= tailPieces.Count)
                {
                    i = 0;
                }
            }
        }


        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 'a')
            {
                direction = "Left";
            }
            else if (e.KeyChar == 'd')
            {
                direction = "Right";
            }
            else if (e.KeyChar == 's')
            {
                direction = "Down";
            }
            else if (e.KeyChar == 'w')
            {
                direction = "Up";
            }


        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
