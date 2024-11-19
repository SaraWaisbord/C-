using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Files
{
    internal class Student
    {
        private string name {  get; set; }
        private string grade { get; set; }
        public string Name { get { return name; } set { name = value; } }
        public string Grade { get {  return grade; } set {  grade = value; } }
        public Student(string name,string grade) {
            this.name = name;
            this.grade = grade ;
        }
        public void ToString()
        {
            Console.WriteLine("name : " + name + "grade : " + grade);
        }
    }
}
