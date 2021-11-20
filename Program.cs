using System;

namespace MediaDecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            int qnt;
            int exb = 0;
            decimal valor;
            decimal soma = 0;
            decimal media = 0;
            decimal nMaior = 0;
            decimal nMenor = 0;


            Console.Write("Digite a quantidade de números: ");
            qnt = Convert.ToInt32(Console.ReadLine());

            if (qnt <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("ERRO! ");
                Console.ResetColor();
                Console.WriteLine("Quantidade digitada deve ser maior que zero.");
            }
            else
            {

                while (exb < qnt)
                {
                    exb = exb + 1;

                    Console.Write($"Número #0{exb}: ");

                    valor = Convert.ToDecimal(Console.ReadLine());

                    soma = soma + valor;

                    media = soma / qnt;

                    if (exb == 1)
                    {
                        nMaior = valor;
                        nMenor = valor;
                    }
                    else
                    {

                        if (nMaior < valor)
                        {
                            nMaior = valor;
                        }

                        if (nMenor > valor)
                        {
                            nMenor = valor;
                        }
                    }

                }
                Console.WriteLine($"Soma.: {soma:N2}");

                Console.WriteLine($"Média: {media:N2}");

                Console.WriteLine($"Maior: {nMaior:N2}");

                Console.WriteLine($"Menor: {nMenor:N2}");
            }
        }
    }
}
