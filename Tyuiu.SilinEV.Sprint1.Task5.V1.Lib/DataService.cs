﻿using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.SilinEV.Sprint1.Task5.V1.Lib
{
    public class DataService : ISprint1Task5V1
    {
        public int DistanceBetweenDots(double x1, double y1, double x2, double y2)
        {
            double x = Math.Abs(x1 - x2), y = Math.Abs(y1 - y2);
            return Convert.ToInt32(Math.Sqrt(x * x + y * y));
        }
    }
}
