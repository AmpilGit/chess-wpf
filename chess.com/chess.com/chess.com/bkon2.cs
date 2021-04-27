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
    class bkon2
    {
        public static bool Bferzrule(int xforchahcorol, int yforchahcorol, string nameofigureinmassdo, int xofigureinmassdo, int yofigureinmassdo, string[,] figures)
        {
            bool mogno = false;
            bool cvet = true;
            if (nameofigureinmassdo == "бконь" && cvet)
            {
                int x = xofigureinmassdo;//ширина
                int y = yofigureinmassdo;//высота начиная сверху
                int x2 = xforchahcorol;
                int y2 = yforchahcorol;
                int x3 = x2 - x;
                int y3 = y2 - y;
                int xcopy = x;
                int ycopy = y;
                ////x+2 y+1; x+1 y+2 ; x-2 y+1;x-1 y+2;x+2 y-1; x+1 y-2 ; x-2 y-1;x-1 y-2;
                if (y + 2 == y2 && x + 1 == x2)
                {
                    mogno = true;
                }
                ////x+2 y+1; x+1 y+2 ; x-2 y+1;x-1 y+2;x+2 y-1; x+1 y-2 ; x-2 y-1;x-1 y-2;
                if (y + 1 == y2 && x + 2 == x2)
                {
                    mogno = true;
                }
                ////x-2 y+1;x-1 y+2;x+2 y-1; x+1 y-2 ; x-2 y-1;x-1 y-2;
                if (y - 2 == y2 && x + 1 == x2)
                {
                    mogno = true;
                }
                ////x-1 y+2;x+2 y-1; x+1 y-2 ; x-2 y-1;x-1 y-2;
                if (y - 1 == y2 && x + 2 == x2)
                {
                    mogno = true;
                }
                ////x+2 y-1; x+1 y-2 ; x-2 y-1;x-1 y-2;
                if (y + 2 == y2 && x - 1 == x2)
                {
                    mogno = true;
                }
                // x+1 y-2 ; x-2 y-1;x-1 y-2;
                if (y + 1 == y2 && x - 2 == x2)
                {
                    mogno = true;
                }
                //x - 2 y - 1; x - 1 y - 2;
                if (y - 2 == y2 && x - 1 == x2)
                {
                    mogno = true;
                }
                //x - 1 y - 2;
                if (y - 1 == y2 && x - 2 == x2)
                {
                    mogno = true;
                }
            }
            return mogno;
        }
    }
}
