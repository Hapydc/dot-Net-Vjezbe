namespace Zadatak_8
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
            this.btnOpenForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOpenForm
            // 
            this.btnOpenForm.Location = new System.Drawing.Point(164, 84);
            this.btnOpenForm.Name = "btnOpenForm";
            this.btnOpenForm.Size = new System.Drawing.Size(413, 248);
            this.btnOpenForm.TabIndex = 0;
            this.btnOpenForm.Text = "Prikazi novu formu";
            this.btnOpenForm.UseVisualStyleBackColor = true;
            this.btnOpenForm.Click += new System.EventHandler(this.btnOpenForm_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOpenForm);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpenForm;
    }
}

