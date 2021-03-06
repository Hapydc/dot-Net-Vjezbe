using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadatak_06
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        
        Panel lastPanel = new Panel();
        List<Control> Controle = new List<Control>();


        private void btnAddPanel_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            Panel panel = new Panel();
            panel.Location=new Point(random.Next(100,150), random.Next(100,150));
            Color randomColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
            panel.BackColor = randomColor;
            panel.Size = new Size(200, 200);
            this.Controls.Add(panel);
            Controle.Add(panel);
            panel.Visible = true;                       
        }

        private void btnDeletePanels_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in Controle)
            {               
                    if (ctrl is Panel)
                    {
                    this.Controls.Remove(ctrl);
                    }                                             
            }          
        }

        private void btnAddButton_Click(object sender, EventArgs e)
        {
            Button button = new Button();
            Random random = new Random();
            button.Location = new Point(random.Next(0,200), random.Next(0,200));
            button.AutoSize = true;
            button.BackColor = Color.LightBlue;
            this.Controls.Add(button);
            Controle.Add(button);
        }

        private void btnDeleteButtons_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in Controle)
            {
                if (ctrl is Button)
                {
                    this.Controls.Remove(ctrl);
                }
            }

        }
    }
}
