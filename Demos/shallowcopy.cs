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

     // Shallow copy using MemberwiseClone
     public Person ShallowCopy()
     {
         return (Person)this.MemberwiseClone();
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

         // Create a shallow copy of person1
         Person person2 = person1.ShallowCopy();

         // Modify the address of the copied object
         person2.Address.Street = "456 Elm St";

         // Print original and copied person info
         Console.WriteLine("Person 1 Address: " + person1.Address.Street);  // This will also change
         Console.WriteLine("Person 2 Address: " + person2.Address.Street);
     }
 }