﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasksDLL
{
    public class Triangle
    {
        Point A = new Point();
        Point B = new Point();
        Point C = new Point();

        public Triangle(Point A, Point B, Point C)
        {
            this.A = A;
            this.B = B;
            this.C = C;
        }

        public void Info()
        {
            Console.WriteLine("Координаты треугольника:");
            Console.WriteLine("A(" + A.x + "," + A.y + ")");
            Console.WriteLine("B(" + B.x + "," + B.y + ")");
            Console.WriteLine("C(" + C.x + "," + C.y + ")");
        }
    }

    public struct Point
    {
        public double x, y;

        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

    }

    public static class FindTriangle
    {
        public static void Find()
        {
            Console.WriteLine("Введите координату x центра: ");
            int x = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите координату y центра: ");
            int y = Int32.Parse(Console.ReadLine());
            int R = 5; //произвольный радиус окружности 

            Point O = new Point(x, y); //центр треугольника

            Point B = new Point(x, y + R); //координата B треугольника

            Point A = new Point(x + R * Math.Cos(7 * 3.14 / 6), y + R * Math.Sin(7 * 3.14 / 6));
            Point C = new Point(x + R * Math.Cos(11 * 3.14 / 6), y + R * Math.Sin(11 * 3.14 / 6));

            Triangle tr = new Triangle(A, B, C); //создаем треугольник   

            tr.Info(); //выводим информацию о нем

            Console.ReadKey();

        }
    }
}
