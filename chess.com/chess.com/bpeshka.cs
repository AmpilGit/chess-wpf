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
    class bpeshka
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
                if (image.Name[0] == 'б')
                { cvet = false; }
                else { cvet = true; }
            }
            if (secondsender is Button)
            {
                image = secondsender as Button;
                cvet = true;
            }
            if (figurerules.Name == "бпешка")
            {
                int x = Grid.GetRow(figurerules);
                int y = Grid.GetColumn(figurerules);
                int x2 = Grid.GetRow(image);
                int y2 = Grid.GetColumn(image);

                if ((x - 1 == x2 && y == y2) || (x - 2 == x2 && y == y2))
                {
                    if (figuresarr.figures[x - 1, y2] == null && figuresarr.figures[x2, y2] == null)
                    {
                        mogno = true;
                        figuresarr.figures[x, y] = null;
                        figuresarr.figures[x2, y2] = "бпешка2";
                    }
                }
                if (x - 1 == x2 && (y + 1 == y2 || y - 1 == y2) && figuresarr.figures[x2, y2] != null && cvet)
                {

                    figuresarr.figures[x, y] = null;
                    figuresarr.figures[x2, y2] = "бпешка2";
                    mogno = true;
                }
            }
            return mogno;
        }
        public static bool bpeshkarule2(object sender, object secondsender, string[,] figures, int i)
        {
            var figurerules = sender as Image;
            bool mogno = false;
            bool bferz = false;
            bool cvet = false;
            //для белых фигур
            if (secondsender is Image)
            {
                image = secondsender as Image;
                if (image.Name[0] == 'б')
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


            if (x - 1 == x2 && y == y2 && cvet)
            {
                if (figuresarr.figures[x - 1, y2] == null)
                {
                    if (x2 == 0)
                    {
                        figuresarr.figures[x, y] = null;
                        figuresarr.figures[x2, y2] = "бферзь";
                        bferz = true;
                    }
                    mogno = true;
                    figuresarr.figures[x, y] = null;
                    figuresarr.figures[x2, y2] = "бпешка2";
                }
            }
            if (x - 1 == x2 && (y + 1 == y2 || y - 1 == y2) && figuresarr.figures[x2, y2] != null && cvet)
            {

                figuresarr.figures[x, y] = null;
                figuresarr.figures[x2, y2] = "бпешка2";
                mogno = true;
                if (x2 == 0)
                {
                    figuresarr.figures[x, y] = null;
                    figuresarr.figures[x2, y2] = "бферзь";
                    bferz = true;
                }
            }

            if (i == 1)
            { return mogno; }
            else
            { return bferz; }
        }
    }

}
