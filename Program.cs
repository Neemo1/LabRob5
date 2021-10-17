using System;
using System.IO;
namespace LabRob5
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter p = new StreamWriter("REZ.txt");
            float a, x, y;
            p.WriteLine("    Результаты розчёта");
            for (a = 0.5f; a <= 1.25f; a += 0.25f) {

                p.WriteLine(" a= " + a);
                for (x = 1; x <= 7; x += 0.25f) {
                    if (2 * a * x < 0)
                    {
                        p.WriteLine("Корень отрицательный");
                    }
                    if (Math.Sqrt(2 * a * x) == 0) {
                        p.WriteLine("На ноль делить нельзя");
                    }
                    else
                    {
                        y = (float)(Math.Pow(Math.Sqrt((a + 1) * x), 1f / 4f) + Math.Exp(Math.Pow(-x, 3)) / Math.Sqrt(2 * a * x));
                        p.WriteLine("    x=    " + x + '\t' + "      y=    " + y);

                    }
                }
                       
            }
            p.Close();


        }
    }
}
