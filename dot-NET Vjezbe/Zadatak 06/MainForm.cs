using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utility;

namespace Zadatak_06
{
    public partial class MainForm : Form
    {
        private Size velicinaPanela = new Size(200, 200);
        private Panel zadnjeDodaniPanel;
        public MainForm()
        {
            InitializeComponent();
        }       
        List<Control> Controle = new List<Control>();
        private void btnAddPanel_Click(object sender, EventArgs e)
        {
            
            Random random = new Random();
            Panel panel = new Panel
            {
                Size = velicinaPanela,
                BackColor = Utils.GetRandomBoja(),
                
            };
            panel.Location = Utils.GetRandomLokacijaUnutarRoditelja(pnlKontejner, panel);
            pnlKontejner.Controls.Add(panel);
            panel.BringToFront();
            zadnjeDodaniPanel = panel;
            Controle.Add(panel);                    
        }

        private void btnDeletePanels_Click(object sender, EventArgs e)
        {

            pnlKontejner.Controls.Clear();        
        }

        private void btnAddButton_Click(object sender, EventArgs e)
        {
            if (zadnjeDodaniPanel==null)
            {
                return;
            }
            else
            {

                Button gumb = new Button()
                {
                    Text = "Makni me"
                };
                gumb.Location = Utils.GetRandomLokacijaUnutarRoditelja(zadnjeDodaniPanel,gumb);
                gumb.Click += Gumb_Click;
                zadnjeDodaniPanel.Controls.Add(gumb);
                gumb.BringToFront();

            }   
        }

        private void Gumb_Click(object sender, EventArgs e)
        {
            Button gumb = sender as Button;
            gumb.Parent.Controls.Remove(gumb);    
        }

        private void btnDeleteButtons_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in pnlKontejner.Controls)
            {
                ctrl.Controls.Clear();
            }

        }

        private void pnlKontejner_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
