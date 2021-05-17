
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.info_label = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(434, 28);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 85);
            this.button1.TabIndex = 0;
            this.button1.Text = "Second page";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(434, 140);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 85);
            this.button2.TabIndex = 1;
            this.button2.Text = "Refresh";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(210, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "WHO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "MZČR";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(299, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Difference";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Total";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "Last day";
            // 
            // DateMzcr
            // 
            this.DateMzcr.AutoSize = true;
            this.DateMzcr.Location = new System.Drawing.Point(109, 55);
            this.DateMzcr.Name = "DateMzcr";
            this.DateMzcr.Size = new System.Drawing.Size(40, 15);
            this.DateMzcr.TabIndex = 8;
            this.DateMzcr.Text = "MZČR";
            // 
            // DateWho
            // 
            this.DateWho.AutoSize = true;
            this.DateWho.Location = new System.Drawing.Point(207, 55);
            this.DateWho.Name = "DateWho";
            this.DateWho.Size = new System.Drawing.Size(40, 15);
            this.DateWho.TabIndex = 9;
            this.DateWho.Text = "MZČR";
            // 
            // TotalMzcr
            // 
            this.TotalMzcr.AutoSize = true;
            this.TotalMzcr.Location = new System.Drawing.Point(109, 103);
            this.TotalMzcr.Name = "TotalMzcr";
            this.TotalMzcr.Size = new System.Drawing.Size(40, 15);
            this.TotalMzcr.TabIndex = 10;
            this.TotalMzcr.Text = "MZČR";
            // 
            // TotalWho
            // 
            this.TotalWho.AutoSize = true;
            this.TotalWho.Location = new System.Drawing.Point(207, 103);
            this.TotalWho.Name = "TotalWho";
            this.TotalWho.Size = new System.Drawing.Size(40, 15);
            this.TotalWho.TabIndex = 11;
            this.TotalWho.Text = "MZČR";
            // 
            // TotalDifference
            // 
            this.TotalDifference.AutoSize = true;
            this.TotalDifference.Location = new System.Drawing.Point(310, 103);
            this.TotalDifference.Name = "TotalDifference";
            this.TotalDifference.Size = new System.Drawing.Size(40, 15);
            this.TotalDifference.TabIndex = 12;
            this.TotalDifference.Text = "MZČR";
            // 
            // LastDayMzcr
            // 
            this.LastDayMzcr.AutoSize = true;
            this.LastDayMzcr.Location = new System.Drawing.Point(109, 149);
            this.LastDayMzcr.Name = "LastDayMzcr";
            this.LastDayMzcr.Size = new System.Drawing.Size(40, 15);
            this.LastDayMzcr.TabIndex = 13;
            this.LastDayMzcr.Text = "MZČR";
            // 
            // LastDayWho
            // 
            this.LastDayWho.AutoSize = true;
            this.LastDayWho.Location = new System.Drawing.Point(207, 149);
            this.LastDayWho.Name = "LastDayWho";
            this.LastDayWho.Size = new System.Drawing.Size(40, 15);
            this.LastDayWho.TabIndex = 14;
            this.LastDayWho.Text = "MZČR";
            // 
            // LastDayDifference
            // 
            this.LastDayDifference.AutoSize = true;
            this.LastDayDifference.Location = new System.Drawing.Point(310, 149);
            this.LastDayDifference.Name = "LastDayDifference";
            this.LastDayDifference.Size = new System.Drawing.Size(40, 15);
            this.LastDayDifference.TabIndex = 15;
            this.LastDayDifference.Text = "MZČR";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.LastDayDifference);
            this.panel2.Controls.Add(this.LastDayWho);
            this.panel2.Controls.Add(this.LastDayMzcr);
            this.panel2.Controls.Add(this.TotalDifference);
            this.panel2.Controls.Add(this.TotalWho);
            this.panel2.Controls.Add(this.TotalMzcr);
            this.panel2.Controls.Add(this.DateWho);
            this.panel2.Controls.Add(this.DateMzcr);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(13, 140);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(392, 199);
            this.panel2.TabIndex = 18;
            // 
            // info_label
            // 
            this.info_label.BackColor = System.Drawing.Color.Crimson;
            this.info_label.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.info_label.Location = new System.Drawing.Point(12, 28);
            this.info_label.Name = "info_label";
            this.info_label.Size = new System.Drawing.Size(393, 85);
            this.info_label.TabIndex = 19;
            this.info_label.Text = "Data informations";
            this.info_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(726, 471);
            this.Controls.Add(this.info_label);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Difference";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label info_label;
    }
}

