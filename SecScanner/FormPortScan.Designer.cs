namespace SecScanner
{
    partial class FormPortScan
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
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox_IpRanges = new System.Windows.Forms.RichTextBox();
            this.richTextBox_Ports = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP地址：";
            // 
            // richTextBox_IpRanges
            // 
            this.richTextBox_IpRanges.Location = new System.Drawing.Point(26, 43);
            this.richTextBox_IpRanges.Name = "richTextBox_IpRanges";
            this.richTextBox_IpRanges.Size = new System.Drawing.Size(231, 131);
            this.richTextBox_IpRanges.TabIndex = 1;
            this.richTextBox_IpRanges.Text = "";
            // 
            // richTextBox_Ports
            // 
            this.richTextBox_Ports.Location = new System.Drawing.Point(290, 43);
            this.richTextBox_Ports.Name = "richTextBox_Ports";
            this.richTextBox_Ports.Size = new System.Drawing.Size(231, 131);
            this.richTextBox_Ports.TabIndex = 3;
            this.richTextBox_Ports.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(288, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "端口号；";
            // 
            // FormPortScan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 536);
            this.ControlBox = false;
            this.Controls.Add(this.richTextBox_Ports);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richTextBox_IpRanges);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "FormPortScan";
            this.Text = "FormPortScan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox_IpRanges;
        private System.Windows.Forms.RichTextBox richTextBox_Ports;
        private System.Windows.Forms.Label label2;
    }
}