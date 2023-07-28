using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class sai
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void Bark()
        {
            Console.WriteLine($"{Name} is barking.");
        }
    }
