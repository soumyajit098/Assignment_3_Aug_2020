using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAnimal
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] MyArray = { "Zebra", "Ant", "Owl", "Lion" };
            string[] Animals = { "Zebra", "Kiwi", "Amazona Parrot", "Tiger" };
            string[] Places = { "Africa", "New Zealand", "Jamaica", "India" };

            for (int i = 0; i < MyArray.Length; i++)
            {
                Console.WriteLine(MyArray[i]);
            }

            Console.WriteLine("..................");

            foreach (string arr in MyArray)
            {
                Console.WriteLine(arr);
            }

            Console.WriteLine("..................");

            int animal = 0;
            while (animal < MyArray.Length)
            {
                Console.WriteLine(MyArray[animal]);
                animal++;
            }

            Console.WriteLine("..................");

            int ani = 0;
            do
            {
                Console.WriteLine(MyArray[ani]);
                ani++;
            }
            while (ani < MyArray.Length);

            Console.WriteLine("..................");

            Array.Sort(MyArray);
            foreach (string arr1 in MyArray)
            {
                Console.WriteLine(arr1);

            }
            Console.WriteLine("..................");
            Array.Sort(Animals);
            foreach (string ani1 in Animals)
            {
                Console.WriteLine(ani1);
            }
            Console.WriteLine("..................");
            Array.Sort(Places);
            foreach (string place in Places)
            {
                Console.WriteLine(place);
            }







            Console.Read();

        }
    }
}

