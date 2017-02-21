[System.AttributeUsage(System.AttributeTargets.Class |  
                       System.AttributeTargets.Struct)  
]  
public class Author : System.Attribute  
{  
    private string name;  
    public double version;  
  
    public Author(string name)  
    {  
        this.name = name;  
        version = 1.0;  
    }  
}

//Code Usage
[Author("P. Ackerman", version = 1.1)]  
class SampleClass  
{  
    // P. Ackerman's code goes here...  
} 

//You can create your own custom attributes by defining an attribute class, a class that derives directly or 
//indirectly from Attribute, which makes identifying attribute definitions in metadata fast and easy.