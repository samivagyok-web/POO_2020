﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
          //  Point p1 = new Point();
          //  Point p2 = new Point(3.14, 4.15);
            Point p3 = new Point(5, 6);
            //  Point p4 = new Point("  ( 3 .0          ,  4.0    ) ");

            p3.MoveBy(1, 4);
            p3.MoveBy(-3, 9);

            p3.StepBack(2);
            p3.MoveBy(1, 1);
            Console.WriteLine(p3);

          //  Console.WriteLine($"p1 = {p1}");
          //  Console.WriteLine($"p2 = {p2}");
          //
          //
          //  Console.WriteLine($"Distanta de la punctul {p3} la origine este {p3.DistanceToOrigin()}");
          //
          //
          //  Console.WriteLine($"Distanta de la punctul {p3} la origine este {p3.DistanceTo(p2).ToString("#.##")}");
          //
          //  
          //  p1.MoveBy(-3.0, 4.0);
          //
          //  Console.WriteLine($"p1 = {p1}");
          //
          //
          //
          //
          //  Line line1 = new Line(p2, p3);
          //
          //  Line line2 = new Line(1.0, 2.0, 3.0, 4.0);
          //
          //  Console.WriteLine($"line1 = {line1}, length = {line1.Length}");
        }
    }
}