using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AggelosGkampis_Individual_part_a
{
    public class Menu
    {
        PrintService print = new PrintService();    
        public void StartMenu()
        {

            int Input = 0;
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Choose an option from below");
            Console.WriteLine();
            Console.ResetColor();
            Console.WriteLine("If you want to use sythetic data press 1\t If you want to entry data press 2\t If you want to exit press 3\t");
            Input = Convert.ToInt32(Console.ReadLine());
           
            switch (Input)
            {
                case 1:
                    Database db = new Database();
                    DataRepository.courses = db.Courses;
                    DataRepository.students = db.Students;
                    DataRepository.trainers = db.Trainers;
                    DataRepository.assignments = db.Assignments;
                    break;
                case 2:
                    InputDataService.InputData();
                    break;
                case 3:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Please give a correct number");
                    break;
                }
           

            
        }

        public void ViewMenu()
        {           
            const int first = -40;
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Choose an option from below");
            Console.WriteLine();
            Console.ResetColor();
            Console.WriteLine("------------- ALL DATA --------------");
            Console.WriteLine($"{"1 - GetAllData",first}");
            Console.WriteLine($"{"2 - Courses",first}");
            Console.WriteLine($"{"3 - Students",first}");
            Console.WriteLine($"{"4 - Trainers",first}");
            Console.WriteLine($"{"5 - Assignments",first}");
            Console.WriteLine($"{"6 - Student per Course",first}");
            Console.WriteLine($"{"7 - Trainer per Course",first}");
            Console.WriteLine($"{"8 - Assignment per Course",first}");
            Console.WriteLine($"{"9 - Assignment per Student",first}");
            Console.WriteLine($"{"10 - Students with more than one Course",first}");
            int Input = Convert.ToInt32(Console.ReadLine());
            switch (Input)
            {
                case 1:print.GetAll();
                    break;
                case 2:print.GetCourses();
                    break;
                case 3:print.GetStudents();
                    break;
                case 4:print.GetTrainers();
                    break;
                case 5:print.GetAssignments();
                    break;
                case 6:print.GetStudentPerCourse();
                    break;
                case 7:print.GetTrainerPerCourse();
                    break;
                case 8:print.GetAssignmentsPerCourse();
                    break;
                case 9: print.GetAssignmentsPerStudent();
                    break;
                case 10:print.StudentsWithMoreThanOneCourse();
                    break;
                default:
                    Console.WriteLine("Please give a correct number");
                    break;
            }
            

        }

    }
}
