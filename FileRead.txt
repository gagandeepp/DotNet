class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream(@"D:\mymails\prep\sample\sample\demo.txt", FileMode.Open);
            try
            {
                StreamReader sr = new StreamReader(fs);
                Console.WriteLine(sr.ReadLine());
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (fs != null)
                {
                    fs.Close();
                }
            }
        }

    }