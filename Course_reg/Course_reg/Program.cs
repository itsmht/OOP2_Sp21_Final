using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_reg
{
    class Program
    {
        static void Main(string[] args)
        {
            /********************** Student*********************/
            var s = new Student("1111", "Harry", 2.66F);
            var s1 = new Student("2222", "Bist", 3.89F);
            var s2 = new Student("2222", "Srest", 3.33F);
           
           


            /*********************** Course*********************/

            var c = new Course("C000", "Algorithms");
            var c1 = new Course("C111", "OOP2");
            var c2 = new Course("C222", "Compiler Design");


            /******************** Operation***********************/

            c.AddStudent(s, s1,s2);

            c.PrintStudent();

            c.RemoveStudent(s2);

            Console.WriteLine("\n=========  After Removing Student  ======\n");

            s2.PrintCourse();
            c.PrintStudent();

            s1.AddCourse(c, c1, c2);
            s1.PrintCourse();

            s2.RemoveCourse(c1);
            Console.WriteLine("\n=========  After Removing Course  ======\n");
            s1.PrintCourse();
            c1.PrintStudent();
        }
        }
    }

