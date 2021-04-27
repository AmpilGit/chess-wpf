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
        public static bool rules(int xforchahcorol, int yforchahcorol, string nameofigureinmassdo, int xofigureinmassdo, int yofigureinmassdo, string[,] massdo)
        {
            bool mogno = false;
            string namevybor = nameofigureinmassdo;
            if (hody.hodb)
            {
                switch (namevybor)
                {
                    case "чферзь":
                        mogno = chferz2.Bferzrule(xforchahcorol, yforchahcorol, nameofigureinmassdo, xofigureinmassdo, yofigureinmassdo, massdo);
                        break;
                    case "чпешка":
                        mogno = chpeshka2.bpeshkarule(xforchahcorol, yforchahcorol, nameofigureinmassdo, xofigureinmassdo, yofigureinmassdo, massdo);//тут короче проверка на то дошла ли пешка до конца
                        break;
                    case "чпешка2":
                        mogno = chpeshka2.bpeshkarule2(xforchahcorol, yforchahcorol, nameofigureinmassdo, xofigureinmassdo, yofigureinmassdo, massdo);
                        break;
                    case "чладья":
                        mogno = chlad2.Bferzrule(xforchahcorol, yforchahcorol, nameofigureinmassdo, xofigureinmassdo, yofigureinmassdo, massdo);
                        break;
                    case "чслон":
                        mogno = chslon2.Bferzrule(xforchahcorol, yforchahcorol, nameofigureinmassdo, xofigureinmassdo, yofigureinmassdo, massdo);
                        break;
                    case "чконь":
                        mogno = chkon2.Bferzrule(xforchahcorol, yforchahcorol, nameofigureinmassdo, xofigureinmassdo, yofigureinmassdo, massdo);
                        break;
                    case "чкороль":
                        mogno = chkorol2.Bferzrule(xforchahcorol, yforchahcorol, nameofigureinmassdo, xofigureinmassdo, yofigureinmassdo, massdo);
                        break;
                }
            }
            return mogno;
        }
    }
}
