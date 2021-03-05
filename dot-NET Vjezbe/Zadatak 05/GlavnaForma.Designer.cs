namespace Zadatak_05
{
    partial class GlavnaForma
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
            this.btnDontShowOnTaskbar = new System.Windows.Forms.Button();
            this.btnDontShowOverOtherWindow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDontShowOnTaskbar
            // 
            this.btnDontShowOnTaskbar.Location = new System.Drawing.Point(48, 37);
            this.btnDontShowOnTaskbar.Name = "btnDontShowOnTaskbar";
            this.btnDontShowOnTaskbar.Size = new System.Drawing.Size(209, 138);
            this.btnDontShowOnTaskbar.TabIndex = 0;
            this.btnDontShowOnTaskbar.Text = "Ne prikazuj u Task-baru";
            this.btnDontShowOnTaskbar.UseVisualStyleBackColor = true;
            this.btnDontShowOnTaskbar.Click += new System.EventHandler(this.btnDontShowOnTaskbar_Click);
            // 
            // btnDontShowOverOtherWindow
            // 
            this.btnDontShowOverOtherWindow.Location = new System.Drawing.Point(310, 37);
            this.btnDontShowOverOtherWindow.Name = "btnDontShowOverOtherWindow";
            this.btnDontShowOverOtherWindow.Size = new System.Drawing.Size(209, 138);
            this.btnDontShowOverOtherWindow.TabIndex = 1;
            this.btnDontShowOverOtherWindow.Text = "Ne prikazuj iznad ostalih prozora";
            this.btnDontShowOverOtherWindow.UseVisualStyleBackColor = true;
            this.btnDontShowOverOtherWindow.Click += new System.EventHandler(this.btnDontShowOverOtherWindow_Click);
            // 
            // GlavnaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDontShowOverOtherWindow);
            this.Controls.Add(this.btnDontShowOnTaskbar);
            this.Name = "GlavnaForma";
            this.Text = "Form1";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDontShowOnTaskbar;
        private System.Windows.Forms.Button btnDontShowOverOtherWindow;
    }
}

