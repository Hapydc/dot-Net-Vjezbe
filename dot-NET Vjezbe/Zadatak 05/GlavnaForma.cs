using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadatak_05
{
    public partial class GlavnaForma : Form
    {
        public GlavnaForma()
        {
            InitializeComponent();
        }



        private void btnDontShowOnTaskbar_Click(object sender, EventArgs e)
        {
            this.ShowInTaskbar = !this.ShowInTaskbar;
            if (ShowInTaskbar)
            {
                btnDontShowOnTaskbar.Text = "Ne prikazuj u taskbaru";
            }
            else
            {
                btnDontShowOnTaskbar.Text = "Prikazuj u taskbaru";
            }
        }

        private void btnDontShowOverOtherWindow_Click(object sender, EventArgs e)
        {
            TopMost = !TopMost;
            if (TopMost)
            {
                btnDontShowOverOtherWindow.Text = "Ne prikazuj iznad ostalih prozora";
            }
            else 
            {
                btnDontShowOverOtherWindow.Text = "Prikazuj iznad ostalih prozora";
            }

        }
    }
}
