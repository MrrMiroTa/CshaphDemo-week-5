using System;

namespace Even_handling
{
    class Program
    {
        static void Main()
        {
            PersonList lst = new();
            Person.Create("Uzita", "Male", 28);
            Person.Create("Uzita MakaMorI", "Male", 29);

            Console.WriteLine($"Genders: {string.Join(", ", lst.Genders)}");
            lst.GenderGroupView();

            Console.WriteLine("\nPeople in ascending order of name:");
            lst.People.OrderBy(p => p.Name).ToList().ForEach(p => Console.WriteLine(p.Info));
        }
    }
}