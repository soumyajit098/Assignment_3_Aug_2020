using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringConcepts
{
    class Program
    {
        void Display()
        {
            Console.WriteLine("1. Concatenate Strings. ");
            Console.WriteLine("2. Length of two strings. ");
            Console.WriteLine("3. Substring ");
            Console.WriteLine("4. Replace. ");
            Console.WriteLine("5. Uppercase.");
            Console.WriteLine("6. Lowercase.");
            Console.WriteLine("7. Trim. ");
            Console.WriteLine("8. Split. ");
            Console.WriteLine("Make the choise again and Enter 9 to exit");
        }
        static void Main()
        {
            Console.WriteLine("Enter the first string  ");
            string str1 = Console.ReadLine();

            Console.WriteLine("Enter the second string  ");
            string str2 = Console.ReadLine();

            Console.WriteLine("-----------------------");

            Console.WriteLine("String 1 is: {0}", str1);
            Console.WriteLine("String 2 is: {0}", str2);
            string str;



            Program obj = new Program();

            checkpoint: Console.WriteLine();
            Console.WriteLine("============================================");
            obj.Display();


            char ch;
            Console.WriteLine("Enter your choice ");
            ch = Convert.ToChar(Console.ReadLine());

            switch (ch)
            {
                case '1':
                    str = String.Concat(str1, str2);
                    Console.WriteLine("Concatenated string is: {0}", str);
                    goto checkpoint;
                
                case '2':
                    Console.WriteLine("Length of the frist string is : " + str1.Length);
                    Console.WriteLine("Length of the second string is : " + str2.Length);
                    goto checkpoint;
                
                case '3':
                    Console.WriteLine("Substring of string 1 " + str1.Substring(2));
                    Console.WriteLine("Substring of string 2 " + str2.Substring(4));
                    goto checkpoint;

                
                case '4':
                    Console.WriteLine(str1 = str1.Replace('a', 'b'));
                    Console.WriteLine(str2 = str2.Replace('c', 'd'));
                    goto checkpoint;
                
                case '5':
                    Console.WriteLine(str1 = str1.ToUpper());
                    Console.WriteLine(str2 = str2.ToUpper());
                    goto checkpoint;
                

                case '6':
                    Console.WriteLine(str1 = str1.ToLower());
                    Console.WriteLine(str2 = str2.ToLower());
                    goto checkpoint;
                
                case '7':
                    char[] arrA = { 'J', 'a' };
                    Console.WriteLine("String = " + str1);
                    Console.WriteLine("String (after trim) = " + str1.Trim(arrA));

                    char[] arrB = { 'F', 'a' };
                    Console.WriteLine("String = " + str2);
                    Console.WriteLine("String (after trim) = " + str2.Trim(arrB));
                    goto checkpoint;
                
                case '8':
                    char[] separator = { ':', ' ' };
                    string[] words = str1.Split(separator);
                    foreach (string word in words)
                    {
                        Console.WriteLine(word);
                    }

                    char[] separator1 = { ';', ' ' };
                    string[] words1 = str2.Split(separator);
                    foreach (string word in words1)
                    {
                        Console.WriteLine(word);
                    }
                    goto checkpoint;
                
                case '9':

                    break;
                default:
                    Console.WriteLine("Choose the correct option");
                    break;
                    
            }
        }
    }
}




















