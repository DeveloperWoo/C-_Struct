using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W2_1_Struct_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            //int @class = 1; Not recommend at all
            
            // Reference data type:
            Employee emp1 = new Employee();
            emp1.Name = "sandra";
            Employee emp2 = emp1;
            emp2.Name = "alex";
            Console.WriteLine(emp1.Name); // alex

            //int number;
            //Console.WriteLine(number); // not allowed in C#. We should initialize

            /* Nullable data types: */
            int? number = null; //wrapping variable. creating a class which has only one var, number in here
            if(number.HasValue)
                Console.WriteLine(number);

            /* Use a struct: Value Data type */
            Student student1; // We don't have to create an instance! (new statement) because a struct is a value data type not a reference type
            student1.Id = 101;
            student1.Name = "stacey";
            student1.Gpa = 75;
            student1.Status = StudentStatus.FullTime;
            Console.WriteLine(student1.Information()); //To use Information(), we have to initialize all the variables before. Otherwise, we'll get an error.

            Student student2 = new Student(1, "aaa", 90);
            Console.WriteLine(student2.ToString());

            Student student3 = student2;
            Console.WriteLine(student3.Name); // aaa
            student3.Name = "Hyunju";
            Console.WriteLine(student3.Name); //Hyunju
            Console.WriteLine(student2.Name); // aaa
            Console.WriteLine(student2.ToString());
            Console.WriteLine(student3.ToString());

            if (student2.Status == StudentStatus.PartTime)
            {

            }
        }
    }
}
