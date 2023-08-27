namespace EmployeeManagemnt_API_Day3.Models
{
    #region -- Employee
    public class Employee
    {
        public int EmpNo { get; set; }
        public string EmpName { get; set; }
        public double EmpSalary { get; set; }
        public string EmpDesignation { get; set; }
        public bool EmpIsPermanent { get; set; }


        #region - Data

        private static List<Employee> eList = new List<Employee>() {

        new Employee(){EmpNo = 101,EmpName="Fahad" , EmpDesignation= "Sales", EmpIsPermanent=true, EmpSalary=2000 },
        new Employee(){EmpNo = 102,EmpName="Mohan" , EmpDesignation= "Account", EmpIsPermanent=false, EmpSalary=2900 },
        new Employee(){EmpNo = 103,EmpName="Suraj" , EmpDesignation= "Sales", EmpIsPermanent=true, EmpSalary=9900 },
        new Employee(){EmpNo = 104,EmpName="Chandan" , EmpDesignation= "Account", EmpIsPermanent=false, EmpSalary=8800 },
        new Employee(){EmpNo = 105,EmpName="Mohan" , EmpDesignation= "Sales", EmpIsPermanent=true, EmpSalary=1000 },
        new Employee(){EmpNo = 106,EmpName="Avinash" , EmpDesignation= "Account", EmpIsPermanent=false, EmpSalary=2870 }
        };

        #endregion

        #region Methods
        public List<Employee> GetAllEmployees()
        {
            return eList;
        }

        #endregion

    }

    #endregion



}
