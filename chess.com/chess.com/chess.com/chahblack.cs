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
        public static bool rules(int xforchahcorol,int yforchahcorol,string nameofigureinmassdo,int xofigureinmassdo,int yofigureinmassdo,string[,]massdo)
        {
            bool mogno = false;
            string namevybor = nameofigureinmassdo;
            if (hody.hodch)
            {
                switch (namevybor)
                {
                    case "бферзь":
                        mogno = bferz2.Bferzrule(xforchahcorol,yforchahcorol,nameofigureinmassdo,xofigureinmassdo,yofigureinmassdo,massdo);
                        break;
                    case "бпешка":
                        mogno = bpeshka2.bpeshkarule(xforchahcorol, yforchahcorol, nameofigureinmassdo, xofigureinmassdo, yofigureinmassdo, massdo);//тут короче проверка на то дошла ли пешка до конца
                        break;
                    case "бпешка2":
                        mogno = bpeshka2.bpeshkarule2(xforchahcorol, yforchahcorol, nameofigureinmassdo, xofigureinmassdo, yofigureinmassdo, massdo);
                        break;
                    case "бладья":
                        mogno = blad2.Bferzrule(xforchahcorol, yforchahcorol, nameofigureinmassdo, xofigureinmassdo, yofigureinmassdo, massdo);
                        break;
                    case "бслон":
                        mogno = bslon2.Bferzrule(xforchahcorol, yforchahcorol, nameofigureinmassdo, xofigureinmassdo, yofigureinmassdo, massdo);
                        break;
                    case "бконь":
                        mogno = bkon2.Bferzrule(xforchahcorol,yforchahcorol,nameofigureinmassdo,xofigureinmassdo,yofigureinmassdo,massdo);
                        break;
                    case "бкороль":
                        mogno = bkorol2.Bferzrule(xforchahcorol, yforchahcorol, nameofigureinmassdo, xofigureinmassdo, yofigureinmassdo, massdo);
                        break;
                }
            }
            return mogno;
        }
    }
}
