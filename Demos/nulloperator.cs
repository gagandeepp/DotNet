List<string> names = null;
List<string> safeNames = names ?? new List<string>(); // null coalescing operator
safeNames.Add("John");
Console.WriteLine(string.Join(", ", safeNames)); // Output: John

string name = null;
name ??= "Default Name"; // null assignment operator
Console.WriteLine(name); // Output: Default Name
