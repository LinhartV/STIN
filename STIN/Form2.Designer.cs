﻿
namespace STIN
{
    partial class Form2
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
            this.button1 = new System.Windows.Forms.Button();
            this.testLabel = new System.Windows.Forms.Label();
            this.testButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.cbox_state_3 = new System.Windows.Forms.ComboBox();
            this.cbox_state_2 = new System.Windows.Forms.ComboBox();
            this.cobox_state_5 = new System.Windows.Forms.ComboBox();
            this.cbox_state_4 = new System.Windows.Forms.ComboBox();
            this.chart_1 = new LiveCharts.WinForms.CartesianChart();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(371, 65);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 22);
            this.button1.TabIndex = 0;
            this.button1.Text = "return";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // testLabel
            // 
            this.testLabel.AutoSize = true;
            this.testLabel.Location = new System.Drawing.Point(186, 118);
            this.testLabel.Name = "testLabel";
            this.testLabel.Size = new System.Drawing.Size(38, 15);
            this.testLabel.TabIndex = 1;
            this.testLabel.Text = "label1";
            // 
            // testButton
            // 
            this.testButton.Location = new System.Drawing.Point(519, 102);
            this.testButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.testButton.Name = "testButton";
            this.testButton.Size = new System.Drawing.Size(125, 22);
            this.testButton.TabIndex = 2;
            this.testButton.Text = "ReadAustralia";
            this.testButton.UseVisualStyleBackColor = true;
            this.testButton.Click += new System.EventHandler(this.testButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(674, 49);
            this.refreshButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(82, 22);
            this.refreshButton.TabIndex = 3;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // cbox_state_3
            // 
            this.cbox_state_3.FormattingEnabled = true;
            this.cbox_state_3.Location = new System.Drawing.Point(519, 201);
            this.cbox_state_3.Name = "cbox_state_3";
            this.cbox_state_3.Size = new System.Drawing.Size(149, 23);
            this.cbox_state_3.TabIndex = 4;
            // 
            // cbox_state_2
            // 
            this.cbox_state_2.FormattingEnabled = true;
            this.cbox_state_2.Location = new System.Drawing.Point(519, 154);
            this.cbox_state_2.Name = "cbox_state_2";
            this.cbox_state_2.Size = new System.Drawing.Size(149, 23);
            this.cbox_state_2.TabIndex = 5;
            // 
            // cobox_state_5
            // 
            this.cobox_state_5.FormattingEnabled = true;
            this.cobox_state_5.Location = new System.Drawing.Point(519, 295);
            this.cobox_state_5.Name = "cobox_state_5";
            this.cobox_state_5.Size = new System.Drawing.Size(149, 23);
            this.cobox_state_5.TabIndex = 6;
            // 
            // cbox_state_4
            // 
            this.cbox_state_4.FormattingEnabled = true;
            this.cbox_state_4.Location = new System.Drawing.Point(519, 250);
            this.cbox_state_4.Name = "cbox_state_4";
            this.cbox_state_4.Size = new System.Drawing.Size(149, 23);
            this.cbox_state_4.TabIndex = 7;
            // 
            // chart_1
            // 
            this.chart_1.BackColor = System.Drawing.SystemColors.Window;
            this.chart_1.Location = new System.Drawing.Point(29, 154);
            this.chart_1.Name = "chart_1";
            this.chart_1.Size = new System.Drawing.Size(396, 244);
            this.chart_1.TabIndex = 8;
            this.chart_1.Text = "cartesianChart1";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 476);
            this.Controls.Add(this.chart_1);
            this.Controls.Add(this.cbox_state_4);
            this.Controls.Add(this.cobox_state_5);
            this.Controls.Add(this.cbox_state_2);
            this.Controls.Add(this.cbox_state_3);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.testButton);
            this.Controls.Add(this.testLabel);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Label testLabel;
        private System.Windows.Forms.Button testButton;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.ComboBox cbox_state_3;
        private System.Windows.Forms.ComboBox cbox_state_2;
        private System.Windows.Forms.ComboBox cobox_state_5;
        private System.Windows.Forms.ComboBox cbox_state_4;
        public LiveCharts.WinForms.CartesianChart chart_1;
    }
}