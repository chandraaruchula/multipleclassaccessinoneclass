using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void Study()
        {
            Console.WriteLine($"{Name} is studying.");
        }
    }


