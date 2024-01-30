namespace Traffic_Light_Project
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ctrlTrafficLightFourth = new Traffic_Light_Project.ctrlTrafficLight();
            this.ctrlTrafficLightThird = new Traffic_Light_Project.ctrlTrafficLight();
            this.ctrlTrafficLightSecond = new Traffic_Light_Project.ctrlTrafficLight();
            this.ctrlTrafficLightFirst = new Traffic_Light_Project.ctrlTrafficLight();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ctrlTrafficLightFourth);
            this.groupBox1.Controls.Add(this.ctrlTrafficLightThird);
            this.groupBox1.Controls.Add(this.ctrlTrafficLightSecond);
            this.groupBox1.Controls.Add(this.ctrlTrafficLightFirst);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(650, 385);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // ctrlTrafficLightFourth
            // 
            this.ctrlTrafficLightFourth.CurrentLight = Traffic_Light_Project.ctrlTrafficLight.LightEnum.Red;
            this.ctrlTrafficLightFourth.GreenTime = 1;
            this.ctrlTrafficLightFourth.Location = new System.Drawing.Point(562, 103);
            this.ctrlTrafficLightFourth.Name = "ctrlTrafficLightFourth";
            this.ctrlTrafficLightFourth.OrangeTime = 1;
            this.ctrlTrafficLightFourth.RedTime = 1;
            this.ctrlTrafficLightFourth.Size = new System.Drawing.Size(36, 66);
            this.ctrlTrafficLightFourth.TabIndex = 4;
            this.ctrlTrafficLightFourth.FirstTrafficLightOn += new System.EventHandler<Traffic_Light_Project.ctrlTrafficLight.TrafficLightEventArgs>(this.ctrlTrafficLightFourth_FirstTrafficLightOn);
            // 
            // ctrlTrafficLightThird
            // 
            this.ctrlTrafficLightThird.CurrentLight = Traffic_Light_Project.ctrlTrafficLight.LightEnum.Red;
            this.ctrlTrafficLightThird.GreenTime = 1;
            this.ctrlTrafficLightThird.Location = new System.Drawing.Point(430, 103);
            this.ctrlTrafficLightThird.Name = "ctrlTrafficLightThird";
            this.ctrlTrafficLightThird.OrangeTime = 1;
            this.ctrlTrafficLightThird.RedTime = 1;
            this.ctrlTrafficLightThird.Size = new System.Drawing.Size(36, 66);
            this.ctrlTrafficLightThird.TabIndex = 3;
            this.ctrlTrafficLightThird.FourthTrafficLightOn += new System.EventHandler<Traffic_Light_Project.ctrlTrafficLight.TrafficLightEventArgs>(this.ctrlTrafficLightThird_FourthTrafficLightOn);
            // 
            // ctrlTrafficLightSecond
            // 
            this.ctrlTrafficLightSecond.CurrentLight = Traffic_Light_Project.ctrlTrafficLight.LightEnum.Red;
            this.ctrlTrafficLightSecond.GreenTime = 1;
            this.ctrlTrafficLightSecond.Location = new System.Drawing.Point(173, 103);
            this.ctrlTrafficLightSecond.Name = "ctrlTrafficLightSecond";
            this.ctrlTrafficLightSecond.OrangeTime = 1;
            this.ctrlTrafficLightSecond.RedTime = 1;
            this.ctrlTrafficLightSecond.Size = new System.Drawing.Size(36, 66);
            this.ctrlTrafficLightSecond.TabIndex = 2;
            this.ctrlTrafficLightSecond.ThirdTrafficLightOn += new System.EventHandler<Traffic_Light_Project.ctrlTrafficLight.TrafficLightEventArgs>(this.ctrlTrafficLightSecond_ThirdTrafficLightOn);
            // 
            // ctrlTrafficLightFirst
            // 
            this.ctrlTrafficLightFirst.CurrentLight = Traffic_Light_Project.ctrlTrafficLight.LightEnum.Red;
            this.ctrlTrafficLightFirst.GreenTime = 1;
            this.ctrlTrafficLightFirst.Location = new System.Drawing.Point(38, 103);
            this.ctrlTrafficLightFirst.Name = "ctrlTrafficLightFirst";
            this.ctrlTrafficLightFirst.OrangeTime = 1;
            this.ctrlTrafficLightFirst.RedTime = 1;
            this.ctrlTrafficLightFirst.Size = new System.Drawing.Size(36, 76);
            this.ctrlTrafficLightFirst.TabIndex = 1;
            this.ctrlTrafficLightFirst.SecondTrafficLightOn += new System.EventHandler<Traffic_Light_Project.ctrlTrafficLight.TrafficLightEventArgs>(this.ctrlTrafficLightFirst_SecondTrafficLightOn);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-9, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(659, 370);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ctrlTrafficLight ctrlTrafficLightFourth;
        private ctrlTrafficLight ctrlTrafficLightThird;
        private ctrlTrafficLight ctrlTrafficLightSecond;
        private ctrlTrafficLight ctrlTrafficLightFirst;
    }
}

