class Sample<T>
    {
        T[] arr = new T[100];
        public T this[int index]{
            get{
                return arr[index];
            }
            set{
                arr[index]=value;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Sample<string> obj=new Sample<string>();
            obj[0] = "dsfdf";
            Console.WriteLine(obj[0]);

        }

    }
