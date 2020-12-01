using System;

namespace Produtos
{
    class Program
    {
        static void Main(string[] args)
        {
            double bolo = 5;
            Console.WriteLine("Bolos");
            Console.WriteLine("------------------");

            Console.WriteLine("Escolha o sabor do boleto M - Morango e C - Chocolate");
            string resposta = Console.ReadLine();

            while(resposta != "M" && resposta != "C"){
                Console.WriteLine("Sabor não disponível, tente novamente!");
                Console.WriteLine("M para morango e C para chocolate");
                resposta = Console.ReadLine();
            }

            Console.WriteLine($"Você escolheu a opção {resposta}");

            Console.WriteLine("Digite a quantidade: ");
            double quantidade = int.Parse(Console.ReadLine());

            if(quantidade <=5){
                double preco = quantidade * bolo;
                double desconto = preco * 0.02;
                double valorpago = preco - desconto;
                Console.WriteLine("Você recebeu um desconto de 2%");
                Console.WriteLine("O valor total é de: "+preco);
                Console.WriteLine("O valor do desconto será de: "+desconto);
                Console.WriteLine("O total a ser pago será de: "+valorpago);

            }else if(quantidade >=4 && quantidade <=10){
                double preco = quantidade * bolo;
                double desconto = preco * 0.03;
                double valorpago = preco - desconto;
                Console.WriteLine("Você recebeu um desconto de 3%");
                 Console.WriteLine("O valor total é de: "+preco);
                Console.WriteLine("O valor do desconto será de: "+desconto);
                Console.WriteLine("O total a ser pago será de: "+valorpago);

            }else if(quantidade >=10){
                double preco = quantidade * bolo;
                double desconto = preco * 0.05;
                double valorpago = preco - desconto;
                Console.WriteLine("Você recebeu um desconto de 5%");
                 Console.WriteLine("O valor total é de: "+preco);
                Console.WriteLine("O valor do desconto será de: "+desconto);
                Console.WriteLine("O total a ser pago será de: "+valorpago);
            }




        }
    }
}
