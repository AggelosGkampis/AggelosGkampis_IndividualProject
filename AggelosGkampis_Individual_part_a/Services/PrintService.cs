using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AggelosGkampis_Individual_part_a
{
    class  PrintService
    {
        Database Database = new Database();
        const int first = -30;
        const int second = -30;
        const int third = -30;
        const int fourth = -30;
        const int fifth = -30;
        const int sixth = -10;

        public void GetAll()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Courses");
            Console.WriteLine();
            Console.ResetColor();

            foreach (var item in DataRepository.courses)
            {
                Console.WriteLine($"Title -- {item.Title,first} Stream -- {item.Stream,second} Type -- {item.TypeOfCourse,third} Start_Date -- {item.Start_date,fourth}     End_Date -- {item.End_date,fifth}");
            }

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Students");
            Console.WriteLine();
            Console.ResetColor();

            foreach (var item in DataRepository.students)
            {
                Console.WriteLine($"ID -- {item.Id,first} LastName -- {item.LastName,second} FirstName -- {item.FirstName,third} Date_Of_Birth -- {item.DateOfBirth,fourth}    Tuition_Fees -- {item.TuitionFees,fifth}");
            }

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Trainers");
            Console.WriteLine();
            Console.ResetColor();

            foreach (var item in DataRepository.trainers)
            {
                Console.WriteLine($"ID -- {item.Id,first} LastName -- {item.LastName,second} FirstName -- {item.FirstName,third} Subject -- {item.Subject,fourth}");
            }

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Assignments");
            Console.WriteLine();
            Console.ResetColor();

            foreach (var item in DataRepository.assignments)
            {
                Console.WriteLine($"ID -- {item.Id,first} Title -- {item.Title,second} Description -- {item.Description,third} Sub_Date -- {item.SubDateTime,fourth}   Oral_Mark --{item.OralMark,fifth} Total_Mark --{item.TotalMark,sixth}");
            }
      
        }

        public void GetCourses()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Courses");
            Console.WriteLine();
            Console.ResetColor();

            foreach (var item in DataRepository.courses)
            {
                Console.WriteLine($"Title -- {item.Title,first} Stream -- {item.Stream,second} Type -- {item.TypeOfCourse,third} Start_Date -- {item.Start_date,fourth}     End_Date -- {item.End_date,fifth}");
            }
        }

        public void GetStudents()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Students");
            Console.WriteLine();
            Console.ResetColor();

            foreach (var item in DataRepository.students)
            {
                Console.WriteLine($"ID -- {item.Id,first} LastName -- {item.LastName,second} FirstName -- {item.FirstName,third} Date_Of_Birth -- {item.DateOfBirth,fourth}    Tuition_Fees -- {item.TuitionFees,fifth}");
            }
        }

        public void GetTrainers()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Trainers");
            Console.WriteLine();
            Console.ResetColor();

            foreach (var item in DataRepository.trainers)
            {
                Console.WriteLine($"ID -- {item.Id,first} LastName -- {item.LastName,second} FirstName -- {item.FirstName,third} Subject -- {item.Subject,fourth}");
            }
        }

        public void GetAssignments()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Assignments");
            Console.WriteLine();
            Console.ResetColor();

            foreach (var item in DataRepository.assignments)
            {
                Console.WriteLine($"ID -- {item.Id,first} Title -- {item.Title,second} Description -- {item.Description,third} Sub_Date -- {item.SubDateTime,fourth}   Oral_Mark --{item.OralMark,fifth} Total_Mark --{item.TotalMark,sixth}");
            }
        }

        public void GetStudentPerCourse()
        {
            Course course = new Course();
            Student student = new Student();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Students/Course");
            Console.WriteLine();
            Console.ResetColor();

            foreach (var item in DataRepository.students)
            {
                Console.WriteLine($"ID -- {item.Id,first} LastName -- {item.LastName,second} FirstName -- {item.FirstName,third} Date_Of_Birth -- {item.DateOfBirth,fourth}    Tuition_Fees -- {item.TuitionFees,fifth}");
               
                foreach (var item2 in item.Courses)
                {
                    Console.WriteLine($"   Title -- {item2.Title,first} ");
                }
                Console.WriteLine();
            }
        }

        public void StudentsWithMoreThanOneCourse()
        {
            Course course = new Course();
            Student student = new Student();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Students with more than one Courses");
            Console.WriteLine();
            Console.ResetColor();

            foreach (var item in DataRepository.students)
            {
                if (item.Courses.Count > 1)
                    Console.WriteLine($"ID -- {item.Id,first} LastName -- {item.LastName,second} FirstName -- {item.FirstName,third} Date_Of_Birth -- {item.DateOfBirth,fourth}    Tuition_Fees -- {item.TuitionFees,fifth}");
            }
        }

        public void GetTrainerPerCourse()
        {
            Course course = new Course();
            Student student = new Student();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Trainers/Course");
            Console.WriteLine();
            Console.ResetColor();

            foreach (var item in DataRepository.trainers)
            {
               Console.WriteLine($"ID -- {item.Id,first} LastName -- {item.LastName,second} FirstName -- {item.FirstName,third} Subject -- {item.Subject,fourth}");
                foreach (var item2 in item.Courses)
                {
                    Console.WriteLine($"   Title -- {item2.Title,first} ");
                }
                Console.WriteLine();
            }
        }

        public void GetAssignmentsPerCourse()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Assignments/Course");
            Console.WriteLine();
            Console.ResetColor();

            foreach (var item in DataRepository.assignments)
            {
                Console.WriteLine($"ID -- {item.Id,first} Title -- {item.Title,second} Description -- {item.Description,third} Sub_Date -- {item.SubDateTime,fourth}   Oral_Mark --{item.OralMark,fifth} Total_Mark --{item.TotalMark,sixth}");
                foreach (var item2 in item.Courses)
                {
                    Console.WriteLine($"   Title -- {item2.Title,first} ");
                }
                Console.WriteLine();
            }
        }

        public void GetAssignmentsPerStudent()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Assignments/Student");
            Console.WriteLine();
            Console.ResetColor();

            foreach (var item in DataRepository.assignments)
            {
                Console.WriteLine($"ID -- {item.Id,first} Title -- {item.Title,second} Description -- {item.Description,third} Sub_Date -- {item.SubDateTime,fourth}   Oral_Mark --{item.OralMark,fifth} Total_Mark --{item.TotalMark,sixth}");
                foreach (var item2 in item.Students)
                {
                    Console.WriteLine($"    ID -- {item2.Id,first} LastName -- {item2.LastName,second} FirstName -- {item2.FirstName,third} ");
                }
                Console.WriteLine();
            }
        }










        //public void PrintCourses(string course,string stream,List<Student> students)
        //{
        //    Console.WriteLine(course,stream,students);
        //}
        //public void PrintStudents(Student student)
        //{
        //    Console.WriteLine(student.ToString());
        //}
        //public void PrintTrainers(Trainer trainer)
        //{
        //    Console.WriteLine(trainer.ToString());
        //}
        //public void PrintAssignments(Assignment assignment)
        //{
        //    Console.WriteLine(assignment.ToString());
        //}
        //public void PrintStudentsWithManyCourses(Student student)
        //{
        //    Console.WriteLine(student.ToString());
        //}


    }
}
