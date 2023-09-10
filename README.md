### Примеры тестов на CSharp

## Пример 1:Тест API

# 1)Код теста на C#

```
using System;
using System.Net;

class Program
{
    static void Main()
    {
        WebClient client = new WebClient();
        try
        {
            string response = client.DownloadString("http://www.google.com");
            Console.WriteLine("Web-страница доступна");
        }
        catch (WebException ex)
        {
            Console.WriteLine("Web-страница недоступна");
        }
    }
}
```
# 2)Чтобы выполнить код нужно в контейнере выполнить команду:
```
docker run <имя_образа> dotnet test <путь_к_тестам>
```
где <имя_образа> - имя вашего образа Docker, <путь_к_тестам> - путь к директории или файлу с тестами внутри контейнера.

:white_check_mark: Результат:Команда dotnet test выполнит тесты на C# внутри контейнера. Результаты тестирования будут отображены в выводе команды.

## Пример 2:Тест WEB-страницы

# 1)Код теста на C#

```
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
```
# 2)Чтобы выполнить тест - смотри пункт 2 из предыдущего примера (Тест 1)
