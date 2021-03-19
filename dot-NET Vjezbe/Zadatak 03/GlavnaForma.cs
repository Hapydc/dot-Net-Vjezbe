using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadatak_03
{
    public partial class GlavnaForma : Form
    {
        public GlavnaForma()
        {
            InitializeComponent();
        }
        private void GlavnaForma_Load(object sender, EventArgs e)
        {
            CentrirajGumb();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            this.BackColor  = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
            this.Size = new Size(random.Next(300, 900), random.Next(300, 600));
            CentrirajGumb();


        }
        private void CentrirajGumb()
        {
            int SirinaForme = this.ClientSize.Width;
            int VisinaForme = this.ClientSize.Height;

            int SirinaGumba = button1.Width;
            int VisinaGumba = button1.Height;
            int x = (SirinaForme - SirinaGumba) / 2;
            int y = (VisinaForme - VisinaGumba) / 2;

            button1.Location = new Point(x,y);

        }
    }
}
