using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.SilinEV.Sprint1.Task3.V13.Lib
{
    public class DataService : ISprint1Task3V13
    {
        public double MultiplyOfDigits(double a)
        {
            int[] s = new int[3];
            string d = Convert.ToString(a);
            for (int i = 0; i < s.Length; i++)
            {
                s[i] = Convert.ToInt32(d[i]);
            }
            return s[0] * s[1] * s[2];
        }
    }
}
