using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_System2
{
    internal class Student
    {
        //field
        private string name;
        private int age;
        private List<Subject> subjects;

        //constructor
        public Student(string name,int age)
        {
            this.Name = name;
            this.Age = age;
            this.Subjects = new List<Subject>();
        }

        //property
        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        internal List<Subject> Subjects { get => subjects; set => subjects = value; }

        //method
        public void showdata()
        {
            Console.WriteLine("Student name : " + Name + " age : " + Age);
        }

        int e;
        public void showSubject()
        {
            Console.WriteLine("Subjects in the list:");
            foreach (var i in subjects)
            {
                if (i.Grade < 0 || i.Grade > 100)
                {
                    Console.WriteLine("Subject: " + i.SubjectName + " Grade not between 0-100");
                    e = 1;
                }
                else
                {
                    
                    Console.WriteLine("subject name : " + i.SubjectName + " Grade : " + i.Grade);
                }
                
            }
        }

        //method คำนวณคะแนนเฉลี่ยของนักเรียนจากหลายวิชา
        public void avgScoreSub()
        {
            if (Subjects.Count != 0)
            {
                if (e == 1)
                {
                    Console.WriteLine("The average score could not be found because the scores were less than 0 and more than 100.");
                }
                else
                {
                    double avgScore = Subjects.Average(x => x.Grade);
                    Console.WriteLine("Your average scores = " + avgScore);
                }
                
            }
            else
            {
                Console.WriteLine("Nor found Information");
            }
            Console.WriteLine();
        }
    }
}
