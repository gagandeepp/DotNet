 public class Employee
    {
        public int Id;
        public string Name;
        public int Age;
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Employee myObject = new Employee();
            myObject.Id = 1;
            myObject.Name = "gagan";
            myObject.Age = 28;
            XmlSerializer mySerializer = new XmlSerializer(typeof(Employee));
            StreamWriter myWriter = new StreamWriter("myFileName.xml");
            mySerializer.Serialize(myWriter, myObject);
            myWriter.Close(); 
        }

    }