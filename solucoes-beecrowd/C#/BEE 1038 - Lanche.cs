namespace solucoes_beecrowd.C_
{
    public class BEE1038
    {
        public static void Execute()
        {
            string[] pedidos = Console.ReadLine().Split(" ");
            int codigo = int.Parse(pedidos[0]);
            int qtd = int.Parse(pedidos[1]);
            double valor = 0.00;

            switch (codigo)
            {
                case 1:
                    valor = qtd * 4.00; 
                    break;
                case 2:
                    valor = qtd * 4.50;
                    break;
                case 3:
                    valor = qtd * 5.00;
                    break;
                case 4:
                    valor = qtd * 2.00;
                    break;
                case 5:
                    valor = qtd * 1.50;
                    break;
            }
            Console.WriteLine($"Total: R$ {valor.ToString("F2")}");
        }
    }
}
