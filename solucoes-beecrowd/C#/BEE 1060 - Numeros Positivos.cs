namespace solucoes_beecrowd.C_
{
    public class BEE1060
    {
        public static void Execute()
        {
            int valores = 0;
            for (int i = 0; i < 6; i++)
            {
                double x = double.Parse(Console.ReadLine());
                if (x > 0)
                {
                    valores++;
                }
            }
            Console.WriteLine($"{valores} valores positivos");
        }
    }
}
