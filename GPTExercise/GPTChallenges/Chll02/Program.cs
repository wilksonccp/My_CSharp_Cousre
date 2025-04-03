using System;
using System.IO;
using System.Globalization;

namespace Chll02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dados = @"C:/Temp/dados.txt";
            Console.Write("Digite a palavra que deseja buscar no arquivo: ");
            string WordFind = Console.ReadLine().ToLower(); // Converter para minúsculas
            int cont = 0;

            using (StreamReader sr = File.OpenText(dados))
            {
                string linha;
                while ((linha = sr.ReadLine()) != null)
                {
                    string[] WordsLine = linha.Split(' ');

                    foreach (string word in WordsLine)
                    {
                        // Remove pontuação e compara em minúsculas
                        if (word.Trim(' ', '.', ',', ';', ':', '!', '?').ToLower() == WordFind)
                        {
                            cont++;
                        }
                    }
                }
            }

            Console.WriteLine($"No arquivo {Path.GetFileName(dados)} contém {cont} vez(es) a palavra \"{WordFind}\".");
        }
    }
}
