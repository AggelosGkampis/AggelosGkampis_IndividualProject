using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AggelosGkampis_Individual_part_a.Course;

namespace AggelosGkampis_Individual_part_a
{
    class Database
    {

        public List<Course> Courses { get; set; } = new List<Course>();
        public List<Trainer> Trainers { get; set; } = new List<Trainer>();
        public List<Student> Students { get; set; } = new List<Student>();
        public List<Assignment> Assignments { get; set; } = new List<Assignment>();
   
       

        public Database()
        {
            #region Seeding Courses
            
            Course c1 = new Course("C#", "CB16", TypeOfCourse.FullTime, new DateTime(2022, 2, 25), new DateTime(2022, 5, 25));
            Course c2 = new Course("C#", "CB16", TypeOfCourse.PartTime, new DateTime(2022, 2, 25), new DateTime(2022, 8, 25));
            Course c3 = new Course("Java", "CB15", TypeOfCourse.FullTime, new DateTime(2022, 2, 25), new DateTime(2022, 5, 25));
            Course c4 = new Course("Java", "CB15", TypeOfCourse.PartTime, new DateTime(2022, 2, 25), new DateTime(2022, 8, 25));
            Course c5 = new Course("Python", "CB14", TypeOfCourse.FullTime, new DateTime(2022, 2, 25), new DateTime(2022, 5, 25));
            Course c6 = new Course("Python", "CB14", TypeOfCourse.PartTime, new DateTime(2022, 2, 25), new DateTime(2022, 8, 25));
            Course c7 = new Course("JavaScript", "CB13", TypeOfCourse.FullTime, new DateTime(2022, 2, 25), new DateTime(2022, 5, 25));
            Course c8 = new Course("JavaScript", "CB13", TypeOfCourse.PartTime, new DateTime(2022, 2, 25), new DateTime(2022, 8, 25));
            Course c9 = new Course("C++", "CB12", TypeOfCourse.FullTime, new DateTime(2022, 2, 25), new DateTime(2022, 5, 25));
            Course c10 = new Course("C++", "CB12", TypeOfCourse.PartTime, new DateTime(2022, 2, 25), new DateTime(2022, 8, 25));


            Courses = new List<Course>() { c1, c2, c3, c4, c5, c6, c7, c8, c9, c10 };
            #endregion
            #region Seeding Students
        
            Student s1 = new Student("AM13555", "Aggelos", "Gkampis", new DateTime(1994, 9, 16), 10000);
            Student s2 = new Student("AM13432", "Orestis", "Kefis", new DateTime(1995, 1, 22), 90000);
            Student s3 = new Student("AM15344", "Kyriakos", "Pasxalidis", new DateTime(1998, 3, 1), 11000);
            Student s4 = new Student("AM16985", "Spyros", "Tomaras", new DateTime(1999, 4, 1), 10000);
            Student s5 = new Student("AM11122", "Panagiotis", "Chnarakis", new DateTime(1991, 6, 6), 10000);
            Student s6 = new Student("AM19658", "Takis", "Takoglou", new DateTime(1996, 1, 30), 10500);
            Student s7 = new Student("AM13745", "Makis", "Makopoulos", new DateTime(1999, 2, 27), 10500);
            Student s8 = new Student("AM16984", "Sakhs", "Akhs", new DateTime(2000, 10, 12), 9500);
            Student s9 = new Student("AM14356", "Dimitrios", "Dimitropoulos", new DateTime(1995, 9, 3), 8000);
            Student s10 = new Student("AM19943", "Dionisys", "Georgiou", new DateTime(1993, 12, 8), 10500);
            Student s11= new Student("AM18822", "Kwstas", "Tziolos", new DateTime(1993, 11, 10), 12000);
            Student s12 = new Student("AM10099", "Eleutherios", "Petrounias", new DateTime(1998, 2, 25), 9000);
            Student s13 = new Student("AM13992", "Mitsos", "Takis", new DateTime(1997, 1, 21), 9000);
            Student s14 = new Student("AM24232", "Maria", "Dimitriou", new DateTime(2001, 4, 23), 8000);
            Student s15 = new Student("AM22555", "Elena", "Pasxalidi", new DateTime(1989, 6, 24), 11000);
            Student s16 = new Student("AM36954", "Giannis", "Fontas", new DateTime(1994, 12, 29), 12000);
            Student s17 = new Student("AM36431", "Danai", "Eleutheriou", new DateTime(1991, 3, 26), 8500);
            Student s18 = new Student("AM66921", "Elena", "Panagiotou", new DateTime(1998, 5, 18), 7500);
            Student s19 = new Student("AM98733", "Myrsini", "Kriaraki", new DateTime(1996, 5, 17), 10500);
            Student s20 = new Student("AM47553", "Mariza", "Maglara", new DateTime(2000, 10, 7), 10000);

            // Connecting Courses with Students
            s1.Courses = new List<Course>() { c2, c5, c10 };
            c2.Students.Add(s1);
            c5.Students.Add(s1);
            c10.Students.Add(s1);
            s2.Courses = new List<Course>() { c1, c8, c2 };
            c1.Students.Add(s2);
            c2.Students.Add(s2);
            c8.Students.Add(s2);
            s3.Courses = new List<Course>() { c2, c4,};
            c2.Students.Add(s3);
            c4.Students.Add(s3);
            s4.Courses = new List<Course>() { c9};
            c9.Students.Add(s4);
            s5.Courses = new List<Course>() { c3, c6};
            c3.Students.Add(s5);
            c6.Students.Add(s5);
            s6.Courses = new List<Course>() { c1};
            c1.Students.Add(s6);
            s7.Courses = new List<Course>() { c9, c10};
            c9.Students.Add(s7);
            c10.Students.Add(s7);
            s8.Courses = new List<Course>() { c6};
            c6.Students.Add(s8);
            s9.Courses = new List<Course>() { c2};
            c2.Students.Add(s9);
            s10.Courses = new List<Course>() { c4};
            c4.Students.Add(s10);
            s11.Courses = new List<Course>() { c1};
            c1.Students.Add(s11);
            s12.Courses = new List<Course>() { c9};
            c9.Students.Add(s12);
            s13.Courses = new List<Course>() { c3};
            c3.Students.Add(s13);
            s14.Courses = new List<Course>() { c7};
            c7.Students.Add(s14);
            s15.Courses = new List<Course>() { c6, c8};
            c6.Students.Add(s15);
            c8.Students.Add(s15);
            s16.Courses = new List<Course>() { c1 , c2};
            c1.Students.Add(s16);
            c2.Students.Add(s16);
            s17.Courses = new List<Course>() { c6};
            c9.Students.Add(s4);
            s18.Courses = new List<Course>() { c10};
            c10.Students.Add(s18);
            s19.Courses = new List<Course>() { c4 };
            c4.Students.Add(s19);
            s20.Courses = new List<Course>() { c7};
            c7.Students.Add(s20);
            Students = new List<Student>() { s1, s2, s3, s4, s5, s6, s7, s8, s9, s10, s11, s12, s13, s14, s15, s16, s17, s18, s19, s20 };

           
            
            #endregion
            #region Seeding Trainers
          
            Trainer t1 = new Trainer("AM80020", "Fotis", "Fatsouletos", "BackEnd");
            Trainer t2 = new Trainer("AM90020", "Kwstas", "Fwtoulas", "FullStack");
            Trainer t3 = new Trainer("AM10020", "Sakis", "Papaxristos", "FullStack");
            Trainer t4 = new Trainer("AM20020", "Dimitra", "Jimakou", "FullStack");
            Trainer t5 = new Trainer("AM30020", "Giota", "Meliou", "Database,BackEnd");
            Trainer t6 = new Trainer("AM40020", "Periklis", "Aidinopoulos", "Database");
            Trainer t7 = new Trainer("AM50020", "Alexis", "Pidarinos", "FrontEnd");
            Trainer t8 = new Trainer("AM60020", "Ektoras", "Gatsos", "FullStack");
            Trainer t9 = new Trainer("AM70020", "Aggeliki", "Pappou", "Database,BackEnd");

            // Connecting Courses with Trainers
            t1.Courses = new List<Course>() { c10 };
            c10.Trainers.Add(t1);
            t2.Courses = new List<Course>() { c1,c2 };
            c1.Trainers.Add(t2);
            c2.Trainers.Add(t2);           
            t3.Courses = new List<Course>() {c7 , c8 };
            c7.Trainers.Add(t3);
            c8.Trainers.Add(t3);
            t4.Courses = new List<Course>() { c9 };
            c9.Trainers.Add(t4);
            t5.Courses = new List<Course>() { c3 };
            c3.Trainers.Add(t5);
            t6.Courses = new List<Course>() { c4 };
            c4.Trainers.Add(t6);
            t7.Courses = new List<Course>() { c6 };
            c6.Trainers.Add(t7);
            t8.Courses = new List<Course>() { c5 };
            c5.Trainers.Add(t8);
            t9.Courses = new List<Course>() { c7 };
            c7.Trainers.Add(t9);


            Trainers = new List<Trainer>() { t1, t2, t3, t4, t5, t6, t7, t8, t9 };
            #endregion
            #region Seeding Assignments
           
            Assignment a1 = new Assignment("1", "FirstAssignment", "This is the first assignment",new DateTime(2022,12,12),5,7);
            Assignment a2 = new Assignment("2", "SecondAssignment", "This is the second assignment", new DateTime(2022, 12, 12), 5, 7);
            Assignment a3 = new Assignment("3", "ThirdAssignment", "This is the third assignment", new DateTime(2022, 12, 12), 5, 7);
            Assignment a4 = new Assignment("4", "ForthAssignment", "This is the forth assignment", new DateTime(2022, 12, 12), 5, 7);
            Assignment a5 = new Assignment("5", "FirstAssignment", "This is the first assignment", new DateTime(2022, 12, 12), 5, 7);
            Assignment a6 = new Assignment("6", "IndividualProject", "This is the individual Project", new DateTime(2022, 12, 12), 5, 7);
            Assignment a7 = new Assignment("7", "TeamProject", "This is the TeamProject ", new DateTime(2022, 12, 12), 5, 7);

            // Connecting Assignments with Courses
            a1.Courses.Add(c1);
            c1.Assignments.Add(a1);
            a2.Courses.Add(c3);
            c3.Assignments.Add(a2);
            a3.Courses.Add(c5);
            c5.Assignments.Add(a3);
            a4.Courses.Add(c7);
            c7.Assignments.Add(a4);
            a5.Courses.Add(c8);
            c8.Assignments.Add(a5);
            a6.Courses.Add(c9);
            c9.Assignments.Add(a6);
            a7.Courses.Add(c10);
            c10.Assignments.Add(a7);

            // Connecting Assignments with Students
            a1.Students = new List<Student>() { s1, s2, s6, };
            s1.Assignments.Add(a1);
            s2.Assignments.Add(a1);
            s6.Assignments.Add(a1);
            a2.Students = new List<Student>() { s3, s4, s5, };
            s3.Assignments.Add(a2);
            s4.Assignments.Add(a2);
            s5.Assignments.Add(a2);
            a3.Students = new List<Student>() { s10, s20, s9, };
            s10.Assignments.Add(a3);
            s20.Assignments.Add(a3);
            s9.Assignments.Add(a3);
            a4.Students = new List<Student>() { s8, s7, s11, };
            s7.Assignments.Add(a4);
            s8.Assignments.Add(a4);
            s11.Assignments.Add(a4);
            a5.Students = new List<Student>() { s12, s13, s14, };
            s12.Assignments.Add(a5);
            s13.Assignments.Add(a5);
            s14.Assignments.Add(a5);
            a6.Students = new List<Student>() { s1, s2, s16, };
            s1.Assignments.Add(a6);
            s2.Assignments.Add(a6);
            s16.Assignments.Add(a6);
            a7.Students = new List<Student>() { s15, s17, s18, };
            s15.Assignments.Add(a7);
            s17.Assignments.Add(a7);
            s18.Assignments.Add(a7);


            Assignments = new List<Assignment>() { a1, a2, a3, a4, a5, a6, a7, };
            #endregion
           
        }
    }
}
