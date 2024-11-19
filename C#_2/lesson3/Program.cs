using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<StudentAdd> list2 = new List<StudentAdd>();
            List<int> g1=new List<int>();
            g1.Add(90);g1.Add(100);g1.Add(92);
            list2.Add(new StudentAdd("Lea", 97, 12.5,g1));
            List<int> g2 = new List<int>();
            g2.Add(60); g2.Add(10); g2.Add(52);
            list2.Add(new StudentAdd("Rachel", 95,12.3,g2));
            List<int> g3 = new List<int>();
            g3.Add(70); g3.Add(10); g3.Add(50);
            list2.Add(new StudentAdd("Rivka", 100,25,g3));
            var newList2 = list2.Where(n23 => n23.IsPassing()).Select(n23 => new {name = n23.Name,avg = n23.GetAverageGrade()}).ToList();
            foreach (var student in newList2)
            {
                Console.WriteLine("name: "+student.name+ " avrage: "+ student.avg);     
            }

            File.Copy("teachers.txt", @"H:\C# מתקדם\copy.txt");




        }
    }
}
