using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AggelosGkampis_Individual_part_a
{
    public class Student
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public float TuitionFees { get; set; }
        public List<Trainer> Trainers { get; set; } = new List<Trainer>();
        public List<Assignment> Assignments { get; set; } = new List<Assignment>();
        public List<Course> Courses { get; set; } = new List<Course>();
        

        public Student(string id, string firstname, string lastname,DateTime dateOfBirth,float tuitionFees)
        {
            Id = id;
            FirstName = firstname;
            LastName = lastname;
            DateOfBirth = dateOfBirth;
            TuitionFees = tuitionFees;
        }
        public Student()
        {

        }

        public override string ToString()
        {
            return LastName + " " + FirstName;
        }
    }
}
