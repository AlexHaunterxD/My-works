using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoKenPo
{
    class Program
    {
        static void Main(string[] args)
        {
            string jogador;
            string maquina;
            int ValorSorteado;
            Random sorte = new Random();

            while (true)
            {
                Console.WriteLine("Escolha entre PEDRA, PAPEL ou TESOURA. NÃO ESCOLHA MAIS DE UM, IDIOTA!");
                jogador = Console.ReadLine().ToUpper();
                ValorSorteado = sorte.Next(1, 4);
                {
                    if (ValorSorteado == 1)

                    { maquina = "PEDRA"; }


                    else if (ValorSorteado == 2)
                    {
                        maquina = "PAPEL";
                    }
                    else

                    { maquina = "TESOURA"; }

                      if (jogador == "PEDRA" && maquina == "PAPEL")
                    {
                        Console.WriteLine("Eu tirei " + maquina);
                        Console.WriteLine("Perdeu, Playboy!");
                    }
                    else if (jogador == "PEDRA" && maquina == "PEDRA")

                    {
                        Console.WriteLine("Eu tirei " + maquina);
                        Console.WriteLine("EMPATOU! INÚTIL, PRA QUE ME IMITAR?");
                    }
                    else if (jogador == "PEDRA" && maquina == "TESOURA") 

                    {
                        Console.WriteLine("Eu tirei " + maquina);
                        Console.WriteLine("Parabéns! Parece que você não é tão babaca quanto eu pensei!");

                    }
                    else if (jogador == "PAPEL" && maquina == "PAPEL")
                    {
                        Console.WriteLine("Eu tirei " + maquina);
                        Console.WriteLine("EMPATOU! INÚTIL, PRA QUE ME IMITAR?");
                    }
                    else if (jogador == "PAPEL" && maquina == "TESOURA")
                    {
                        Console.WriteLine("Eu tirei " + maquina);
                        Console.WriteLine("Perdeu, Playboy!");
                    }
                    else if (jogador == "PAPEL" && maquina == "PEDRA")
                    {
                        Console.WriteLine("Eu tirei " + maquina);
                        Console.WriteLine("Parabéns! Parece que você não é tão babaca quanto eu pensei!");

                    }
                    else if (jogador == "TESOURA" && maquina == "TESOURA")
                    {
                        Console.WriteLine("Eu tirei " + maquina);
                        Console.WriteLine("EMPATOU! INÚTIL, PRA QUE ME IMITAR?");
                    }
                    else if (jogador == "TESOURA" && maquina == "PAPEL")
                    {
                        Console.WriteLine("Eu tirei " + maquina);
                        Console.WriteLine("Parabéns! Parece que você não é tão babaca quanto eu pensei!");
                    }
                    else if (jogador == "TESOURA" && maquina == "PEDRA")
                    {
                        Console.WriteLine("Eu tirei " + maquina);
                        Console.WriteLine("Perdeu, Playboy!");
                    }

                }
            }
        }
    }
}

