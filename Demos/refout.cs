public class Example
{
 public static void Main() //calling method
 {
 int val1 = 0; //must be initialized 
 int val2; //optional
 
 Example1(ref val1);
 Console.WriteLine(val1); // val1=1
 
 Example2(out val2);
 Console.WriteLine(val2); // val2=2
 }
 
 static void Example1(ref int value) //called method
 {
 value = 1;
 }
 static void Example2(out int value) //called method
 {
 value = 2; //must be initialized 
 }
}
 
/* Output
 1
 2
 */
 //passing variable by ref needs to be in first
 //Method should initialize a variable before returning in case of variable is pass using out key word.
// method overloading can be possible when one method takes a ref or out argument and the other takes the same argument without ref or out.

 