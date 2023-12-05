using System;
namespace Even_handling
{
    public delegate void CreateHandler(Person p);

    public class Person
    {
        public string Name { get; set; } = "";
        public string Gender { get; set; } = "";
        public int Age { get; set; } = 0;

        public string Info => $"name:{Name},gender:{Gender},age:{Age}";

        public static event CreateHandler?Created;

        public static void Create(string n, string g, byte a)
        {
            Person p = new() { Name = n, Gender = g, Age = a };
            Created?.Invoke(p);
        }
    }

}