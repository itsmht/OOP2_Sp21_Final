using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_reg
{
    class Course
    {
        public static int StudentLimit = 30;
        private Student[] students;
        public string Id { set; get; }

        public string Name { set; get; }

        public int StudentCount { set; get; }

        public Course()
        {
            this.students = new Student[Course.StudentLimit];
        }

        public Course(string id, string name)
        {
            this.Id = id;
            this.Name = name;
            this.students = new Student[Course.StudentLimit];
        }



        public void AddStudent(params Student[] stdns)
        {
            foreach (Student s in stdns)
            {
                if (this.StudentCount < Course.StudentLimit && s.CourseCount < Student.CourseLimit)
                {
                    this.students[this.StudentCount++] = s;
                    if (s.GetCourse(this.Id) == null)
                        s.AddCourse(this);
                }
            }
        }

        public void RemoveStudent(Student s)
        {
            if (s == this.students[this.StudentCount - 1])
            {
                this.students[this.StudentCount--] = null;
                s.RemoveCourse(this);
                return;
            }
            bool notFound = true;
            for (int i = 0; i < this.StudentCount - 1; ++i)
            {
                if (s == this.students[i] && notFound)
                {
                    this.students[i] = null;
                    this.StudentCount--;
                    s.RemoveCourse(this);
                    notFound = false;
                }
                if (!notFound)
                    this.students[i] = this.students[i + 1];
            }
        }

        public Student GetStudent(string id)
        {
            for (int i = 0; i < this.StudentCount; ++i)
                if (id == this.students[i].Id)
                    return this.students[i];

            return null;
        }

        public void PrintStudent()
        {
            for (int i = 0; i < this.StudentCount; ++i)
            {
                this.students[i].ShowInfo();
            }
        }

        public void ShowCourseInfo()
        {
            Console.WriteLine("Course Name: {0}", this.Name);
            Console.WriteLine("Course ID: {0}", this.Id);
        }
    }
}
