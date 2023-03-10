/*
 * A dona de um pensionato possui dez quartos para alugar para estudantes,
 * sendo esses quartos identificados pelos números 0 a 9.
 * 
 * Fazer um programa que inicie com todos os dez quartos vazios e, depois leia uma quantidade N representando
 * o número de estudantes que vão alugar quartos (N pode ser de 1 a 10). Em seguida, registre o aluguel
 * dos N estudantes. Para cada registro de aluguel, informar o nome e e-mail do estudantes, bem como qual dos
 * quartos ele escolheu (de 0 a 9).
 * 
 * Suponha que seja escolhido um quarto vago. Ao final, seu programa deve imprimir um relatório de todas as 
 * ocupações do pensionado, por ordem de quarto, conforme exemplo.
 * 
 * How many rooms will be rented? 3
 * 
 * Rent #1:
 * Name: Maria Green
 * Email: maria@gmail.com
 * Room: 5
 * 
 * Rent #2:
 * Name: Marco Antonio
 * Email: marco@gmail.com
 * Room: 1
 * 
 * Rent #3:
 * Name: Alex Brown
 * Email: alex@gmail.com
 * Room: 8
 * 
 * Busy Rooms:
 * 1: Marco Antonio, marco@gmail.com
 * 5: Maria Green, maria@gmail.com
 * 8: Alex Brown, alex@gmail.com
 */

using ExercicioVetores;
using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            //cria vetor
            Quartos[] vetorQuartos = new Quartos[10];

            //le quantidade de quartos a serem alugados
            Console.Write("How many rooms will be rented? ");
            int N = int.Parse(Console.ReadLine());


            //preenche nome, email e quarto
            for (int i = 0; i < N; i++)
            {
                Console.Write("Rent #" + (i + 1));

                Console.WriteLine();

                Console.Write("Name: ");
                string nome = Console.ReadLine();

                Console.Write("E-mail: ");
                string email = Console.ReadLine();

                Console.Write("Room: ");
                int room = int.Parse(Console.ReadLine());
                vetorQuartos[room] = new Quartos { Name = nome, Email = email, Room = room};
                Console.WriteLine();

                Console.Clear();
            }

            Console.WriteLine("Busy Rooms:");
            for (int i = 0; i < vetorQuartos.Length; i++)
            {
                if (vetorQuartos[i] == null)
                {
                    continue;                    
                } else
                {
                    Console.WriteLine(vetorQuartos[i].Room + ": " + vetorQuartos[i].Name + ", " + vetorQuartos[i].Email);
                }

            }



        }
    }
}