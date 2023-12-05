using Even_handling;
using System;

public class PersonList
{
    private List<Even_handling.Person> _pers = new();

    public PersonList()
    {
        Even_handling.Person.Created += p => _pers.Add(p);
    }

    public List<Person> People => _pers;

    public List<string> Genders => _pers.Select(p => p.Gender).Distinct().ToList();

    public void GenderGroupView()
    {
        Genders.ForEach(g =>
        {
            Console.WriteLine($"[{g}]");
            _pers.Where(p => p.Gender == g).ToList().ForEach(e => Console.WriteLine($"name:{e.Name},age:{e.Age}"));
            Console.WriteLine();
        });
    }
}