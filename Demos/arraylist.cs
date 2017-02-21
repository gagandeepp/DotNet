class Program
{
    static void Main()
    {
        //
        // Create an ArrayList with 4 strings.
        //
        ArrayList list = new ArrayList();
        list.Add("fish");
        list.Add("amphibian");
        list.Add("bird");
        list.Add("plant");
        //
        // Get last two elements in ArrayList.
        //
        ArrayList range = list.GetRange(2, 2);
        //
        // Display the elements.
        //
        foreach (string value in range)
        {
            Console.WriteLine(value); // bird, plant
        }
    }
}