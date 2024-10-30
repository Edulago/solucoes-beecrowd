using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solucoes_beecrowd.C_
{
    class BEE1006
    {
        public static void Execute()
        {
            double A = double.Parse(Console.ReadLine());
            double B = double.Parse(Console.ReadLine());
            double C = double.Parse(Console.ReadLine());

            double media = ((A * 2.0) + (B * 3.0) + (C * 5)) / 10;

            Console.WriteLine($"MEDIA = {media}");
        }
    }
}
