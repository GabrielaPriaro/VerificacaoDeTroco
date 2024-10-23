//Problema "troco_verificado"
//Fazer um programa para calcular o troco no processo de pagamento de um produto de uma mercearia.
//O programa deve ler o preço unitário do produto, a quantidade de unidades compradas deste produto,
//e o valor em dinheiro dado pelo cliente. Seu programa deve mostrar o valor do troco a ser devolvido
//ao cliente. Se o dinheiro dado pelo cliente não for suficiente, mostrar uma mensagem informando o
//valor restante.

using System.Globalization;

namespace VerificacaoDeTroco
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double precoProduto, valorRecebido, valorTotal, valorFaltante, troco;
            int quantProduto;

            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Preço unitário do produto: ");
            precoProduto = double.Parse(Console.ReadLine(), CI);

            Console.Write("Quantidade comprada: ");
            quantProduto = int.Parse(Console.ReadLine());

            Console.Write("Dinheiro recebido: ");
            valorRecebido = double.Parse(Console.ReadLine(), CI);

            valorTotal = precoProduto * quantProduto;

            if (valorTotal > valorRecebido)
            {
                valorFaltante = valorTotal - valorRecebido;
                Console.WriteLine($"DINHEIRO INSUFICIENTE. FALTAM R$ {valorFaltante.ToString("F2", CI)} REAIS");
            }
            else 
            {
                troco = valorRecebido - valorTotal;
                Console.WriteLine($"TROCO = R$ {troco.ToString("F2", CI)}");
            }
        }
    }
}
