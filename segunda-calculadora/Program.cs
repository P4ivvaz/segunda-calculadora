﻿internal class Program
{
    private static void Main(string[] args)
    {
        int valor;
        string respostaContinuar;

        do
        {

            Console.WriteLine("digite o primeiro número");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("$digite o segundo número:");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("$escolha a operação(/,+,-,*):");
            string symbol = Console.ReadLine();
            switch (symbol)
            {
                case "*":
                    valor = n1 * n2;
                    Console.WriteLine("Multiplicação:" + valor);
                    break;

                case "/":
                    if (n2 == 0)
                    {
                        Console.WriteLine("Erro: Divisão por zero não é permitida.");
                    }
                    else
                    {
                        valor = n1 / n2;
                        Console.WriteLine("Division: " + valor);
                    }
                    break;

                case "+":
                    valor = n1 + n2;
                    Console.WriteLine("adição:" + valor);
                    break;

                case "-":
                    valor = n1 - n2;
                    Console.WriteLine("subtraçãoo:" + valor);
                    break;


            }
            Console.Write("Deseja continuar(s/n):");
            respostaContinuar = Console.ReadLine();

        }
        while (respostaContinuar == "s");



    }
}

