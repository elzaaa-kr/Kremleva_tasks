﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadachik_5_zadacha_funkcii
{
    class Program
    {
        static double Drob(double chislitel, double znamenatel)
        {
            double y = (chislitel + Math.Sin(chislitel)) / (Math.Sin(znamenatel));
            return y;
        }

        static double Rezult_Y(double y1, double y2, double y3)
        {
            double y=y1+y2+y3;
            return y;
        }

        static void Main(string[] args)
        {
            double y1;
            y1=Drob(5,6);
            Console.WriteLine("Первое слагаемое" + y1);

            double y2;
            y2=Drob(7,8);
            Console.WriteLine("Второе слагаемое" + y2);

            double y3;
            y3=Drob(7,9);
            Console.WriteLine("Третье слагаемое" + y3);
            
            double y;
            y=Rezult_Y(y1, y2, y3);
            Console.WriteLine("Значение функции" + y1);
            
            Console.ReadKey();
        }
    }
}
