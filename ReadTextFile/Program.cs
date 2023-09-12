using System;
using System.IO;
using System.Collections.Generic;

namespace ReadFileAndStoreInClass
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"..\..\people.txt";

            try {
                List<Person> people = new List<Person>();

                using (StreamReader sr = new StreamReader(filePath)) {

                    string line;
                    while ((line = sr.ReadLine()) != null) {
                        people.Add(CreatePersonFromLine(line));
                    }

                }

                foreach (var person in people) {
                    Console.WriteLine($"First Name: {person.FirstName}");
                    Console.WriteLine($"Last Name: {person.LastName}");
                    Console.WriteLine($"Website: {person.Website}");
                    Console.WriteLine();
                }
            }
            catch (Exception e) {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }

        static Person CreatePersonFromLine(string line)
        {
            string[] fields = line.Split(',');

            return new Person
            {
                FirstName = fields[0].Trim(),
                LastName = fields[1].Trim(),
                Website = fields[2].Trim()
            };
        }
    }
}
