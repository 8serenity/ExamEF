using System.Collections.Generic;

namespace ExamEF
{
    public class Lecturer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Rank { get; set; }
        public string Position { get; set; }
        public virtual ICollection<Group> Groups { get; set; }
        public virtual ICollection<Course> Courses { get; set; }

        public Lecturer()
        {
            Courses = new HashSet<Course>();
        }
    }
}