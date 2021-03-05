using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadatak_04
{
    public partial class GlavnaForma : Form
    {
        public GlavnaForma()
        {
            InitializeComponent();
        }

        private void btnPromijeniPoziciju_Click(object sender, EventArgs e)
        {

            Random random = new Random();
            Location = new Point(random.Next(0,1000), random.Next(0,1000));              
        }
    }
}
