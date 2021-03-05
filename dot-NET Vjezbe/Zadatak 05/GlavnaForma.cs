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
            if (this.ShowInTaskbar)
            {
                this.ShowInTaskbar = false;
            }
            else if (!this.ShowInTaskbar)
            {
                this.ShowInTaskbar = true;
            }
        }

        private void btnDontShowOverOtherWindow_Click(object sender, EventArgs e)
        {
            if (this.TopMost)
            {
                this.TopMost = false;
            }
            else if (!this.TopMost)
            {
                this.TopMost = true;
            }

        }
    }
}
