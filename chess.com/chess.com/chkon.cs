﻿using System;
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
    class chkon
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
                mogno = false;
                ////x+2 y+1; x+1 y+2 ; x-2 y+1;x-1 y+2;x+2 y-1; x+1 y-2 ; x-2 y-1;x-1 y-2;
                if (y + 2 == y2 && x + 1 == x2)
                {
                    figurerules.Name = "чконь";
                    image.Name = "";
                    figuresarr.figures[x, y] = null;
                    figuresarr.figures[x2, y2] = "чконь";
                    mogno = true;
                }
                ////x+2 y+1; x+1 y+2 ; x-2 y+1;x-1 y+2;x+2 y-1; x+1 y-2 ; x-2 y-1;x-1 y-2;
                if (y + 1 == y2 && x + 2 == x2)
                {
                    figurerules.Name = "чконь";
                    image.Name = "";
                    figuresarr.figures[x, y] = null;
                    figuresarr.figures[x2, y2] = "чконь";
                    mogno = true;
                }
                ////x-2 y+1;x-1 y+2;x+2 y-1; x+1 y-2 ; x-2 y-1;x-1 y-2;
                if (y - 2 == y2 && x + 1 == x2)
                {
                    figurerules.Name = "чконь";
                    image.Name = "";
                    figuresarr.figures[x, y] = null;
                    figuresarr.figures[x2, y2] = "чконь";
                    mogno = true;
                }
                ////x-1 y+2;x+2 y-1; x+1 y-2 ; x-2 y-1;x-1 y-2;
                if (y - 1 == y2 && x + 2 == x2)
                {
                    figurerules.Name = "чконь";
                    image.Name = "";
                    figuresarr.figures[x, y] = null;
                    figuresarr.figures[x2, y2] = "чконь";
                    mogno = true;
                }
                ////x+2 y-1; x+1 y-2 ; x-2 y-1;x-1 y-2;
                if (y + 2 == y2 && x - 1 == x2)
                {
                    figurerules.Name = "чконь";
                    image.Name = "";
                    figuresarr.figures[x, y] = null;
                    figuresarr.figures[x2, y2] = "чконь";
                    mogno = true;
                }
                // x+1 y-2 ; x-2 y-1;x-1 y-2;
                if (y + 1 == y2 && x - 2 == x2)
                {
                    figurerules.Name = "чконь";
                    image.Name = "";
                    figuresarr.figures[x, y] = null;
                    figuresarr.figures[x2, y2] = "чконь";
                    mogno = true;
                }
                //x - 2 y - 1; x - 1 y - 2;
                if (y - 2 == y2 && x - 1 == x2)
                {
                    figurerules.Name = "чконь";
                    image.Name = "";
                    figuresarr.figures[x, y] = null;
                    figuresarr.figures[x2, y2] = "чконь";
                    mogno = true;
                }
                //x - 1 y - 2;
                if (y - 1 == y2 && x - 2 == x2)
                {
                    figurerules.Name = "чконь";
                    image.Name = "";
                    figuresarr.figures[x, y] = null;
                    figuresarr.figures[x2, y2] = "чконь";
                    mogno = true;
                }
            }
            return mogno;
        }
    }
}
