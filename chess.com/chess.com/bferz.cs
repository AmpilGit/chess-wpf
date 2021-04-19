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
    class bferzr
    {
        public static dynamic image;
        public static bool Bferzrule(object sender, object secondsender, string[,] figures)
        {
            var figurerules = sender as Image;
            bool mogno = false;
            bool cvet=false;
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
            if (figurerules.Name == "бферзь"&& cvet)
            {
                int y = Grid.GetRow(figurerules);//ширина
                int x = Grid.GetColumn(figurerules);//высота начиная сверху
                int y2 = Grid.GetRow(image);
                int x2 = Grid.GetColumn(image);
                mogno = false;
                int x3 = x2 - x;
                int y3 = y2 - y;
                int xcopy = x;
                int ycopy = y;
                //
                //
                //по горизонтали ходы работает
                if (x3 > 0 && y == y2) //если x3 больше нуля значит я переместил фигуру вправо и не меняя высоту 
                {

                    int count = 0;
                    if (x3 == 1)
                    {

                    }
                    else
                    {
                        while (xcopy != x2 - 1)
                        {
                            xcopy += 1;//надо вычитать если фигура перемещается влево

                            if (figures[y, xcopy] != null)
                            {
                                count += 1;

                            }
                        }
                    }
                    if (count == 0)
                    {
                        if (x == x2 || y == y2 || x3 == y3 || x3 == y3 * (-1))
                        {
                            figurerules.Name = "бферзь";
                            figures[y, x] = null;
                            figures[y2, x2] = "бферзь";
                            mogno = true;
                            count = 0;
                        }
                    }
                }
                if (x3 < 0 && y == y2) //если x3 меньше нуля значит я переместил фигуру влево и не меняя высоту 
                {
                    int count = 0;
                    if (x3 == -1)
                    {

                    }
                    else
                    {
                        while (xcopy != x2 + 1)
                        {
                            xcopy -= 1;//надо вычитать если фигура перемещается влево
                            if (figures[y, xcopy] != null)
                            {
                                count += 1;
                            }
                        }
                    }
                    if (count == 0)
                    {
                        figurerules.Name = "бферзь";
                        figures[y, x] = null;
                        figures[y2, x2] = "бферзь";
                        mogno = true;
                        count = 0;

                    }
                }
                // ходы ферзя по вертикали работает
                //
                if (y3 > 0 && x == x2) //ходы вниз относительно белых для ферзя
                {
                    int count = 0;

                    if (y3 == 1)
                    {

                    }
                    else
                    {
                        while (ycopy != y2 - 1)
                        {
                            ycopy += 1;//надо вычитать если фигура перемещается влево
                            if (figures[ycopy, x] != null)
                            {
                                count += 1;
                            }
                        }
                    }
                    if (count == 0)
                    {
                        figurerules.Name = "бферзь";
                        figures[y, x] = null;
                        figures[y2, x2] = "бферзь";
                        mogno = true;
                        count = 0;

                    }
                }
                if (y3 < 0 && x == x2) //ходы вверх относительно белых
                {
                    int count = 0;
                    if (y3 == -1)
                    {
                        mogno = true;
                    }
                    else
                    {
                        while (ycopy != y2 + 1)
                        {
                            ycopy -= 1;//надо вычитать если фигура перемещается влево
                            if (figures[ycopy, x] != null)
                            {
                                count += 1;

                            }
                        }
                    }
                    if (count == 0)
                    {
                        figurerules.Name = "бферзь";
                        figures[y, x] = null;
                        figures[y2, x2] = "бферзь";
                        mogno = true;
                        count = 0;

                    }
                }
                //ходы по диагонали
                //
                if (y3 > 0 && x3 > 0) //ходы  по диагонали вниз в право относительно белых работает не трогаю пока
                {
                    int count = 0;

                    if (y3 == 1 && x3 == 1)
                    {
                    }
                    else
                    {
                        while (ycopy != y2 - 1 && xcopy != x2 - 1)
                        {
                            ycopy += 1;
                            xcopy += 1;

                            if (figures[ycopy, xcopy] != null)
                            {
                                count += 1;
                            }
                        }
                    }
                    if (count == 0)
                    {
                        if (y3 == x3 || x3 == y3 * -1)
                        {
                            figurerules.Name = "бферзь";
                            figures[y, x] = null;
                            figures[y2, x2] = "бферзь";
                            mogno = true;
                            count = 0;
                        }
                    }
                }
                if (y3 < 0 && x3 > 0) //ходы  по диагонали вверх в право относительно белых работает не трогаю пока
                {
                    int count = 0;
                    if (y3 == 1 && x3 == 1)
                    {
                    }
                    else
                    {
                        while (ycopy != y2 + 1 && xcopy != x2 + 1)
                        {

                            ycopy -= 1;
                            xcopy += 1;

                            if (figures[ycopy, xcopy] != null)
                            {
                                count += 1;
                            }
                        }
                    }
                    if (count == 0)
                    {
                        if (y3 == x3 || x3 == y3 * -1)
                        {
                            figurerules.Name = "бферзь";
                            figures[y, x] = null;
                            figures[y2, x2] = "бферзь";
                            mogno = true;
                            count = 0;
                        }
                    }
                }
                if (y3 > 0 && x3 < 0) //ходы  по диагонали вниз в влево относительно белых  работает пока не трогаю
                {
                    int count = 0;

                    if (y3 == 1 && x3 == 1)
                    {
                        mogno = true;
                    }
                    if (y3 == x3 || x3 == y3 * -1)
                    {
                        while (ycopy != y2 - 1 && xcopy != x2 - 1)
                        {
                            ycopy += 1;
                            xcopy -= 1;

                            if (figures[ycopy, xcopy] != null)
                            {
                                count += 1;
                            }
                        }
                    }
                    if (count == 0)
                    {
                        figurerules.Name = "бферзь";
                        figures[y, x] = null;
                        figures[y2, x2] = "бферзь";
                        mogno = true;
                        count = 0;

                    }
                }
                if (y3 < 0 && x3 < 0) //ходы  по диагонали вверз в влево относительно белых работает пока не трогаю
                {
                    int count = 0;
                    if (y3 == 1 && x3 == 1)
                    {
                        mogno = true;
                    }
                    else 
                    { 
                        while (ycopy != y2 + 1 && xcopy != x2 + 1)
                        {
                            ycopy -= 1;
                            xcopy -= 1;

                            if (figures[ycopy, xcopy] != null)
                            {
                                count += 1;
                            }
                        }
                    }
                    if (count == 0 && (y3 == x3 || x3 == y3 * -1))
                    {
                        figurerules.Name = "бферзь";
                        figures[y, x] = null;
                        figures[y2, x2] = "бферзь";
                        mogno = true;
                        count = 0;
                    }
                }

                //
            }
            // ферзь закончился все он готов и это удивительно
            // дальше идет пешка она тоже впринципе готова
            return mogno;
        }
    }
}
