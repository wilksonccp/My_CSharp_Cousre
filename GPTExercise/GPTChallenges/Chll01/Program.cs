using System;
using System.Globalization;

namespace Chll01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dados = @"C:/Temp/dados.txt";
            int cont = 0;

            using (StreamReader se = File.OpenText(dados))
            {
                string linha;
                while ((linha = se.ReadLine()) != null)
                {
                    cont++;
                }
            }

            Console.WriteLine($"O arquivo {Path.GetFileName(dados)} contém {cont} linhas");

        }
    }
}


