using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadatak_02
{
    public partial class GlavnaForma : Form
    {
        public GlavnaForma()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPrvaForma_Click(object sender, EventArgs e)
        {
            Form prva = new PrvaForma();
            prva.Show();
        }

        private void btnDrugaForma_Click(object sender, EventArgs e)
        {
            new DrugaForma().Show();
        }

        private void btnTrecaForma_Click(object sender, EventArgs e)
        {
            new TrecaForma().Show();
        }
    }
}
