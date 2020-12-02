using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee o1 = new Employee("Amol", 123465, 10);
            Console.WriteLine("all accepted");

            Employee o2 = new Employee("Amol", 123465);
            Console.WriteLine("dept");

            Employee o3 = new Employee("Amol");
            Console.WriteLine("dept and Basics");

            Employee o4 = new Employee();
            Console.WriteLine("none");

            Console.WriteLine(o1.EMPNO);
            Console.WriteLine(o2.EMPNO);
            Console.WriteLine(o3.EMPNO);

            Console.WriteLine(o3.EMPNO);
            Console.WriteLine(o2.EMPNO);
            Console.WriteLine(o1.EMPNO);

        }
    }

    class Employee
    {
        private string Name;
        public string NAME
        {
            set
            {
                if (value != null)
                    Name = value;
                else
                    Console.WriteLine("name should not be null");
            }
            get
            {
                return Name;
            }
        }

        private static int Empnoc = 0;
        private int EmpNo;
        public int EMPNO
        {
            get
            {
                return EmpNo;
            }
        }

        private decimal Basic;
        public decimal BASIC
        {
            set
            {
                if (value > 10000 && value < 10000000)
                    Basic = value;
                else
                    Console.WriteLine("out of range");
            }
            get
            {
                return Basic;
            }
        }


        private short deptno;
        public short DEPTNO
        {
            set
            {
                if (value > 0)
                    deptno = value;
                else
                    Console.WriteLine("Invali");
            }
            get
            {
                return deptno;
            }
        }

        public decimal GetNetSalary()
        {
            decimal salary;
            salary = Basic + Basic * 10;
            return salary;
        }

        public Employee(string Name = null, decimal Basic = 0, short deptno = 0)
        {
            Empnoc++;
            EmpNo = Empnoc;
            this.NAME = Name;
            this.BASIC = Basic;
            this.DEPTNO = deptno;
        }
    }
}

