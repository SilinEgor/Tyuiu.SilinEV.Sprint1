﻿using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.SilinEV.Sprint1.Task3.V13.Lib
{
    public class DataService : ISprint1Task3V13
    {
        public double MultiplyOfDigits(double number)
        {
            string a = number.ToString();
            return a[0] * a[1] * a[2];
        }
    }
}
