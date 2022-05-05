var people = new List<Person>
{
    new Person("Maria", 11789),
    new Person("Anna", 12345),
    new Person("Irina", 50888),
    new Person("Kateryna", 55555),
};

foreach (var p in people)
    Console.WriteLine($"{p.Name} - {p.Id}");

Console.WriteLine("\n\nsorting by name.");

var sortedPeople1 = from p in people orderby p.Name select p;

foreach (var p in sortedPeople1)
    Console.WriteLine($"{p.Name} - {p.Id}");

Console.WriteLine("\n\nsorting by id.");

var sortedPeople2 = from p in people orderby p.Id select p;

foreach (var p in sortedPeople2)
    Console.WriteLine($"{p.Name} - {p.Id}");




class Person 
{
    public string Name { get; set; }
    public int Id { get; set; }

    public Person(string name, int id)
    {
        Name = name;
        Id = id;
    }
}    