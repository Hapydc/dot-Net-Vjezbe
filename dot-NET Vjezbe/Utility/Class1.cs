using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Utility
{
    public class Utils
    {
        private static Random random = new Random();
        public static Color GetRandomBoja()
        {
            return  Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
        }
        public static Point GetRandomLokacijaUnutarRoditelja(Control roditelj, Control dijete)
        {
            int maxX = roditelj.Width - dijete.Width;
            int maxY = roditelj.Height - dijete.Height;
            return new Point(random.Next(maxX), random.Next(maxY));

        }
    }
}
