using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza
{
    class Program
    {
        static void Main(string[] args)
        {
            // ketchup
            // sausage

            var pizza = new Pizza();
            pizza.Ingredients.Add("ketchup");
            pizza.Ingredients.Add("sausage");

            //Let's think these comments are needed as an 'foreach' option)!!!!!!!
            //foreach(string i in pizza.Ingredients)
            //Console.WriteLine(i);

            for (int i = 0; i < pizza.Ingredients.Count; i++)
            {
                Console.WriteLine("Added ingredients: {0}", pizza.Ingredients[i]);
            }

           

            Console.ReadLine();
        }

        class Pizza
        {
            public List<string> Ingredients { get; set; } = new List<string>();
        }

    }
}
