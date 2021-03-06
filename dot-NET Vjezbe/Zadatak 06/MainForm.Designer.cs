namespace Zadatak_06
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
            this.btnAddPanel = new System.Windows.Forms.Button();
            this.btnDeletePanels = new System.Windows.Forms.Button();
            this.btnAddButton = new System.Windows.Forms.Button();
            this.btnDeleteButtons = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddPanel
            // 
            this.btnAddPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddPanel.Location = new System.Drawing.Point(31, 209);
            this.btnAddPanel.Name = "btnAddPanel";
            this.btnAddPanel.Size = new System.Drawing.Size(182, 100);
            this.btnAddPanel.TabIndex = 0;
            this.btnAddPanel.Text = "Dodaj panel";
            this.btnAddPanel.UseVisualStyleBackColor = true;
            this.btnAddPanel.Click += new System.EventHandler(this.btnAddPanel_Click);
            // 
            // btnDeletePanels
            // 
            this.btnDeletePanels.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDeletePanels.Location = new System.Drawing.Point(219, 209);
            this.btnDeletePanels.Name = "btnDeletePanels";
            this.btnDeletePanels.Size = new System.Drawing.Size(182, 100);
            this.btnDeletePanels.TabIndex = 1;
            this.btnDeletePanels.Text = "Ukloni sve panele";
            this.btnDeletePanels.UseVisualStyleBackColor = true;
            this.btnDeletePanels.Click += new System.EventHandler(this.btnDeletePanels_Click);
            // 
            // btnAddButton
            // 
            this.btnAddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddButton.Location = new System.Drawing.Point(407, 209);
            this.btnAddButton.Name = "btnAddButton";
            this.btnAddButton.Size = new System.Drawing.Size(182, 100);
            this.btnAddButton.TabIndex = 2;
            this.btnAddButton.Text = "Dodaj gumb";
            this.btnAddButton.UseVisualStyleBackColor = true;
            this.btnAddButton.Click += new System.EventHandler(this.btnAddButton_Click);
            // 
            // btnDeleteButtons
            // 
            this.btnDeleteButtons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDeleteButtons.Location = new System.Drawing.Point(595, 209);
            this.btnDeleteButtons.Name = "btnDeleteButtons";
            this.btnDeleteButtons.Size = new System.Drawing.Size(182, 100);
            this.btnDeleteButtons.TabIndex = 3;
            this.btnDeleteButtons.Text = "Ukloni gumbe";
            this.btnDeleteButtons.UseVisualStyleBackColor = true;
            this.btnDeleteButtons.Click += new System.EventHandler(this.btnDeleteButtons_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.btnDeleteButtons);
            this.Controls.Add(this.btnAddButton);
            this.Controls.Add(this.btnDeletePanels);
            this.Controls.Add(this.btnAddPanel);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddPanel;
        private System.Windows.Forms.Button btnDeletePanels;
        private System.Windows.Forms.Button btnAddButton;
        private System.Windows.Forms.Button btnDeleteButtons;
    }
}

