using System;
using System.Collections.Generic;
using System.Linq;

namespace Training
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person() { Id = "1", UserName = "Max"};
            person.Jokes.Add(1);
            var list  = person.Jokes.ToList();
            person.Jokes.Add(2);
            Console.WriteLine("This is a List");
            Console.WriteLine(list[0]);
            foreach (var joke in list)
            {
                Console.WriteLine(joke);
            }
            Console.WriteLine("End of list");
            Console.WriteLine("This is a ICollection");
            Console.WriteLine(person.Jokes.ElementAt(0));
            foreach (var joke in person.Jokes)
            {
                Console.WriteLine(joke);
            }
            Console.WriteLine("End of ICollection");
            person.Jokes = new int[2];
            Console.WriteLine(person.Jokes);

        }

        public static void GuessNunber()
        {
            int number = 0;
            var random = new Random();

            int guess = random.Next(0, 3);
            Console.WriteLine(guess);
            if (number == 10)
            {
                return;
            }
            number++;
            Console.ReadKey();
            GuessNunber();
        }
        public class Person
        {
            public string Id { get; set; }
            public string UserName { get; set; }
            public ICollection<int> Jokes { get; set; } = new List<int>();

        }

    }
}
