class Program
{
    static Hashtable GetHashtable()
    {
        Hashtable hashtable = new Hashtable();

        hashtable.Add(300, "Carrot");
        hashtable.Add("Area", 1000);
        return hashtable;
    }

    static void Main()
    {
        Hashtable hashtable = GetHashtable();

        string value1 = (string)hashtable[300];
        Console.WriteLine(value1);

        int value2 = (int)hashtable["Area"];
        Console.WriteLine(value2);
    }
}
