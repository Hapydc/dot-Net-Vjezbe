namespace Zadatak_04
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
            this.btnPromijeniPoziciju = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPromijeniPoziciju
            // 
            this.btnPromijeniPoziciju.Location = new System.Drawing.Point(194, 82);
            this.btnPromijeniPoziciju.Name = "btnPromijeniPoziciju";
            this.btnPromijeniPoziciju.Size = new System.Drawing.Size(363, 166);
            this.btnPromijeniPoziciju.TabIndex = 0;
            this.btnPromijeniPoziciju.Text = "Promijeni Poziciju";
            this.btnPromijeniPoziciju.UseVisualStyleBackColor = true;
            this.btnPromijeniPoziciju.Click += new System.EventHandler(this.btnPromijeniPoziciju_Click);
            // 
            // GlavnaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPromijeniPoziciju);
            this.Name = "GlavnaForma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mijenjam polozaj";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPromijeniPoziciju;
    }
}

