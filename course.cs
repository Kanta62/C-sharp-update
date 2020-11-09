using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Course obj = new Course();
            Console.WriteLine("Enter your course name: ");
            obj.CourseName = Console.ReadLine();
            Console.WriteLine("Enter your course code: ");
            obj.CourseCode = Console.ReadLine();
            Console.WriteLine("Enter your course credit: ");
            obj.CourseCredit = Convert.ToInt32(Console.ReadLine());

            obj.ShowCourseInfo();
        }
    }

    public class Course
    {
        private string courseName;
        private string courseCode;
        private int courseCredit;
        public string CourseName
        {
            get { return courseName; }
            set { courseName = value; }

        }
        public string CourseCode
        {
            get { return courseCode; }
            set { courseCode = value; }

        }
        public int CourseCredit
        {
            get { return courseCredit; }
            set { courseCredit = value; }

        }

        public void ShowCourseInfo()
        {
            Console.WriteLine("My course name is " + courseName);
            Console.WriteLine("My course code is " + courseCode);
            Console.WriteLine("My course credit is " + courseCredit);

        }
    }




}

