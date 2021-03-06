namespace Zadatak_8
{
    partial class SecondForm
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
            this.btnCloseForm = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCloseForm
            // 
            this.btnCloseForm.BackColor = System.Drawing.Color.Red;
            this.btnCloseForm.Location = new System.Drawing.Point(288, 110);
            this.btnCloseForm.Name = "btnCloseForm";
            this.btnCloseForm.Size = new System.Drawing.Size(171, 115);
            this.btnCloseForm.TabIndex = 0;
            this.btnCloseForm.Text = "X";
            this.btnCloseForm.UseVisualStyleBackColor = false;
            this.btnCloseForm.Click += new System.EventHandler(this.btnCloseForm_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Location = new System.Drawing.Point(490, 92);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(223, 151);
            this.btnMaximize.TabIndex = 1;
            this.btnMaximize.Text = "Maximiziraj";
            this.btnMaximize.UseVisualStyleBackColor = true;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Location = new System.Drawing.Point(36, 92);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(212, 151);
            this.btnMinimize.TabIndex = 2;
            this.btnMinimize.Text = "Minimiziraj";
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // SecondForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnMaximize);
            this.Controls.Add(this.btnCloseForm);
            this.Name = "SecondForm";
            this.Text = "SecondForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCloseForm;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Button btnMinimize;
    }
}