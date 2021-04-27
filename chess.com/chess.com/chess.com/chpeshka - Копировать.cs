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
            bool cvet = false;
            //для белых фигур
            if (secondsender is Image)
            {
                image = secondsender as Image;
                if (image.Name[0] == 'ч')
                { cvet = false; }
                else { cvet = true; }
            }
            if (secondsender is Button)
            {
                image = secondsender as Button;
                cvet = true;
            }
            if (figurerules.Name == "чпешка" &&  cvet)
            {
                int x = Grid.GetRow(figurerules);
                int y = Grid.GetColumn(figurerules);
                int x2 = Grid.GetRow(image);
                int y2 = Grid.GetColumn(image);

                if((x+1==x2)&&(y+1==y2|| y - 1 == y2) && figuresarr.figures[x2, y2] != null)
                {
                    mogno = true;
                }
                if ((x + 1 == x2 || x + 2 == x2) && (y == y2) && figuresarr.figures[x2, y2] == null)
                {
                    mogno = true;
                }
            }
            return mogno;
        }
        public static bool bpeshkarule2(object sender, object secondsender, string[,] figures, int i)
        {
            var figurerules = sender as Image;
            bool mogno = false;
            bool cvet = false;
            bool bferz = false;
            //для белых фигур
            if (secondsender is Image)
            {
                image = secondsender as Image;
                if (image.Name[0] == 'ч')
                { cvet = false; }
                else { cvet = true; }
            }
            if (secondsender is Button)
            {
                image = secondsender as Button;
                cvet = true;
            }
            int x = Grid.GetRow(figurerules);
            int y = Grid.GetColumn(figurerules);
            int x2 = Grid.GetRow(image);
            int y2 = Grid.GetColumn(image);
            if (cvet)
            {
                if ((x + 1 == x2) && (y + 1 == y2 || y - 1 == y2) && figuresarr.figures[x2, y2] != null)
                {
                    if (x2 == 7) { bferz = true; }
                    mogno = true;
                }
                if ((x + 1 == x2) && (y == y2) && figuresarr.figures[x2, y2] == null)
                {
                    if (x2 == 7) { bferz = true; }
                    mogno = true;
                }
            }

            if (i == 1)
            { return mogno; }
            else
            { return bferz; }
        }
    }

}

