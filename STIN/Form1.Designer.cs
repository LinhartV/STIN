
namespace STIN
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DateMzcr = new System.Windows.Forms.Label();
            this.DateWho = new System.Windows.Forms.Label();
            this.TotalMzcr = new System.Windows.Forms.Label();
            this.TotalWho = new System.Windows.Forms.Label();
            this.TotalDifference = new System.Windows.Forms.Label();
            this.LastDayMzcr = new System.Windows.Forms.Label();
            this.LastDayWho = new System.Windows.Forms.Label();
            this.LastDayDifference = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(39, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "Second page";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(30, 180);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 29);
            this.button2.TabIndex = 1;
            this.button2.Text = "Refresh";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(557, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "WHO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(420, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "MZČR";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(680, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Difference";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(342, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(342, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Total";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(342, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Last day";
            // 
            // DateMzcr
            // 
            this.DateMzcr.AutoSize = true;
            this.DateMzcr.Location = new System.Drawing.Point(420, 98);
            this.DateMzcr.Name = "DateMzcr";
            this.DateMzcr.Size = new System.Drawing.Size(49, 20);
            this.DateMzcr.TabIndex = 8;
            this.DateMzcr.Text = "MZČR";
            // 
            // DateWho
            // 
            this.DateWho.AutoSize = true;
            this.DateWho.Location = new System.Drawing.Point(553, 98);
            this.DateWho.Name = "DateWho";
            this.DateWho.Size = new System.Drawing.Size(49, 20);
            this.DateWho.TabIndex = 9;
            this.DateWho.Text = "MZČR";
            // 
            // TotalMzcr
            // 
            this.TotalMzcr.AutoSize = true;
            this.TotalMzcr.Location = new System.Drawing.Point(420, 163);
            this.TotalMzcr.Name = "TotalMzcr";
            this.TotalMzcr.Size = new System.Drawing.Size(49, 20);
            this.TotalMzcr.TabIndex = 10;
            this.TotalMzcr.Text = "MZČR";
            // 
            // TotalWho
            // 
            this.TotalWho.AutoSize = true;
            this.TotalWho.Location = new System.Drawing.Point(553, 163);
            this.TotalWho.Name = "TotalWho";
            this.TotalWho.Size = new System.Drawing.Size(49, 20);
            this.TotalWho.TabIndex = 11;
            this.TotalWho.Text = "MZČR";
            // 
            // TotalDifference
            // 
            this.TotalDifference.AutoSize = true;
            this.TotalDifference.Location = new System.Drawing.Point(671, 163);
            this.TotalDifference.Name = "TotalDifference";
            this.TotalDifference.Size = new System.Drawing.Size(49, 20);
            this.TotalDifference.TabIndex = 12;
            this.TotalDifference.Text = "MZČR";
            // 
            // LastDayMzcr
            // 
            this.LastDayMzcr.AutoSize = true;
            this.LastDayMzcr.Location = new System.Drawing.Point(420, 224);
            this.LastDayMzcr.Name = "LastDayMzcr";
            this.LastDayMzcr.Size = new System.Drawing.Size(49, 20);
            this.LastDayMzcr.TabIndex = 13;
            this.LastDayMzcr.Text = "MZČR";
            // 
            // LastDayWho
            // 
            this.LastDayWho.AutoSize = true;
            this.LastDayWho.Location = new System.Drawing.Point(553, 224);
            this.LastDayWho.Name = "LastDayWho";
            this.LastDayWho.Size = new System.Drawing.Size(49, 20);
            this.LastDayWho.TabIndex = 14;
            this.LastDayWho.Text = "MZČR";
            // 
            // LastDayDifference
            // 
            this.LastDayDifference.AutoSize = true;
            this.LastDayDifference.Location = new System.Drawing.Point(671, 224);
            this.LastDayDifference.Name = "LastDayDifference";
            this.LastDayDifference.Size = new System.Drawing.Size(49, 20);
            this.LastDayDifference.TabIndex = 15;
            this.LastDayDifference.Text = "MZČR";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 451);
            this.Controls.Add(this.LastDayDifference);
            this.Controls.Add(this.LastDayWho);
            this.Controls.Add(this.LastDayMzcr);
            this.Controls.Add(this.TotalDifference);
            this.Controls.Add(this.TotalWho);
            this.Controls.Add(this.TotalMzcr);
            this.Controls.Add(this.DateWho);
            this.Controls.Add(this.DateMzcr);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Difference";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label DateMzcr;
        public System.Windows.Forms.Label DateWho;
        public System.Windows.Forms.Label TotalMzcr;
        public System.Windows.Forms.Label TotalWho;
        public System.Windows.Forms.Label TotalDifference;
        public System.Windows.Forms.Label LastDayMzcr;
        public System.Windows.Forms.Label LastDayWho;
        public System.Windows.Forms.Label LastDayDifference;
    }
}

