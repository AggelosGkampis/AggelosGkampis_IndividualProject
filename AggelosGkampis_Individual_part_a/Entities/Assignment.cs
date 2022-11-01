using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AggelosGkampis_Individual_part_a
{
    public class Assignment
    {
        public string Id { get; set; }
        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime SubDateTime { get; set; }

        public float OralMark { get; set; }
        public float TotalMark { get; set; }

        public List<Student> Students { get; set; } = new List<Student>();
       
        public List<Course> Courses { get; set; } = new List<Course>();

        public Assignment(string id, string title, string description, DateTime subDateTime, float oralMark, float totalMark)
        {
            Id = id;
            Title = title;
            Description = description;
            SubDateTime = subDateTime;
            OralMark = oralMark;
            TotalMark = totalMark;
        }

        public Assignment()
        {

        }
    }
}
