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
    class chkorol
    {
        public static dynamic image;
        public static bool Bferzrule(object sender, object secondsender, string[,] figures)
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
            if (cvet)
            {
                int x = Grid.GetRow(figurerules);//ширина
                int y = Grid.GetColumn(figurerules);//высота начиная сверху
                int x2 = Grid.GetRow(image);
                int y2 = Grid.GetColumn(image);
                int x3 = x2 - x;
                int y3 = y2 - y;
                mogno = false;
                if (x3 <= 1 && y3 <=1 && x3 >= -1 && y3 >= -1)
                {
                    MainWindow.chkorol = figurerules;
                    figuresarr.figures[x, y] = null;
                    figuresarr.figures[x2, y2] = "чкороль";
                    mogno = true;
                }
            }
            return mogno;
        }
    }
}
