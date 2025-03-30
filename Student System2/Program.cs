// See https://aka.ms/new-console-template for more information
using Student_System2;

Console.WriteLine("########## Student Information ##########");

//List<Student> students = new List<Student>();

//รายชื่อนักเรียนที่มี
Student student1 = new Student("Inthira Rueangchatri", 21);
Student student2 = new Student("Mark Lee", 25);
Student student3 = new Student("Kim doyong",16);
Student student4 = new Student("Manta sea",15);

//แบบไม่รับค่าจากอินพุต
student1.Subjects.Add(new Subject("Math", 120));
student1.Subjects.Add(new Subject("Music", 76));
student1.Subjects.Add(new Subject("English", 95));
student1.Subjects.Add(new Subject("Computer", 75));
student1.showdata();
student1.showSubject();
student1.avgScoreSub();

student2.Subjects.Add(new Subject("Math", 65));
student2.Subjects.Add(new Subject("Music", 88));
student2.Subjects.Add(new Subject("English", 98));
student2.showdata();
student2.showSubject();
student2.avgScoreSub();

student3.Subjects.Add(new Subject("English",-88));
student3.Subjects.Add(new Subject("Math", 73));
student3.showdata();
student3.showSubject();
student3.avgScoreSub();

student4.Subjects.Add(new Subject("Math", 82));
student4.Subjects.Add(new Subject("Thai", 100));
student4.Subjects.Add(new Subject("Scient", 64));
student4.showdata();
student4.showSubject();
student4.avgScoreSub();

Console.ReadKey();