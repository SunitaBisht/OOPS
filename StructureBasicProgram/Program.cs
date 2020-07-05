using System;

namespace StructureBasicProgram
{
    class Program
    {
        public struct Employee
        {
            public int EmpId;
            public string EmpName;
            public string Department;
            public decimal Salary;
          
        };

        static void Main(string[] args)
        {
            Employee Emp;
            Emp.EmpId = 010;
            Emp.EmpName = "Sunita";
            Emp.Department = "Developer";
            Emp.Salary=27000;

            Console.WriteLine("The Employee Id is:" + Emp.EmpId +
                              "\n Employee Name is:" + Emp.EmpName +
                              "\n Department is:" + Emp.Department +
                              "\n and " + Emp.EmpName + " Salary is: " + Emp.Salary );

            Console.ReadKey();

        }
    }
}
