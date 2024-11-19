using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson3
{
    public class StudentAdd
    {
        private int grade;
        private string name;
        private double age;
        public List<int> ScoreArry;
        public int Grade
        { get { return grade; } set { if (value > 0) grade = value; } }
        public string Name { get { return name; } set { if (value != null) name = value; } }
        public double Age { get { return age; } set { if (value > 0) age = value; } }
        public StudentAdd(String name, int grade, double age,List<int> l)
        {
            this.name = name;
            this.grade = grade;
            this.age = age;
            this.ScoreArry = l;
        }

    }
}
