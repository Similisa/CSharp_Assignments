using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feb1Prj
{   
    class Function_Arguments
    {
        //default Parameter
        public static void Studetails(string fname, string lname, int age = 20, string Branch = "CSE")
        {
            Console.WriteLine($"FirstName: {fname}");
            Console.WriteLine($"LastName: {lname}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Stream: {Branch}");
        }
        //named Parameter
        public static void Stud_dtls(string fname, string lname, int age = 20, string Branch = "CSE")
        {
            Console.WriteLine($"{fname},{lname},{age},{Branch}");
        }
        static void Main()
        {
            Studetails("Gulshan", "Kumar");
            Studetails("Menka", "Gandhi",56);
            Studetails("Rohan", "Joshi",45,"IT");
            //Calling function with  named parameter
            Stud_dtls(age: 35, fname: "Raj", lname: "bahdur", Branch: "CSE");
            Console.Read();
        }
    }
}
