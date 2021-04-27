using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace chess.com
{
    class chkorol2
    {
        public static bool Bferzrule(int xforchahcorol, int yforchahcorol, string nameofigureinmassdo, int xofigureinmassdo, int yofigureinmassdo, string[,] figures)
        {
            bool mogno = false;
            bool cvet = true;
            if (nameofigureinmassdo == "чкороль" && cvet)
            {
                int x = xofigureinmassdo;//ширина
                int y = yofigureinmassdo;//высота начиная сверху
                int x2 = xforchahcorol;
                int y2 = yforchahcorol;
                mogno = false;
                int x3 = x2 - x;
                int y3 = y2 - y;
                int xcopy = x;
                int ycopy = y;
                if (x3 < 2 && y3 < 2 && x3 > -2 && y3 > -2)
                {
                    mogno = true;
                }
            }
            return mogno;
        }
    }
}
