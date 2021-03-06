using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadatak_07
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        List<Control> paneli =new List<Control>();

        private void btnCreatePanel_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            Panel panel = new Panel();
            panel.Location = new Point(random.Next(100, 150), random.Next(100, 150));
            Color randomColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
            panel.BackColor = randomColor;
            panel.Size = new Size(100,100);
            this.Controls.Add(panel);
            paneli.Add(panel);
            panel.Visible = true;
        }

        private void btnMoveToLeft_Click(object sender, EventArgs e)
        {
            int zadnjiPanel = paneli.Count() - 1;
            paneli[zadnjiPanel].Left += 10;
        }

        private void btnMoveToRight_Click(object sender, EventArgs e)
        {
            int zadnjiPanel = paneli.Count() - 1;
            paneli[zadnjiPanel].Left -= 10;
        }

        private void btnMoveToTop_Click(object sender, EventArgs e)
        {
            int zadnjiPanel = paneli.Count() - 1;
            paneli[zadnjiPanel].Top -= 10;
        }

        private void btnMoveToBottom_Click(object sender, EventArgs e)
        {
            int zadnjiPanel = paneli.Count() - 1;
            paneli[zadnjiPanel].Top += 10;
        }
    }
}
