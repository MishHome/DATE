using System;

namespace GetOldArePerson;
class Person
{
    public string Name { get; set; }
    public DateOnly DateOfBird { get; set; }
    public string City { get; set; }
    public string Telephone { get; set; }

    public static List<Person> GetPersons()
    {
        var p1 = new Person() { Name = "Jon", DateOfBird = new DateOnly(2000, 1, 1), City = "Moscow" };
        var p2 = new Person() { Name = "Time", DateOfBird = new DateOnly(1980, 12, 31), City = "Kostroma" };
        var p3 = new Person() { Name = "Micle", DateOfBird = new DateOnly(2011, 01, 31), City = "Moscow" };

        return new List<Person> { p1, p2, p3 };
    }

}

