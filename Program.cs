using System;
using System.Collections.Generic;

namespace GetTableSelenium
{
    class Program
    {
        static void Main(string[] args)
        {
            var table = GetTable.Get("https://www.w3schools.com/html/html_tables.asp", "customers");

            Console.Clear();
            Console.WriteLine();
            foreach (string header in table.headers)
            {
                Console.Write(header + " ");
            }

            foreach (List<string> row in table.rows)
            {
                foreach (string cell in row)
                {
                    Console.Write(cell + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }

        
    }
}
