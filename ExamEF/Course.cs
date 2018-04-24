using System.Collections.Generic;

namespace ExamEF
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Lecturer> Lecturers { get; set; }

        public Course()
        {
            Lecturers = new HashSet<Lecturer>();
        }
    }
}