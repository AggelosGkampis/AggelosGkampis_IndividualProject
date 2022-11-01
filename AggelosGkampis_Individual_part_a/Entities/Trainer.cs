using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AggelosGkampis_Individual_part_a
{
    public class Trainer
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Subject { get; set; }
        public List<Student> Students { get; set; } = new List<Student>();
        public List<Assignment> Assignments { get; set; } = new List<Assignment>();
        public List<Course> Courses { get; set; } = new List<Course>();
        public Trainer(string id, string firstName, string lastName, string subject)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Subject = subject;
        }
        public Trainer()
        {

        }
    }
}
