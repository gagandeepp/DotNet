using System;

class Person
{
    public string Name { get; set; }
    public Address Address { get; set; }

    // Constructor
    public Person(string name, Address address)
    {
        Name = name;
        Address = address;
    }

    // Deep copy method
    public Person DeepCopy()
    {
        // Create a new instance of Person and Address
        Person copy = (Person)this.MemberwiseClone();
        copy.Address = new Address { Street = this.Address.Street, City = this.Address.City };
        return copy;
    }
}

class Address
{
    public string Street { get; set; }
    public string City { get; set; }
}

class Program
{
    static void Main()
    {
        Address address = new Address { Street = "123 Main St", City = "New York" };
        Person person1 = new Person("John", address);

        // Create a deep copy of person1
        Person person2 = person1.DeepCopy();

        // Modify the address of the copied object
        person2.Address.Street = "456 Elm St";

        // Print original and copied person info
        Console.WriteLine("Person 1 Address: " + person1.Address.Street);  // This will not change
        Console.WriteLine("Person 2 Address: " + person2.Address.Street);
    }
}
