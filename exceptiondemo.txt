class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Inside try");
                throw new FileNotFoundException("File Cannot be found",@"c:\sample.txt");
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("Inside Catch");
                Console.WriteLine("Message:"+ex.Message);
                Console.WriteLine("StackTrace:"+ex.StackTrace);
                Console.WriteLine("FileName:"+ex.FileName);
                Console.WriteLine("Inner Exception:"+ex.InnerException);
                Console.WriteLine("Source:"+ex.Source);
                return;
            }
            finally
            {
               Console.WriteLine("Finally");
               //return; Compile time error control cannot leave the body of finally clause
               
            }
        }

    }