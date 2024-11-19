using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Files
{
    internal class Teacher
    {
        private string name {  get; set; }
        private string subject { get; set; }
        public List<Student> students { get; set; }

        public string Name { get { return name; } set { name = value; } }
        public string Subject { get { return subject; } set { subject = value; } }
        public Teacher(string name,string sub) {
            students = new List<Student>();
            this.name=name;
            subject = sub;
        }

        internal void WriteLine(object value)
        {
            throw new NotImplementedException();
        }
        public void ToString()
        {
            Console.WriteLine("name : " +name+ "subject : "+ subject);
        }
    }
}
