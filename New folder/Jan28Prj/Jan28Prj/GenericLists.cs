using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jan28Prj
{

    class Employee
    {
        int Eid;
        string Ename;
        string Compname;
        float Salary;

        public Employee(int id,string ename,string cname,float sal)
        {
            Eid = id;
            Ename = ename;
            Compname = cname;
            Salary = sal;
        }
        public override string ToString()
        {
            return $"EMployeeid: { Eid} with name: { Ename} works with:{Compname} and earns{ Salary}";
           //return string.Format("Empid: " + " " +Eid+ "Empname:" + " " +Ename);
        }
    }
    class GenericLists
    {
        static void Main()
        {
            List<Employee> emplist = new List<Employee>();
            emplist.Add(new Employee(101, "Nikitha", "Zensar", 10000));
            emplist.Add(new Employee(102, "Nikitha", "Zensar", 12000));
            emplist.Add(new Employee(103, "Nikitha", "Zensar", 13000));

            foreach(Employee e in emplist)
            {
                // Console.Read($"Employee id{e.Eid} with Employee Name{e.Ename} worksh with{e.Compname);
                Console.WriteLine(e.ToString());
            }
            Console.Read();
        }
       

          
    }
}
