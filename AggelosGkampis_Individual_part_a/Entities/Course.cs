using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AggelosGkampis_Individual_part_a
{
    public class Course
    {
        public string Title { get; set; }

        public string Stream { get; set; }

        public TypeOfCourse TypeOfCourse { get; set; }
        public DateTime Start_date { get; set; }

        public DateTime End_date { get; set; }

        public List<Trainer> Trainers { get; set; } = new List<Trainer>();
        public List<Assignment> Assignments { get; set; } = new List<Assignment>();
        public List<Student> Students { get; set; } = new List<Student>();
      
        public Course(string title, string stream, TypeOfCourse type, DateTime start_date, DateTime end_date)
        {
            Title = title;
            Stream = stream;
            TypeOfCourse = type;
            Start_date = start_date;
            End_date = end_date;
        }
        public Course()
        {
            
        }

        //public override string ToString()
        //{
        //    return ($"Title{Title},Stream{Stream}");
        //}

    }
}
