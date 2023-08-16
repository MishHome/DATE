namespace GetOldArePerson;
class Program
{
    public static void Main()
    {
        var listPersons = new List<Person>();
        //var listPersons = Person.GetPersons();

        Console.WriteLine("Name");
        var name = Console.ReadLine();
        Console.WriteLine("DateOfBird yy-MM-dd");
        var dateOfBird = Console.ReadLine();
        Console.WriteLine("City");
        var city = Console.ReadLine();

        Person person1= new Person();
        person1.Name = name;
        person1.City = city;
        person1.DateOfBird = DateOnly.ParseExact(dateOfBird,"yy-MM-dd");
        
        listPersons.Add(person1);

        foreach (var person in listPersons)
        {
            var OldArePerson = GetOldArePerson(person.DateOfBird);

            Console.WriteLine($"Name: {person.Name}\nDateOfBird: {person.DateOfBird}\nOldArePerson: {OldArePerson}");
            Console.WriteLine("---");
        }
        Console.ReadLine();
    }

    static int? GetOldArePerson(DateOnly dateOfBird)
    {
        var DateToday = DateOnly.FromDateTime(DateTime.Now);
        if (dateOfBird > DateToday)
        {
            Console.WriteLine($"дата рождения не может быть больше сегоднешней даты");
            return null;
        }
        else
        {
            var fullYear = DateToday.Year - dateOfBird.Year;

            if (DateToday.Month < dateOfBird.Month)
                fullYear--;
            else if
                (DateToday.Month == dateOfBird.Month && DateToday.Day < dateOfBird.Day)
                fullYear--;

            return fullYear;
        }
    }
}



