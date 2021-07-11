using System;

namespace media_desvio_e_moda
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double[] alturas = new double[10];
                int ind = 0; // ind == Índice

                inicio();

                for (int i = 1; i < 11; i++)
                {
                    Console.Write($"- Insira a {i}º altura (em Metros): ");
                    alturas[ind] = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine();

                    if (alturas[ind] < 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Atenção!! O valor de altura não pode ser negativo.");
                        Console.ResetColor();

                        Environment.Exit(-1);
                    }

                    ind++;
                }

                // Média:

                double media = (alturas[0] + alturas[1] + alturas[2] + alturas[3] +
                               alturas[4] + alturas[5] + alturas[6] + alturas[7] +
                               alturas[8] + alturas[9]) / 10;

                Console.WriteLine("\n *Lembrando que a média e o desvio padrão se dá somente pelas dez alturas. \n");

                Console.WriteLine($"\n |=> A média entre as dez alturas é de: {media:N2} M.");
                Console.WriteLine(" |");

                // Desvio Padrão:

                double DesvioPadrao = Math.Sqrt(Math.Pow((alturas[0] - media), 2) +
                                    Math.Pow((alturas[1] - media), 2) +
                                    Math.Pow((alturas[2] - media), 2) +
                                    Math.Pow((alturas[3] - media), 2) +
                                    Math.Pow((alturas[4] - media), 2) +
                                    Math.Pow((alturas[5] - media), 2) +
                                    Math.Pow((alturas[6] - media), 2) +
                                    Math.Pow((alturas[7] - media), 2) +
                                    Math.Pow((alturas[8] - media), 2) +
                                    Math.Pow((alturas[9] - media), 2)) / 10;

                Console.WriteLine($" |=> O Desvio Padrão entre as dez alturas é de: {DesvioPadrao:N4} M.\n");
            }

            catch (FormatException)
            {
                Console.WriteLine();

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Atenção!! O valor de entrada não está no formato correto.");
                Console.ResetColor();
            }

            catch (OverflowException)
            {
                Console.WriteLine();

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Atenção!! O valor de entrada excede o tamanho suportado.");
                Console.ResetColor();
            }
        }

        static void inicio()
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Exercício Media, Desvio e Moda");
            Console.ResetColor();
            Console.WriteLine();

            Console.Write("=> Criação de um vetor de 10 alturas e elaboração ");
            Console.WriteLine("de algoritmos que calculem a média, o desvio padrão e a moda entre as alturas.");
            Console.Write("--------------------------------------------------------------------------------");
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine();
        }

        static void primeiraVersão()
        {
            // Console.Write("- Insira a primeira altura...: ");
            // alturas[0] = Convert.ToDouble(Console.ReadLine());
            // Console.WriteLine();

            // Console.Write("- Insira a segunda altura....: ");
            // alturas[1] = Convert.ToDouble(Console.ReadLine());
            // Console.WriteLine();

            // Console.Write("- Insira a terceira altura...: ");
            // alturas[2] = Convert.ToDouble(Console.ReadLine());
            // Console.WriteLine();

            // Console.Write("- Insira a quarta altura.....: ");
            // alturas[3] = Convert.ToDouble(Console.ReadLine());
            // Console.WriteLine();

            // Console.Write("- Insira a quinta altura.....: ");
            // alturas[4] = Convert.ToDouble(Console.ReadLine());
            // Console.WriteLine();

            // Console.Write("- Insira a sexta altura......: ");
            // alturas[5] = Convert.ToDouble(Console.ReadLine());
            // Console.WriteLine();

            // Console.Write("- Insira a sétima altura.....: ");
            // alturas[6] = Convert.ToDouble(Console.ReadLine());
            // Console.WriteLine();

            // Console.Write("- Insira a oitava altura.....: ");
            // alturas[7] = Convert.ToDouble(Console.ReadLine());
            // Console.WriteLine();

            // Console.Write("- Insira a nona altura.......: ");
            // alturas[8] = Convert.ToDouble(Console.ReadLine());
            // Console.WriteLine();

            // Console.Write("- Insira a décima altura.....: ");
            // alturas[9] = Convert.ToDouble(Console.ReadLine());
            // Console.WriteLine();
        }
    }
}
