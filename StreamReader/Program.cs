using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamReaderHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader1 = new StreamReader("Shakespeare.txt");

            //Read the first line from the file only.
            using (reader1)
            {
                Console.Clear();
                Console.WriteLine("I.\n");
                Console.WriteLine(reader1.ReadLine());
                Console.WriteLine("\nPress any key to continue.");
                Console.ReadKey();
            }

            StreamReader reader2 = new StreamReader("Shakespeare.txt");

            //Read the entire text file.
            using (reader2)
            {
                Console.Clear();
                Console.WriteLine("II.\n");
                string line = reader2.ReadLine();
                while(line != null)
                {
                    Console.WriteLine(line);
                    line = reader2.ReadLine();
                }
                Console.WriteLine("\nPress any key to continue.");
                Console.ReadKey();
            }

            StreamReader reader3 = new StreamReader("Shakespeare.txt");

            //Read the entire text file and capitalize all lowercase vowels.
            using (reader3)
            {
                Console.Clear();
                Console.WriteLine("III.\n");
                string line = reader3.ReadLine();
                
                while (line != null)
                {
                    char[] letters = line.ToCharArray();
                    StringBuilder output = new StringBuilder();

                    //char last stores the previously evaluated character
                    //in the foreach to check for our rudimentary implementation
                    //of determining whether y is a vowel.
                    char last = ' ';
                    foreach (char c in letters)
                    {
                        if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
                        {
                            output.Append(Char.ToUpper(c));
                        }
                        else if (c == 'y' && last != ' ')
                        {
                            output.Append(Char.ToUpper(c));
                        }
                        else
                        {
                            output.Append(c);
                        }

                        last = c;
                    }
                    Console.WriteLine(output);
                    line = reader3.ReadLine();
                }
                Console.WriteLine("\nPress any key to continue.");
                Console.ReadKey();
            }
        }
    }
}
