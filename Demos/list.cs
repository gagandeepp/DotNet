public class Student
{
	public int Id { get; set; }
	public string Name { get; set; }
}

public static void Main()
{
	List<Student> students = new List<Student>
	{
		new Student { Id = 1, Name = "Alice" },
		new Student { Id = 2, Name = "Bob" },
		new Student { Id = 3, Name = "Charlie" }
	};

	// Adding a new student
	students.Add(new Student { Id = 4, Name = "David" });

	// Removing a student
	students.RemoveAll(s => s.Name == "Alice");

	// Finding a student
	Student student = students.Find(s => s.Name == "Bob");
	Console.WriteLine($"Found student: {student.Name}");

	// Iterating through the list
	foreach (var s in students)
	{
		Console.WriteLine($"Student ID: {s.Id}, Name: {s.Name}");
	}
}
