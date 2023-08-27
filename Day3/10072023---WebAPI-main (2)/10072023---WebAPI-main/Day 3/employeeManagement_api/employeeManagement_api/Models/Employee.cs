namespace employeeManagement_api.Models
{
    public class Employee
    {



        #region Properties
        public int EmpNo { get; set; }

        public string EmpName { get; set; }

        public double EmpSalary { get; set; }

        public string EmpDesignation { get; set; }

        public bool EmpIsPermenant { get; set; }

        #endregion

        #region Data

        private static int emp_autoNo = 0;

        public Employee()
        {
            emp_autoNo = emp_autoNo + 1;
            this.EmpNo = emp_autoNo;
        }

        private static List<Employee> eList = new List<Employee>()
            {
                new Employee(){ EmpName="Karan", EmpDesignation="Sales", EmpIsPermenant=true, EmpSalary=2000},
                new Employee(){ EmpName="Mohan", EmpDesignation="Accounts", EmpIsPermenant=true, EmpSalary=1000},
                new Employee(){ EmpName="Rohan", EmpDesignation="Sales", EmpIsPermenant=false, EmpSalary=12000},
                new Employee(){ EmpName="Kiran", EmpDesignation="Sales", EmpIsPermenant=true, EmpSalary=22000},
                new Employee(){ EmpName="Kriti", EmpDesignation="Accounts", EmpIsPermenant=true, EmpSalary=15000},
                new Employee(){ EmpName="Mahesh", EmpDesignation="Sales", EmpIsPermenant=false, EmpSalary=18000},
            };
        #endregion

        #region Methods
       
        #region Get Methods
        public List<Employee> GetAllEmployees()
        {
            return eList;
        }
        public Employee GetEmployeeById(int id)
        {
            var emp = eList.Find(e => e.EmpNo == id);
            if (emp!=null)
            {
                return emp;
            }
            throw new Exception("Employee Not Found");
        }
        public List<Employee> GetPermenantEmployee(bool state)
        {
            var emps = eList.FindAll(e => e.EmpIsPermenant == state);
            return emps;
        }
        public int GetTotalEmployees()
        {
            var total = eList.Count;
            return total;
        }
        #endregion

        #region Add, update and delete
        public string AddEmployee(Employee newEmpObj)
        {
            eList.Add(newEmpObj);
            return "Employee Added to list, new Employee number is : " + newEmpObj.EmpNo;
        }

        public string UpdateEmployee(int id, Employee empObj)
        {
            var emp = eList.Find(e => e.EmpNo == id);

            if (emp != null)
            {
                emp.EmpName = empObj.EmpName;
                emp.EmpDesignation = empObj.EmpDesignation;
                emp.EmpSalary = empObj.EmpSalary;
                emp.EmpIsPermenant = emp.EmpIsPermenant;

                return "Employee Updated";
            }
            return "Employee not Found, update failed";
        }
        public string DeleteEmployee(int id)
        {
            var emp = eList.Find(e => e.EmpNo == id);
            if(emp != null)
            {
                eList.Remove(emp);
                return "Employee Deleted";
            }
            throw new Exception("Employee Not Found");
            
        }
        #endregion


        #endregion

    }
}
