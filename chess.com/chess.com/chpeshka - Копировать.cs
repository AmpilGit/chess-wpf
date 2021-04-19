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
    class chpeshka1
    {
        public static dynamic image;
        public static bool bpeshkarule(object sender, object secondsender, string[,] figures, int i)
        {
            var figurerules = sender as Image;
            bool mogno = false;
            //для белых фигур
            if (secondsender is Image)
            {
                image = secondsender as Image;
            }
            if (secondsender is Button)
            {
                image = secondsender as Button;
            }
            if (figurerules.Name == "чпешка")
            {
                int x = Grid.GetRow(figurerules);
                int y = Grid.GetColumn(figurerules);
                int x2 = Grid.GetRow(image);
                int y2 = Grid.GetColumn(image);

                if ((x + 1 == x2 && y == y2) || (x + 2 == x2 && y == y2))
                {
                    if (figuresarr.figures[x + 1, y2] == null && figuresarr.figures[x2, y2] == null)
                    {
                        mogno = true;
                    }
                }
            }
            return mogno;
        }
        public static bool bpeshkarule2(object sender, object secondsender, string[,] figures, int i)
        {
            var figurerules = sender as Image;
            bool mogno = false;
            bool bferz = false;
            //для белых фигур
            if (secondsender is Image)
            {
                image = secondsender as Image;
            }
            if (secondsender is Button)
            {
                image = secondsender as Button;
            }
            int x = Grid.GetRow(figurerules);
            int y = Grid.GetColumn(figurerules);
            int x2 = Grid.GetRow(image);
            int y2 = Grid.GetColumn(image);


            if (x + 1 == x2 && y == y2)
            {
                if (figuresarr.figures[x + 1, y2] == null && figuresarr.figures[x2, y2] == null)
                {
                    if (x2 == 7)
                    {
                    }
                    mogno = true;
                }
            }
            if (x + 1 == x2 && y + 1 == y2 && figuresarr.figures[x2, y2] != null)
            {

                mogno = true;
                if (x2 == 7)
                {
                }
            }

            if (i == 1)
            { return mogno; }
            else
            { return bferz; }
        }
    }

}

