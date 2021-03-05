namespace Zadatak_02
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
            this.btnPrvaForma = new System.Windows.Forms.Button();
            this.btnDrugaForma = new System.Windows.Forms.Button();
            this.btnTrecaForma = new System.Windows.Forms.Button();
            this.btnZatvori = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPrvaForma
            // 
            this.btnPrvaForma.Location = new System.Drawing.Point(12, 12);
            this.btnPrvaForma.Name = "btnPrvaForma";
            this.btnPrvaForma.Size = new System.Drawing.Size(100, 100);
            this.btnPrvaForma.TabIndex = 0;
            this.btnPrvaForma.Text = "Otvori formu velicine 250x250";
            this.btnPrvaForma.UseVisualStyleBackColor = true;
            this.btnPrvaForma.Click += new System.EventHandler(this.btnPrvaForma_Click);
            // 
            // btnDrugaForma
            // 
            this.btnDrugaForma.Location = new System.Drawing.Point(118, 12);
            this.btnDrugaForma.Name = "btnDrugaForma";
            this.btnDrugaForma.Size = new System.Drawing.Size(100, 100);
            this.btnDrugaForma.TabIndex = 1;
            this.btnDrugaForma.Text = "Otvori drugu formu velicine 300x300";
            this.btnDrugaForma.UseVisualStyleBackColor = true;
            this.btnDrugaForma.Click += new System.EventHandler(this.btnDrugaForma_Click);
            // 
            // btnTrecaForma
            // 
            this.btnTrecaForma.Location = new System.Drawing.Point(224, 12);
            this.btnTrecaForma.Name = "btnTrecaForma";
            this.btnTrecaForma.Size = new System.Drawing.Size(100, 100);
            this.btnTrecaForma.TabIndex = 2;
            this.btnTrecaForma.Text = "Otvori formu velicine 300x300 bez kontr. gumba";
            this.btnTrecaForma.UseVisualStyleBackColor = true;
            this.btnTrecaForma.Click += new System.EventHandler(this.btnTrecaForma_Click);
            // 
            // btnZatvori
            // 
            this.btnZatvori.BackColor = System.Drawing.Color.Red;
            this.btnZatvori.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZatvori.ForeColor = System.Drawing.Color.White;
            this.btnZatvori.Location = new System.Drawing.Point(12, 118);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(312, 100);
            this.btnZatvori.TabIndex = 3;
            this.btnZatvori.Text = "Zatvori aplikaciju";
            this.btnZatvori.UseVisualStyleBackColor = false;
            this.btnZatvori.Click += new System.EventHandler(this.button4_Click);
            // 
            // GlavnaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 231);
            this.Controls.Add(this.btnZatvori);
            this.Controls.Add(this.btnTrecaForma);
            this.Controls.Add(this.btnDrugaForma);
            this.Controls.Add(this.btnPrvaForma);
            this.Name = "GlavnaForma";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPrvaForma;
        private System.Windows.Forms.Button btnDrugaForma;
        private System.Windows.Forms.Button btnTrecaForma;
        private System.Windows.Forms.Button btnZatvori;
    }
}

