using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Collections.Generic;

namespace GetTableSelenium
{
    static class GetTable
    {
        private static IWebDriver driver;

        [SetUp]
        private static void SetUp()
        {
            driver = new ChromeDriver();
        }
        [TearDown]
        private static void TearDown()
        {
            driver.Close();
            driver.Quit();
        }
        [Test]
        public static Table Get(string url, string idTable)
        {
            SetUp();
            driver.Navigate().GoToUrl(url);

            var table = driver.FindElement(By.Id(idTable));
            var tr = table.FindElements(By.TagName("tr"));

            List<string> headers = new List<string>();
            List<List<string>> rows = new List<List<string>>();

            foreach (IWebElement element in tr)
            {
                var ths = element.FindElements(By.TagName("th"));
                var tds = element.FindElements(By.TagName("td"));
                List<string> row = new List<string>();
                if (ths.Count != 0)
                {
                    foreach (IWebElement th in ths)
                    {
                        headers.Add(th.Text);
                    }
                }
                if (tds.Count != 0)
                {

                    foreach (IWebElement td in tds)
                    {
                        row.Add(td.Text);
                    }
                    rows.Add(row);
                }
            }

            TearDown();

            return new Table(headers,rows);
        }
    }
}
