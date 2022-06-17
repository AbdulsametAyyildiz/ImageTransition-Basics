namespace ImageTransition
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.load1Btn = new System.Windows.Forms.Button();
            this.load2Btn = new System.Windows.Forms.Button();
            this.fadeBtn = new System.Windows.Forms.Button();
            this.verticalBtn = new System.Windows.Forms.Button();
            this.horizontalBtn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(45, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(462, 289);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // load1Btn
            // 
            this.load1Btn.Location = new System.Drawing.Point(188, 364);
            this.load1Btn.Name = "load1Btn";
            this.load1Btn.Size = new System.Drawing.Size(146, 34);
            this.load1Btn.TabIndex = 3;
            this.load1Btn.Text = "Load IMG 1";
            this.load1Btn.UseVisualStyleBackColor = true;
            this.load1Btn.Click += new System.EventHandler(this.load1Btn_Click);
            // 
            // load2Btn
            // 
            this.load2Btn.Location = new System.Drawing.Point(1265, 364);
            this.load2Btn.Name = "load2Btn";
            this.load2Btn.Size = new System.Drawing.Size(146, 34);
            this.load2Btn.TabIndex = 4;
            this.load2Btn.Text = "Load IMG 2";
            this.load2Btn.UseVisualStyleBackColor = true;
            this.load2Btn.Click += new System.EventHandler(this.load2Btn_Click);
            // 
            // fadeBtn
            // 
            this.fadeBtn.Location = new System.Drawing.Point(720, 188);
            this.fadeBtn.Name = "fadeBtn";
            this.fadeBtn.Size = new System.Drawing.Size(146, 34);
            this.fadeBtn.TabIndex = 5;
            this.fadeBtn.Text = "Fade";
            this.fadeBtn.UseVisualStyleBackColor = true;
            this.fadeBtn.Click += new System.EventHandler(this.fadeBtn_Click);
            // 
            // verticalBtn
            // 
            this.verticalBtn.Location = new System.Drawing.Point(720, 239);
            this.verticalBtn.Name = "verticalBtn";
            this.verticalBtn.Size = new System.Drawing.Size(146, 34);
            this.verticalBtn.TabIndex = 6;
            this.verticalBtn.Text = "Vertical Wp";
            this.verticalBtn.UseVisualStyleBackColor = true;
            this.verticalBtn.Click += new System.EventHandler(this.verticalBtn_Click);
            // 
            // horizontalBtn
            // 
            this.horizontalBtn.Location = new System.Drawing.Point(720, 292);
            this.horizontalBtn.Name = "horizontalBtn";
            this.horizontalBtn.Size = new System.Drawing.Size(146, 34);
            this.horizontalBtn.TabIndex = 7;
            this.horizontalBtn.Text = "Horizontal Wp";
            this.horizontalBtn.UseVisualStyleBackColor = true;
            this.horizontalBtn.Click += new System.EventHandler(this.horizontalBtn_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(752, 356);
            this.trackBar1.Maximum = 30;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(124, 56);
            this.trackBar1.TabIndex = 8;
            this.trackBar1.Value = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(695, 374);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Speed:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(1100, 30);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(462, 289);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(579, 521);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(462, 289);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(647, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(291, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Developed By Abdülsamet Ayyıldız - 180201040";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1608, 859);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.horizontalBtn);
            this.Controls.Add(this.verticalBtn);
            this.Controls.Add(this.fadeBtn);
            this.Controls.Add(this.load2Btn);
            this.Controls.Add(this.load1Btn);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button load1Btn;
        private System.Windows.Forms.Button load2Btn;
        private System.Windows.Forms.Button fadeBtn;
        private System.Windows.Forms.Button verticalBtn;
        private System.Windows.Forms.Button horizontalBtn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Label label2;
    }
}

