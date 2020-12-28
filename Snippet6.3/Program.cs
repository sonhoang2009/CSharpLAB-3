using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snippet6._3
{
    class Student
    {
        void printName(string firstName, string lastName)
        {
            Console.WriteLine("First Name ={0} , Last Name = {1} ", firstName, lastName);
            
        }
        static void Main(string[] args)
        {
            Student student = new Student();
            student.printName("Henry", "Parker");
            student.printName(firstName: "Henry", lastName: "Parker");
            student.printName(lastName: "Paker", firstName: "Henry");
            student.printName("Henry", lastName: "Parker");
            Console.ReadKey();
        }
    }
}
