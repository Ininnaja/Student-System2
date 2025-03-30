using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_System2
{
    internal class Subject
    {
        //field
        private string subjectName;
        private double grade;

        //property
        public string SubjectName { get => subjectName; set => subjectName = value; }
        public double Grade { get => grade; set => grade = value; }

        //consrtuctor
        public Subject(string subjectName,double grade)
        {
            this.SubjectName = subjectName;
            this.Grade = grade;
        }
    }
}
