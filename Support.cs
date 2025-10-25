using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace STimeBox
{
    static public class Support
    {
        static public int CalcValuePercentFormMax(int max, double percent) { 
            double d = Math.Floor((max*percent)  / 100);
            return (int)d; 
        }
        static public Size GetPrimaryScreenSize() {
            if (Screen.PrimaryScreen != null )
                return new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            return Size.Empty;
        }
        static public Color ConvertHexToColor(string color) {
            string a = color;
            if (a[0] == '#') { 
                a = a.Substring(1);
            }
            int r = Convert.ToInt32(a.Substring(0, 2), 16);
            int g = Convert.ToInt32(a.Substring(2, 2), 16);
            int b = Convert.ToInt32(a.Substring(4, 2), 16);

            // Альфа-канал (непрозрачный)
            int alp = 255;

            // Создание цвета
            return Color.FromArgb(alp, r, g, b);
        }
    }
}
