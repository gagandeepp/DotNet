 class UserDefineException : Exception
    {
        public UserDefineException()
        {

        }
        public UserDefineException(string message)
            : base(message)
        {

        }

        public UserDefineException(string message,Exception inner )
            : base(message,inner)
        {

        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Inside try");
                throw new UserDefineException("USer Defined Exception");
            }
            catch (UserDefineException ex)
            {
                Console.WriteLine("Inside Catch");
                Console.WriteLine("Message:"+ex.Message);
                Console.WriteLine("StackTrace:"+ex.StackTrace);
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