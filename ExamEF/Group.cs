using System.Collections.Generic;

namespace ExamEF
{
    public class Group
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Semester { get; set; }
        public virtual ICollection<Student> Students { get; set; }

        public Group()
        {
            Students = new HashSet<Student>();
        }
    }
}