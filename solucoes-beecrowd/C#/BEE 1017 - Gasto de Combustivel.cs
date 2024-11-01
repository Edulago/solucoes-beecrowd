namespace solucoes_beecrowd.C_
{
    public class BEE1017
    {
        public static void Execute()
        {
            int tempo = int.Parse(Console.ReadLine());
            int velocidade = int.Parse(Console.ReadLine());
            double consumo = 12.0;

            int distancia = tempo * velocidade;
            double litrosGastos = distancia / consumo;

            Console.WriteLine(litrosGastos.ToString("F3"));
        }
    }
}
