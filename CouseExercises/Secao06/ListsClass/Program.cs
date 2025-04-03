using System;
using System.Globalization;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Runtime.InteropServices;

namespace ListsClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();

            names.Add("Maria");
            names.Add("Patricia");
            names.Add("Rui");
            names.Add("Pedro");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("===============================");
            names.Insert(3, "Wilkson");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("===============================");
            Console.WriteLine($"Tamanho da lista é {names.Count}");

            Console.WriteLine("===============================");
            string s1 = names.Find(x => x[0] == 'P');
            Console.WriteLine($"O primeiro da lista com 'P' é {s1}");

            Console.WriteLine("===============================");
            string s2 = names.FindLast(x => x[0] == 'P');
            Console.WriteLine($"O ultimo da lista com 'P' é {s2}");

            Console.WriteLine("===============================");
            int pos01 = names.FindIndex(x => x[0] == 'P');
            Console.WriteLine($"O primeiro da lista com 'P' está em  {pos01 + 1}");

            Console.WriteLine("===============================");
            int pos02 = names.FindLastIndex(x => x[0] == 'P');
            Console.WriteLine($"O ultimo da lista com 'P' está em {pos02 + 1}");

            Console.WriteLine("===============================");
            Console.WriteLine($"Os nomes com 05 caracteres são:");
            List<string> names02 = new List<string>();

            names02 = names.FindAll(x => x.Length == 5);
            foreach (string name in names02)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("===============================");
            Console.WriteLine($"Lista atualizada:");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("===============================");
            Console.Write("Insira o nome que você deseja exluir:");
            string rem = Console.ReadLine();
            names.Remove(rem);
            Console.WriteLine($"Nova lista após retirado {rem}");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }


            Console.WriteLine("===============================");
            Console.WriteLine("Vamos remover os nomes iniciados por:");
            char remIni = char.Parse(Console.ReadLine());
            names.RemoveAll(x => x[0] == remIni);
            Console.WriteLine($"Nova lista após a aplicação do filtro:");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("===============================");
            Console.Write("Insira a posição que você deseja exluir:");
            int remPos = int.Parse(Console.ReadLine());
            names.RemoveAt(remPos);
            Console.WriteLine($"Nova lista após retirado a posição {remPos}");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            string resp = "S";
            while (resp != "N")
            {
                Console.WriteLine("Qual nome deseja inserir na lista");
                names.Add(Console.ReadLine());
                Console.WriteLine("Deseja inseria outro nome? S ou N");
                resp = Console.ReadLine();
                while (resp != "S" && resp != "N")
                {
                    Console.WriteLine("Por gentileza insira um valor válido 'S' ou 'N'");
                    resp = Console.ReadLine();
                }
            }
            Console.WriteLine("===============================");
            Console.WriteLine($"Nova lista após inseridos os novos nomes:");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("===============================");
            Console.Write("A partir de que posição você deseja exluir os nomes?");
            remPos = int.Parse(Console.ReadLine());
            Console.Write("Quandos nomes você deseja remover?");
            int remPosQtd = int.Parse(Console.ReadLine());
            names.RemoveRange(remPos, remPosQtd);
            Console.WriteLine($"Nova lista após excluidos os nomes:");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }


            Console.Write("Insira a posição que você deseja exluir:");
        }
    }
}


