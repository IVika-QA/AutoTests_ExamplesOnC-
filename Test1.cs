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
