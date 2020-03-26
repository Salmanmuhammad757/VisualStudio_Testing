using System;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Threading;
using OpenQA.Selenium.Support.UI;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            driver.Navigate().GoToUrl("http://github.com/salmanmuhammad757");
            Thread.Sleep(3000);

       //     driver.FindElement(By.XPath("//span[@class='repo']")).Click();
        //    Thread.Sleep(3000);

            driver.FindElement(By.XPath("//a[@class='Salmanmuhammad757?tab=following']")).Click();
            Thread.Sleep(3000);

            driver.Quit();

        }
    }
}
