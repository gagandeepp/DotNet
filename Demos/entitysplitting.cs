public class Person
{
    public int PersonId { get; set; }
    public string Name { get; set; }
    public DateTime DateOfBirth { get; set; }

    // Navigation Property for Address (optional, but included for demonstration)
    public Address Address { get; set; }
}

public class Address
{
    public int PersonId { get; set; }  // Foreign Key to Person
    public string Street { get; set; }
    public string City { get; set; }
    public string State { get; set; }
}

public class AppDbContext : DbContext
{
    public DbSet<Person> People { get; set; }
    public DbSet<Address> Addresses { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Entity Splitting Configuration
        modelBuilder.Entity<Person>()
            .ToTable("Persons")  // Table for basic Person information
            .Property(p => p.PersonId)
            .HasColumnName("PersonId");

        modelBuilder.Entity<Address>()
            .ToTable("Addresses")  // Table for Address information
            .HasKey(a => a.PersonId); // Address table uses PersonId as primary key

        modelBuilder.Entity<Address>()
            .HasOne(a => a.Person)
            .WithOne(p => p.Address)
            .HasForeignKey<Address>(a => a.PersonId);  // Foreign key to Person
    }
}

public class Program
{
    public static async Task Main(string[] args)
    {
        var options = new DbContextOptionsBuilder<AppDbContext>()
                        .UseSqlServer("your_connection_string")
                        .Options;

        using (var context = new AppDbContext(options))
        {
            // Add a new Person with Address
            var person = new Person
            {
                Name = "John",
                DateOfBirth = new DateTime(1990, 1, 1),
                Address = new Address
                {
                    Street = "123 Elm St",
                    City = "Springfield",
                    State = "IL"
                }
            };

            context.People.Add(person);
            await context.SaveChangesAsync();
        }
    }
}
