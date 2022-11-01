using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AggelosGkampis_Individual_part_a
{
    class InputDataService
    {


        public static void InputData()
        {
            Course course = new Course();
            Student student = new Student();
            Trainer trainer = new Trainer();
            Assignment assignment = new Assignment();
            string doYouWantToContinue;
            int Input = 0;
            do
            {
                Console.WriteLine("For Courses press 1\t For Students press 2\t For Trainers press 3\t For Assignments press 4\t");
                Input =Convert.ToInt32(Console.ReadLine());
                switch (Input)
                {
                    case 1:
                        Console.WriteLine("Give the title of the Course");
                        course.Title = Console.ReadLine();                           
                        Console.WriteLine("Give the Stream of the Course");
                        course.Stream = Console.ReadLine();
                        Console.WriteLine("Give the Type of the Course");
                        Console.WriteLine("If you want PartTime press 0 , If you want FullTime press 1");
                        course.TypeOfCourse = (TypeOfCourse)Int32.Parse(Console.ReadLine());
                        Console.WriteLine(course.TypeOfCourse);
                        Console.WriteLine("Give the Starting Date of the Course");
                        course.Start_date = Convert.ToDateTime(Console.ReadLine());
                        Console.WriteLine("Give the Ending Date of the Course");
                        course.End_date = Convert.ToDateTime(Console.ReadLine());
                        DataRepository.courses.Add(course);
                        break;
                    case 2:
                        Console.WriteLine("Give the ID of the Student");
                        student.Id = Console.ReadLine();
                        Console.WriteLine("Give the First Name of the Student");
                        student.FirstName =Console.ReadLine();
                        Console.WriteLine("Give the Last Name of the Student");
                        student.LastName = Console.ReadLine();
                        Console.WriteLine("Give the Date of birth of the Student");
                        student.DateOfBirth = Convert.ToDateTime(Console.ReadLine());
                        Console.WriteLine("Give the Tuition fees of the Student");
                        student.TuitionFees = Convert.ToInt32(Console.ReadLine());
                        DataRepository.students.Add(student);
                        break;
                    case 3:
                        Console.WriteLine("Give the ID of the Trainer");
                        trainer.Id = Console.ReadLine();
                        Console.WriteLine("Give the First Name of the Trainer");
                        trainer.FirstName = Console.ReadLine();
                        Console.WriteLine("Give the Last Name of the Trainer");
                        trainer.LastName = Console.ReadLine();
                        Console.WriteLine("Give the Subject of the Trainer");
                        trainer.Subject = Console.ReadLine();
                        DataRepository.trainers.Add(trainer);
                        break;
                    case 4:
                        Console.WriteLine("Give the of ID the Assignment");
                        assignment.Id = Console.ReadLine();
                        Console.WriteLine("Give the of Title the Assignment");
                        assignment.Title = Console.ReadLine();
                        Console.WriteLine("Give the of Description the Assignment");
                        assignment.Description = Console.ReadLine();
                        Console.WriteLine("Give the of Sub Date the Assignment");
                        assignment.SubDateTime = Convert.ToDateTime(Console.ReadLine());
                        Console.WriteLine("Give the of Oral Mark the Assignment");
                        assignment.OralMark = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Give the of Total Mark the Assignment");
                        assignment.TotalMark = Convert.ToInt32(Console.ReadLine());
                        DataRepository.assignments.Add(assignment);
                        break;
                }
                Console.WriteLine("Do you want to continue adding data ? y / n");
                doYouWantToContinue = (Console.ReadLine());
            }
            while (doYouWantToContinue is "y" || doYouWantToContinue is "Y" || doYouWantToContinue is "Yes" || doYouWantToContinue is "YES");
        }


    }
}