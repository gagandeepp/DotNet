class CompareGenericClass<T>
{
    public bool Compare(T x, T y)
    {
        if (x.Equals(y))
            return true;
        else
            return false;
    }
}

class Program{
	static void Main(){
	CompareGenericClass<string> Ocompare = new CompareGenericClass<string>();
	bool stringResult=Ocompare.Compare("DEVESH", "DEVESH");
	 Console.WriteLine(stringResult);
	}
}