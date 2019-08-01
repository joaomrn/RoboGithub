using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.IO;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Informe o diretorio que vc extraiu o chromedriver_win32:");
            //string diretorio = Console.ReadLine();

            Console.WriteLine("Informe o Login do Github:");
            string login = Console.ReadLine();

            Console.WriteLine("Informe a senha do Github:");
            string senha = Console.ReadLine();

            IWebDriver driver = new ChromeDriver(@"C:\_Projetos\Robo\ConsoleApp1\chromedriver_win32");
            //IWebDriver driver = new ChromeDriver(diretorio);
            driver.Navigate().GoToUrl("https://github.com/login");

            Thread.Sleep(2000);

            driver.FindElement(By.Id("login_field")).SendKeys(login);

            Thread.Sleep(2000);

            driver.FindElement(By.Id("password")).SendKeys(senha);

            Thread.Sleep(2000);

            driver.FindElement(By.XPath("//*[@id='login']/form/div[3]/input[4]")).Click();

            Thread.Sleep(2000);

            driver.FindElement(By.XPath("/html/body/div[1]/header/div[8]/details/summary")).Click();

            Thread.Sleep(2000);

            
            driver.FindElement(By.XPath("/html/body/div[1]/header/div[8]/details/details-menu/form/button")).Click();

            Thread.Sleep(3000);

            driver.Close();




        }
    }
}
