using System;
using System.Collections.Generic;
using People;

namespace DotnetConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<IPerson> people = new List<IPerson>
            {
                new Person()
            };

            foreach (var person in people)
            {
                System.Console.WriteLine(person.TalkToPerson());
            }
        }

    }
}
