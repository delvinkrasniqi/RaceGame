namespace MotorRacing
{
    partial class MotorRace
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.coin2 = new System.Windows.Forms.PictureBox();
            this.coin1 = new System.Windows.Forms.PictureBox();
            this.obstacle3 = new System.Windows.Forms.PictureBox();
            this.obstacle2 = new System.Windows.Forms.PictureBox();
            this.obstacle1 = new System.Windows.Forms.PictureBox();
            this.cycle = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cycle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(217, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 50);
            this.label1.TabIndex = 9;
            this.label1.Text = "GAME OVER";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(154, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 28);
            this.label2.TabIndex = 13;
            this.label2.Text = "Coins -";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.Controls.Add(this.pictureBox9);
            this.panel1.Controls.Add(this.pictureBox6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(511, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(128, 458);
            this.panel1.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Green;
            this.panel2.Controls.Add(this.pictureBox8);
            this.panel2.Controls.Add(this.pictureBox7);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(128, 458);
            this.panel2.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::MotorRacing.Properties.Resources.replay_arrow;
            this.button1.Location = new System.Drawing.Point(301, 135);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 45);
            this.button1.TabIndex = 16;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::MotorRacing.Properties.Resources.tree;
            this.pictureBox8.Location = new System.Drawing.Point(23, 104);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(85, 90);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 2;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::MotorRacing.Properties.Resources.tree;
            this.pictureBox7.Location = new System.Drawing.Point(23, 321);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(85, 90);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 1;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::MotorRacing.Properties.Resources.tree;
            this.pictureBox9.Location = new System.Drawing.Point(31, 234);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(85, 90);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 3;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::MotorRacing.Properties.Resources.tree;
            this.pictureBox6.Location = new System.Drawing.Point(21, 44);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(85, 90);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 0;
            this.pictureBox6.TabStop = false;
            // 
            // coin2
            // 
            this.coin2.Image = global::MotorRacing.Properties.Resources.dollar;
            this.coin2.Location = new System.Drawing.Point(363, 9);
            this.coin2.Name = "coin2";
            this.coin2.Size = new System.Drawing.Size(35, 35);
            this.coin2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coin2.TabIndex = 12;
            this.coin2.TabStop = false;
            // 
            // coin1
            // 
            this.coin1.Image = global::MotorRacing.Properties.Resources.dollar;
            this.coin1.Location = new System.Drawing.Point(226, 159);
            this.coin1.Name = "coin1";
            this.coin1.Size = new System.Drawing.Size(35, 35);
            this.coin1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coin1.TabIndex = 10;
            this.coin1.TabStop = false;
            // 
            // obstacle3
            // 
            this.obstacle3.Image = global::MotorRacing.Properties.Resources.Cone;
            this.obstacle3.Location = new System.Drawing.Point(414, 44);
            this.obstacle3.Name = "obstacle3";
            this.obstacle3.Size = new System.Drawing.Size(42, 47);
            this.obstacle3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.obstacle3.TabIndex = 8;
            this.obstacle3.TabStop = false;
            // 
            // obstacle2
            // 
            this.obstacle2.Image = global::MotorRacing.Properties.Resources.Cone;
            this.obstacle2.Location = new System.Drawing.Point(336, 217);
            this.obstacle2.Name = "obstacle2";
            this.obstacle2.Size = new System.Drawing.Size(42, 47);
            this.obstacle2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.obstacle2.TabIndex = 7;
            this.obstacle2.TabStop = false;
            // 
            // obstacle1
            // 
            this.obstacle1.Image = global::MotorRacing.Properties.Resources.Cone;
            this.obstacle1.Location = new System.Drawing.Point(162, 97);
            this.obstacle1.Name = "obstacle1";
            this.obstacle1.Size = new System.Drawing.Size(42, 47);
            this.obstacle1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.obstacle1.TabIndex = 6;
            this.obstacle1.TabStop = false;
            // 
            // cycle
            // 
            this.cycle.BackColor = System.Drawing.Color.Transparent;
            this.cycle.Image = global::MotorRacing.Properties.Resources.cycle1;
            this.cycle.Location = new System.Drawing.Point(182, 343);
            this.cycle.Name = "cycle";
            this.cycle.Size = new System.Drawing.Size(35, 68);
            this.cycle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cycle.TabIndex = 5;
            this.cycle.TabStop = false;
            this.cycle.Click += new System.EventHandler(this.cycle_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.White;
            this.pictureBox5.Location = new System.Drawing.Point(490, -17);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(10, 500);
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.White;
            this.pictureBox4.Location = new System.Drawing.Point(142, -42);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(10, 500);
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Location = new System.Drawing.Point(320, 383);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(10, 100);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Location = new System.Drawing.Point(320, 196);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(10, 100);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(320, -6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(10, 100);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // MotorRace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(639, 458);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.coin2);
            this.Controls.Add(this.coin1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.obstacle3);
            this.Controls.Add(this.obstacle2);
            this.Controls.Add(this.obstacle1);
            this.Controls.Add(this.cycle);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MotorRace";
            this.Text = "MotorRace";
            this.Load += new System.EventHandler(this.MotorRace_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MotorRace_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cycle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox cycle;
        private System.Windows.Forms.PictureBox obstacle1;
        private System.Windows.Forms.PictureBox obstacle2;
        private System.Windows.Forms.PictureBox obstacle3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox coin1;
        private System.Windows.Forms.PictureBox coin2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Button button1;
    }
}

