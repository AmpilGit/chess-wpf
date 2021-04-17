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
    class rulesmain
    {
        public static bool rules(object sender, object secondsender, string[,] figures, int i)
        {
            bool mogno = false;
            bool ferz = false;
            var vybor = sender as Image;
            int x = Grid.GetRow(vybor);
            int y = Grid.GetColumn(vybor);
            string namevybor = figuresarr.figures[x, y];
            switch (namevybor)
            {
                case "бферзь":
                    mogno = bferzr.Bferzrule(sender, secondsender, figures);
                    break;
                case "чферзь":
                    mogno = chferz.Bferzrule(sender, secondsender, figures);
                    break;
                case "бпешка":
                    mogno = bpeshka.bpeshkarule(sender, secondsender, figures, 1);//тут короче проверка на то дошла ли пешка до конца
                    break;
                case "бпешка2":
                    mogno = bpeshka.bpeshkarule2(sender, secondsender, figures, 1);
                    break;
                case "чпешка":
                    mogno = chpeshka.bpeshkarule(sender, secondsender, figures, 1);
                    break;
                case "чпешка2":
                    mogno = chpeshka.bpeshkarule2(sender, secondsender, figures, 1);
                    break;
            }
            if (i == 1)
            {
                MessageBox.Show(ferz.ToString());
                return ferz;
            }
            else
            {
                return mogno;
            }
        }
    }
}
