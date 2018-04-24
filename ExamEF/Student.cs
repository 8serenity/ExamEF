using System.ComponentModel.DataAnnotations.Schema;

namespace ExamEF
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Semester { get; set; }
        public double? GPA { get; set; }
        [ForeignKey("Group")]
        public int GroupId { get; set; }
        public virtual Group Group { get; set; }
    }
}