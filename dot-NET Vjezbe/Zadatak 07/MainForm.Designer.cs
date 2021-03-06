namespace Zadatak_07
{
    partial class MainForm
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
            this.btnCreatePanel = new System.Windows.Forms.Button();
            this.btnMoveToRight = new System.Windows.Forms.Button();
            this.btnMoveToTop = new System.Windows.Forms.Button();
            this.btnMoveToLeft = new System.Windows.Forms.Button();
            this.btnMoveToBottom = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCreatePanel
            // 
            this.btnCreatePanel.Location = new System.Drawing.Point(292, 172);
            this.btnCreatePanel.Name = "btnCreatePanel";
            this.btnCreatePanel.Size = new System.Drawing.Size(131, 67);
            this.btnCreatePanel.TabIndex = 0;
            this.btnCreatePanel.Text = "Kreiraj panelu";
            this.btnCreatePanel.UseVisualStyleBackColor = true;
            this.btnCreatePanel.Click += new System.EventHandler(this.btnCreatePanel_Click);
            // 
            // btnMoveToRight
            // 
            this.btnMoveToRight.Location = new System.Drawing.Point(429, 172);
            this.btnMoveToRight.Name = "btnMoveToRight";
            this.btnMoveToRight.Size = new System.Drawing.Size(108, 67);
            this.btnMoveToRight.TabIndex = 1;
            this.btnMoveToRight.Text = ">>>";
            this.btnMoveToRight.UseVisualStyleBackColor = true;
            this.btnMoveToRight.Click += new System.EventHandler(this.btnMoveToRight_Click);
            // 
            // btnMoveToTop
            // 
            this.btnMoveToTop.Location = new System.Drawing.Point(292, 112);
            this.btnMoveToTop.Name = "btnMoveToTop";
            this.btnMoveToTop.Size = new System.Drawing.Size(131, 54);
            this.btnMoveToTop.TabIndex = 2;
            this.btnMoveToTop.Text = "Top";
            this.btnMoveToTop.UseVisualStyleBackColor = true;
            this.btnMoveToTop.Click += new System.EventHandler(this.btnMoveToTop_Click);
            // 
            // btnMoveToLeft
            // 
            this.btnMoveToLeft.Location = new System.Drawing.Point(175, 172);
            this.btnMoveToLeft.Name = "btnMoveToLeft";
            this.btnMoveToLeft.Size = new System.Drawing.Size(111, 67);
            this.btnMoveToLeft.TabIndex = 3;
            this.btnMoveToLeft.Text = "<<<";
            this.btnMoveToLeft.UseVisualStyleBackColor = true;
            this.btnMoveToLeft.Click += new System.EventHandler(this.btnMoveToLeft_Click);
            // 
            // btnMoveToBottom
            // 
            this.btnMoveToBottom.Location = new System.Drawing.Point(292, 245);
            this.btnMoveToBottom.Name = "btnMoveToBottom";
            this.btnMoveToBottom.Size = new System.Drawing.Size(131, 54);
            this.btnMoveToBottom.TabIndex = 4;
            this.btnMoveToBottom.Text = "Bottom";
            this.btnMoveToBottom.UseVisualStyleBackColor = true;
            this.btnMoveToBottom.Click += new System.EventHandler(this.btnMoveToBottom_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.btnMoveToBottom);
            this.Controls.Add(this.btnMoveToLeft);
            this.Controls.Add(this.btnMoveToTop);
            this.Controls.Add(this.btnMoveToRight);
            this.Controls.Add(this.btnCreatePanel);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreatePanel;
        private System.Windows.Forms.Button btnMoveToRight;
        private System.Windows.Forms.Button btnMoveToTop;
        private System.Windows.Forms.Button btnMoveToLeft;
        private System.Windows.Forms.Button btnMoveToBottom;
    }
}

