using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSVHelper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string targetPath = @"C:\Users\icewi\OneDrive\桌面\CSVFiles\test\student.csv";
            List<Student> students = new List<Student> 
            {
                 new Student
                {
                    Name = "John",
                    Id = "01",
                    Grade = "100",
                },

                new Student
                {
                    Name = "Ruby",
                    Id = "02",
                    Grade = "99",
                },
                new Student
                {
                    Name = "Candy",
                    Id = "03",
                    Grade = "98",
                },
            };
        }
    }
}
