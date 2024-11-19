using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Files
{
    internal class Program
    {
        private static object Consol;

        static void Main(string[] args)
        {
            try {
                List<Teacher> teacheList = new List<Teacher>();
                Teacher teacher1 = new Teacher("זהבה", "התעמלות");
                teacher1.students.Add(new Student("רחל", "א2"));
                teacher1.students.Add(new Student("אסתר", "ג2"));
                Teacher teacher2 = new Teacher("רבקה", "מלאכה");
                teacher2.students.Add(new Student("לאה", "ח2"));
                teacher2.students.Add(new Student("יעלי", "ד1"));
                teacheList.Add(teacher1);
                teacheList.Add(teacher2);
                TextFiles.ToWriteTeachers(teacheList);
               // File.Copy("teachers.txt", @"H:\C# מתקדם\copy.txt");
                XDocument x =  XmlFile.ConvertFromObjToXml(teacheList);
                XmlFile.SaveXml(x);

            }



            catch (Exception ex) {
                Console.WriteLine(ex.ToString());
             }
        }
    }
}
