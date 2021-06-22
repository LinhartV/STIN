
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
            this.loadData = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.cbox_state_3 = new System.Windows.Forms.ComboBox();
            this.cbox_state_2 = new System.Windows.Forms.ComboBox();
            this.cbox_state_5 = new System.Windows.Forms.ComboBox();
            this.cbox_state_4 = new System.Windows.Forms.ComboBox();
            this.chart_1 = new LiveCharts.WinForms.CartesianChart();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(594, 113);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 67);
            this.button1.TabIndex = 0;
            this.button1.Text = "Return";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // loadData
            // 
            this.loadData.Location = new System.Drawing.Point(594, 451);
            this.loadData.Name = "loadData";
            this.loadData.Size = new System.Drawing.Size(170, 67);
            this.loadData.TabIndex = 2;
            this.loadData.Text = "Load data";
            this.loadData.UseVisualStyleBackColor = true;
            this.loadData.Click += new System.EventHandler(this.loadData_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(594, 41);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(170, 67);
            this.refreshButton.TabIndex = 3;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // cbox_state_3
            // 
            this.cbox_state_3.FormattingEnabled = true;
            this.cbox_state_3.Location = new System.Drawing.Point(594, 283);
            this.cbox_state_3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbox_state_3.Name = "cbox_state_3";
            this.cbox_state_3.Size = new System.Drawing.Size(170, 28);
            this.cbox_state_3.TabIndex = 4;
            // 
            // cbox_state_2
            // 
            this.cbox_state_2.FormattingEnabled = true;
            this.cbox_state_2.Location = new System.Drawing.Point(594, 227);
            this.cbox_state_2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbox_state_2.Name = "cbox_state_2";
            this.cbox_state_2.Size = new System.Drawing.Size(170, 28);
            this.cbox_state_2.TabIndex = 5;
            // 
            // cbox_state_5
            // 
            this.cbox_state_5.FormattingEnabled = true;
            this.cbox_state_5.Location = new System.Drawing.Point(594, 395);
            this.cbox_state_5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbox_state_5.Name = "cbox_state_5";
            this.cbox_state_5.Size = new System.Drawing.Size(170, 28);
            this.cbox_state_5.TabIndex = 6;
            // 
            // cbox_state_4
            // 
            this.cbox_state_4.FormattingEnabled = true;
            this.cbox_state_4.Location = new System.Drawing.Point(594, 340);
            this.cbox_state_4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbox_state_4.Name = "cbox_state_4";
            this.cbox_state_4.Size = new System.Drawing.Size(170, 28);
            this.cbox_state_4.TabIndex = 7;
            // 
            // chart_1
            // 
            this.chart_1.BackColor = System.Drawing.SystemColors.Window;
            this.chart_1.Location = new System.Drawing.Point(27, 41);
            this.chart_1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chart_1.Name = "chart_1";
            this.chart_1.Size = new System.Drawing.Size(519, 476);
            this.chart_1.TabIndex = 8;
            this.chart_1.Text = "cartesianChart1";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(787, 551);
            this.Controls.Add(this.chart_1);
            this.Controls.Add(this.cbox_state_4);
            this.Controls.Add(this.cbox_state_5);
            this.Controls.Add(this.cbox_state_2);
            this.Controls.Add(this.cbox_state_3);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.loadData);
            this.Controls.Add(this.button1);
            this.Name = "Form2";
            this.Text = "Covid app";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button loadData;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.ComboBox cbox_state_3;
        private System.Windows.Forms.ComboBox cbox_state_2;
        private System.Windows.Forms.ComboBox cbox_state_5;
        private System.Windows.Forms.ComboBox cbox_state_4;
        public LiveCharts.WinForms.CartesianChart chart_1;
    }
}