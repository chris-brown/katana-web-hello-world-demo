
using System;
using Microsoft.Owin.Hosting;

namespace OWINExample.Host
{
    public class Program
    {
      public static void Main(string[] args)
      {
        using (WebApp.Start<Startup>("http://localhost:1234"))
        {
          Console.WriteLine("Listening on port: 1234");
          Console.ReadLine();
        }
      }
    }
}
