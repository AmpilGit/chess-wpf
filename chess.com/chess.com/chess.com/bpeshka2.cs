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
    class bpeshka2
    {
        public static dynamic image;
        public static bool bpeshkarule(int xforchahcorol, int yforchahcorol, string nameofigureinmassdo, int xofigureinmassdo, int yofigureinmassdo, string[,] figures)
        {
            bool mogno = false;
            bool cvet = true;
            if (nameofigureinmassdo == "бпешка" && cvet)
            {
                int x = xofigureinmassdo;
                int y = yofigureinmassdo;
                int x2 = xforchahcorol;
                int y2 = yforchahcorol;

                if ((x - 1 == x2) && (y + 1 == y2 || y - 1 == y2) && figures[x2, y2] != null)
                {
                    mogno = true;
                }
                if ((x - 1 == x2 || x - 2 == x2) && (y == y2) && figures[x2, y2] == null)
                {
                    mogno = true;
                }
            }
            return mogno;
        }
        public static bool bpeshkarule2(int xforchahcorol, int yforchahcorol, string nameofigureinmassdo, int xofigureinmassdo, int yofigureinmassdo, string[,] figures)
        {
            bool mogno = false;
            bool cvet = true;
            if (nameofigureinmassdo == "бпешка2" && cvet)
            {
                int x = xofigureinmassdo;//ширина
                int y = yofigureinmassdo;//высота начиная сверху
                int x2 = xforchahcorol;
                int y2 = yforchahcorol;
                int x3 = x2 - x;
                int y3 = y2 - y;
                int xcopy = x;
                int ycopy = y;
                if ((x - 1 == x2) && (y + 1 == y2 || y - 1 == y2) && figures[x2, y2] != null)
                {
                    mogno = true;
                }
                if ((x - 1 == x2) && (y == y2) && figures[x2, y2] == null)
                {
                    mogno = true;
                }
            }
            return mogno;
        }
    }

}

