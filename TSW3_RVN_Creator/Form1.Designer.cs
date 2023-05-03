namespace TSW3_RVN_Creator
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
            this.NumberEnter_TB = new System.Windows.Forms.TextBox();
            this.Generated_TB = new System.Windows.Forms.TextBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NumberEnter_TB
            // 
            this.NumberEnter_TB.Location = new System.Drawing.Point(12, 12);
            this.NumberEnter_TB.Multiline = true;
            this.NumberEnter_TB.Name = "NumberEnter_TB";
            this.NumberEnter_TB.Size = new System.Drawing.Size(194, 405);
            this.NumberEnter_TB.TabIndex = 0;
            this.NumberEnter_TB.Text = "Enter unit numbers here\r\n8400-8499\r\n9000\r\n9002\r\n8990-8999 ";
            this.NumberEnter_TB.TextChanged += new System.EventHandler(this.NumberEnter_TB_TextChanged);
            // 
            // Generated_TB
            // 
            this.Generated_TB.Location = new System.Drawing.Point(212, 12);
            this.Generated_TB.Multiline = true;
            this.Generated_TB.Name = "Generated_TB";
            this.Generated_TB.Size = new System.Drawing.Size(576, 376);
            this.Generated_TB.TabIndex = 1;
            this.Generated_TB.Text = "UE4 table will be made here";
            this.Generated_TB.TextChanged += new System.EventHandler(this.Generated_TB_TextChanged);
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(212, 394);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 23);
            this.StartButton.TabIndex = 2;
            this.StartButton.Text = "Convert";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(660, 404);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Made by Space#7546 <3";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 424);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.Generated_TB);
            this.Controls.Add(this.NumberEnter_TB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NumberEnter_TB;
        private System.Windows.Forms.TextBox Generated_TB;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Label label1;
    }
}

