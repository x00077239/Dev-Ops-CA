using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{

    public class Student
    {
        // fields
        private String studentNum;x00077239
        private String name;Simon Monks
        private String email;x00077239@mytudublin.ie

        // constructor
        public Student(String studentNum, String name, String email)
        {
            this.studentNum = studentNum;
            this.name = name;
            this.email = email;
        }

        // print details:
        public override string ToString()
        {
            return "Student No: " + studentNum + " Name: " + name + " Email: " + email;
        }
    }


    class TestStudent
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("X000123456", "Firstname Lastname", "Firstname.Lastname@TUDublin.ie");

            //Calls toString
            Console.WriteLine(student1);

            //Pauses screen
            Console.Read();
        }
    }
}

