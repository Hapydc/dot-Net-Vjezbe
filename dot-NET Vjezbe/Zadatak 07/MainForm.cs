using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utility;

namespace Zadatak_07
{
    public partial class MainForm : Form
    {
        private const string PUTANJA_DAT="podaci.txt";
        private const char Separator = ',';

        private Size velicinaPanela = new Size(150, 150);
        private int pomak = 10;
        private Panel zadnjeDodaniPanel;
        public MainForm()
        {
            InitializeComponent();
            
        }
        
        private void btnCreatePanel_Click(object sender, EventArgs e)
        {
            Panel panel = new Panel
            {
                Size = velicinaPanela,
                BackColor = Utils.GetRandomBoja()
            };
            panel.Location = Utils.GetRandomLokacijaUnutarRoditelja(this,panel);
            this.Controls.Add(panel);
            zadnjeDodaniPanel = panel;
        }

        private void btnMoveToLeft_Click(object sender, EventArgs e)
        {
            PomakniPanel(-pomak, 0);

        }

        private void btnMoveToRight_Click(object sender, EventArgs e)
        {
            PomakniPanel(pomak, 0);

        }

        private void btnMoveToTop_Click(object sender, EventArgs e)
        {
            
            PomakniPanel(0, -pomak);

        }

        private void btnMoveToBottom_Click(object sender, EventArgs e)
        {
            PomakniPanel(0, pomak);
        }

        private void PomakniPanel(int pomakX, int pomakY)
        {
            if (zadnjeDodaniPanel==null)
            {
                return;
            }
            zadnjeDodaniPanel.Location = new Point
            {
                X = zadnjeDodaniPanel.Location.X + pomakX,
                Y = zadnjeDodaniPanel.Location.Y + pomakY
            };
        }
        private void MainFormClosing(object sender,FormClosingEventArgs e)
        {
           UcitajPodatke();
        }

        private void UcitajPodatke()
        {
            
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SpremiPodatke();
        }
        private void SpremiPodatke()
        {

            StringBuilder podaci = new StringBuilder();
            foreach (Control kontrola in this.Controls)
            {
                if (!(kontrola is Panel))
                {
                    continue;
                }
                Panel panel = kontrola as Panel;

                //X,Y,R,G,B
                podaci
                    .Append(panel.Location.X).Append(Separator)
                .Append(panel.Location.Y).Append(Separator)
                .Append(panel.BackColor.R).Append(Separator)
                .Append(panel.BackColor.G).Append(Separator)
                .Append(panel.BackColor.B).Append(Separator)
                .AppendLine();






            }
            try
            {
                File.WriteAllText(PUTANJA_DAT, podaci.ToString());
            }
            catch (Exception e)
            {

             
            }
               
        }
    }
}
