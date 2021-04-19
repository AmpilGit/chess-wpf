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
    class chahwhite
    {
        public static bool rules(object sender, object secondsender, string[,] figures, int i)
        {
            bool mogno = false;
            var vybor = sender as Image;
            int x = Grid.GetRow(vybor);
            int y = Grid.GetColumn(vybor);
            string namevybor = figuresarr.figures[x, y];

            if (hody.hodb)
            {
                switch (namevybor)
                {
                    case "чферзь":
                        mogno = bferzr1.Bferzrule(sender, secondsender, figures);
                        break;
                    case "чпешка":
                        mogno = chpeshka1.bpeshkarule(sender, secondsender, figures, 1);
                        break;
                    case "чпешка2":
                        mogno = chpeshka1.bpeshkarule2(sender, secondsender, figures, 1);
                        break;
                    case "чладья":
                        mogno = chlad1.Bferzrule(sender, secondsender, figures);
                        break;
                    case "чслон":
                        mogno = chslon1.Bferzrule(sender, secondsender, figures);
                        break;
                    case "чконь":
                        mogno = chkon1.Bferzrule(sender, secondsender, figures);
                        break;
                    case "чкороль":
                        mogno = bkorol1.Bferzrule(sender, secondsender, figures);
                        break;
                }
            }
            return mogno;
        }
    }
}
