namespace Snek
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Snake = new System.Windows.Forms.PictureBox();
            this.Food = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Snake)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Food)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-1, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Poäng";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, -1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "0";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Snake
            // 
            this.Snake.BackColor = System.Drawing.Color.Green;
            this.Snake.Image = global::Snek.Properties.Resources.snek;
            this.Snake.Location = new System.Drawing.Point(350, 200);
            this.Snake.Name = "Snake";
            this.Snake.Size = new System.Drawing.Size(100, 50);
            this.Snake.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Snake.TabIndex = 1;
            this.Snake.TabStop = false;
            this.Snake.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Food
            // 
            this.Food.BackColor = System.Drawing.Color.ForestGreen;
            this.Food.Image = global::Snek.Properties.Resources.Snek_food;
            this.Food.Location = new System.Drawing.Point(142, 63);
            this.Food.Name = "Food";
            this.Food.Size = new System.Drawing.Size(67, 50);
            this.Food.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Food.TabIndex = 0;
            this.Food.TabStop = false;
            this.Food.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1058, 1024);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Snake);
            this.Controls.Add(this.Food);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Snake";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.Snake)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Food)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Food;
        private System.Windows.Forms.PictureBox Snake;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

