using System;

namespace Student
{
    class Program
    {
        static void Main(string[] args)
        {
            Student obj = new Student();
            obj.Name = "Kanta Maria Akter";
            obj.Id = "19-40343-1";
            obj.Department = "CSE";

            Console.WriteLine("My name is : " + obj.Name);
            Console.WriteLine("My id is : " + obj.Id);

            Console.WriteLine("My department is : " + obj.Department);

        }
    }

    public class Student
    {
        private string name;
        private string id;
        private string department;

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


    }
}
