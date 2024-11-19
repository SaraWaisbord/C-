using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson3
{
    public class Student
    {
        private int grade;
        private string name;
        public int Grade
        { get { return grade; } set { if (value > 0) grade = value; } }
        public string Name { get { return name; } set {if (value != null) name = value; } }
        public Student(String name,int grade) {
            this.name = name;   
            this.grade = grade;  
        }
        public void print()
        {
            Console.Write(name);
            Console.WriteLine(": "+ grade);

        }

    }
}
