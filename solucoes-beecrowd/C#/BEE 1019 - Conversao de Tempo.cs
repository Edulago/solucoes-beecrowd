namespace solucoes_beecrowd.C_
{
    public class BEE1019
    {
        public static void Execute()
        {
            int N = int.Parse(Console.ReadLine());
            int horas = N / 3600;
            int minutos = (N % 3600) / 60;
            int segundos = N % 60;

            Console.WriteLine($"{horas}:{minutos}:{segundos}");
        }
    }
}
