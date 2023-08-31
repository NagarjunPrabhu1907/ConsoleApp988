using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp988
{
    internal class Program
    {
        public class dog
        {

            public string breed { get; set; }
            public string name { get; set; }

            public void bark()
            {
                Console.WriteLine("bark ");
            }
        }
        static void Main(string[] args)
        {
           dog bulldog = new dog();
            bulldog.breed = "lab";
            bulldog.name = "jimmy";
            Console.WriteLine(bulldog.breed);
            Console.WriteLine(bulldog.name);
            bulldog.bark();
            

        }
    }
}
