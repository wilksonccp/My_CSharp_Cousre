using System;
using System.Globalization;

namespace StingFuntions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string original = " abcde FGHI jklmn bcOPQRS   ";

            string s1 = original.ToUpper();
            string s2 = original.ToLower();
            string s3 = original.Trim();

            int n1 = original.IndexOf("bc");
            int n2 = original.LastIndexOf("bc");
            
            string s4 = original.Substring(5);
            string s5 = original.Substring(5, 5);
            string s6 = original.Replace("bc", "=>HERE<=");

            bool b1 = string.IsNullOrEmpty(original);
            bool b2 = string.IsNullOrWhiteSpace(original);
            
            
            Console.WriteLine($" Original : -{original}-");
            Console.WriteLine($"ToUpper: -{s1}-");
            Console.WriteLine($"====================================");
            Console.WriteLine($"ToLower: -{s2}-");
            Console.WriteLine($"====================================");
            Console.WriteLine($"Trim: -{s3}-");
            Console.WriteLine($"====================================");
            Console.WriteLine($"The intex of 'bc' is : -{n1}-");
            Console.WriteLine($"====================================");
            Console.WriteLine($"The lest intex of 'bc' is : -{n2}-");
            Console.WriteLine($"====================================");
            Console.WriteLine($"Substring with only index : -{s4}-");
            Console.WriteLine($"====================================");
            Console.WriteLine($"Substring with index and lenth : -{s5}-");
            Console.WriteLine($"====================================");
            Console.WriteLine($"Replace : -{s6}-");
            Console.WriteLine($"====================================");
            Console.WriteLine($"IsNullOrEmpty :  -{b1}-");
            Console.WriteLine($"====================================");
            Console.WriteLine($"IsNullOrWhiteSpace : -{b2}-");
            Console.WriteLine($"====================================");
        }
    }
}


