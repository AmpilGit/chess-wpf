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
    class chahblack
    {
        public static bool rules(object sender, object secondsender, string[,] figures, int i)
        {
            bool mogno = false;
            var vybor = sender as Image;
            int x = Grid.GetRow(vybor);
            int y = Grid.GetColumn(vybor);
            string namevybor = figuresarr.figures[x, y];
            if (hody.hodch)
            {
                switch (namevybor)
                {
                    case "бферзь":
                        mogno = bferzr1.Bferzrule(sender, secondsender, figures);
                        break;
                    case "бпешка":
                        mogno = bpeshka1.bpeshkarule(sender, secondsender, figures, 1);//тут короче проверка на то дошла ли пешка до конца
                        break;
                    case "бпешка2":
                        mogno = bpeshka1.bpeshkarule2(sender, secondsender, figures, 1);
                        break;
                    case "бладья":
                        mogno = blad1.Bferzrule(sender, secondsender, figures);
                        break;
                    case "бслон":
                        mogno = bslon1.Bferzrule(sender, secondsender, figures);
                        break;
                    case "бконь":
                        mogno = bkon1.Bferzrule(sender, secondsender, figures);
                        break;
                    case "бкороль":
                        mogno = bkorol1.Bferzrule(sender, secondsender, figures);
                        break;
                }
            }
            return mogno;
        }
    }
}
