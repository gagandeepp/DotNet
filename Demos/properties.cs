public class Books
{
    //readonly property can be assigned value during initialization , inside constructor and static construcotr
    private readonly string _ISBN = "";
    // init is used when we want to initialize the property and then make it readonly
    public int Price // c# 9
    {
        get;
        init;
    }
    public Books()
    {
        _ISBN = "qwertyuio";
    }
    public required string LastName // C# 11
    {
        get;
        set;
    }



}