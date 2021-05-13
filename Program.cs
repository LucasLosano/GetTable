using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using NUnit.Framework;

namespace GetTableSelenium
{
    class Program
    {
        static void Main(string[] args)
        {
            var table = GetTable.Get("https://www.w3schools.com/html/html_tables.asp", "customers");

            Console.Clear();
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
