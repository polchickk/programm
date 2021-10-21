﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task6._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Написать метод, который определяет, принадлежит ли точка с координатами(x,y)
            //указанной области(метод возвращает логическое значение).
            //    Волнистая граница означает, что в указанном направлении область неограничена.
            var x = InputCoordinate("абсциссу");
            var y = InputCoordinate("ординату");
            Console.WriteLine($"Точка внутри области " + IsInsideArea(x,y));
            Console.ReadKey();
        }
        static bool IsInsideArea(double x,double y)
        {
            return y >= 1 || x <= -3 ;
        }
        static double InputCoordinate(string name)
        {
            Console.WriteLine($"Введите {name} точки");
            return double.Parse(Console.ReadLine());
        }
    }
}
