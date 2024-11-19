using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Files
{

    internal class TextFiles
    {

        public static void ToWriteTeachers(List<Teacher> listeacher)
        {
            using (StreamWriter sw = new StreamWriter("teachers.txt"))

                foreach (var line in listeacher)
                {
                    sw.WriteLine("שם:  " + line.Name + "  מקצוע: " + line.Subject + " , ");
                    sw.WriteLine( "תלמידות:");
                    foreach (var l in line.students)
                        sw.WriteLine(("שם:  " + l.Name + "  כיתה: " + l.Grade + " , "));
                }

        }
        public static void AddRowToFile()
        {
            using (StreamWriter sw = new StreamWriter("teachers.txt",append:true)) 
            sw.WriteLine();

        }


    }



 }

