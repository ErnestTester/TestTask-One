using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace WorkingList   
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<string> names = ["Ernesto", "Ana", "Felipe","Alice", "Bob", "Charlie", "David", "Eva",
            "Frank", "Grace", "Hannah", "Ian", "Jack", "Karen", "Liam", "Mona", "Nina", "Oscar"  ];
            foreach (string name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");


            }

            var index = names.IndexOf("Liam");
            if(index==-1)
            {
                Console.WriteLine($"When an item is not found, IndexOf returns {index}");
            }
            else
            {
                Console.WriteLine($"The name {names[index]} is at the index {index}");
                Console.WriteLine($"We find you! {names[index]}!");
            }

        }
    }
}
