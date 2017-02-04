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
            Employee myObj;  
            XmlSerializer mySerializer = new XmlSerializer(typeof(Employee));  
            FileStream myFileStream = new FileStream("myFileName.xml", FileMode.Open);  
            myObj = (Employee)mySerializer.Deserialize(myFileStream);
            Console.WriteLine(myObj.Id+","+myObj.Name+","+myObj.Age);
        }

    }