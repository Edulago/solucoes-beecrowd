namespace solucoes_beecrowd.C_
{
    class BEE1014
    {
        public static void Execute()
        {
            int X = int.Parse(Console.ReadLine());
            double Y = double.Parse(Console.ReadLine());

            double Consumo = X / Y;

            Console.WriteLine($"{Consumo.ToString("F3")} km/l");
        }
    }
}
