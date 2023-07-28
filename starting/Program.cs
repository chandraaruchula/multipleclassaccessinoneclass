using System;
using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
        Application application = new Application();
        application.Kanna = new kanna() { Make = "hello", Model = "hi" };
        Console.WriteLine(application.Kanna.Make);
        }
    }


