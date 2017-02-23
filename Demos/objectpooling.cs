 class Factory
    {
        // Maximum objects allowed!
        private static int _PoolMaxSize = 2;
 
        // My Collection Pool
        private static readonly Queue objPool = new Queue(_PoolMaxSize);  
 
        public Employee GetEmployee()
        {
            Employee oEmployee;
 
            // check from the collection pool. If exists return object else create new
            if (Employee.Counter >= _PoolMaxSize && objPool.Count>0)
            {
                // Retrieve from pool
                oEmployee = RetrieveFromPool();
            }
            else
            {
                oEmployee = GetNewEmployee();
            }
            return oEmployee;
        }
 
        private Employee GetNewEmployee()
        {
            // Creates a new employee
            Employee oEmp = new Employee();
            objPool.Enqueue(oEmp);
            return oEmp;
        }
       
        protected Employee RetrieveFromPool()
        {
            Employee oEmp;
 
            // if there is any objects in my collection
            if (objPool.Count>0)
            {
                oEmp = (Employee)objPool.Dequeue();
                Employee.Counter--;
            }
            else
            {
                // return a new object
                oEmp = new Employee();
            }
            return oEmp;
        }
    }
 
    class Employee
    {
        public static int Counter = 0;
        public Employee()
        {
            ++Counter;
        }
 
        private string _Firstname;
        public string Firstname
        {
            get
            {
                return _Firstname;
            }
            set
            {
                _Firstname = value;
            }
        } 
    }