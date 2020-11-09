using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Student
    {
        private string name;
        private string id;
        private string department;
        private float cgpa;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Department
        {
            get { return department; }
            set { department = value; }
        }
        public float Cgpa
        {
            get { return cgpa; }
            set { cgpa = value; }
        }

        public Student()
        {
            name = "MARIA AKTER KANTA";
            id = "19-40343-1";
            department = "CSE";
            cgpa = (float)3.39;

        }
        public Student(string name, string id, string department, float cgpa)
        {
            this.name = name;
            this.id = id;
            this.department = department;
            this.cgpa = cgpa;
        }
        public void showInfo()
        {
            Console.WriteLine("Student name is " + name);
            Console.WriteLine("Student id is " + id);
            Console.WriteLine("Student department is " + department);
            Console.WriteLine("Student cgpa is " + cgpa);

        }
    }
}
