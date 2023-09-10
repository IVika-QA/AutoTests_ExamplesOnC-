using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

class Program
{
    static void Main()
    {
        string link = "http://suninjuly.github.io/simple_form_find_task.html";

        IWebDriver driver = new ChromeDriver();
        try
        {
            driver.Navigate().GoToUrl(link);
            // Это то, что находится в начале строки, например input, button, label
            IWebElement input1 = driver.FindElement(By.TagName("input"));
            input1.SendKeys("Ivan");
            IWebElement input2 = driver.FindElement(By.Name("last_name"));
            input2.SendKeys("Petrov");
            IWebElement input3 = driver.FindElement(By.ClassName("form-control.city"));
            input3.SendKeys("Smolensk");
            IWebElement input4 = driver.FindElement(By.Id("country"));
            input4.SendKeys("Russia");
            IWebElement button = driver.FindElement(By.CssSelector("button.btn"));
            button.Click();
        }
        finally
        {
            // успеваем скопировать код за 30 секунд
            Thread.Sleep(30000);
            // закрываем браузер после всех манипуляций
            driver.Quit();
        }
    }
}
