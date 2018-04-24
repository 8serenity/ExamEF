using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamEF
{
    public class Schedule
    {
        public int Id { get; set; }
        public DateTime TimeCourse { get; set; }
        [ForeignKey("Group")]
        public int GroupId { get; set; }
        public Group Group { get; set; }
        [ForeignKey("Lecturer")]
        public int LecturerId { get; set; }
        public Lecturer Lecturer { get; set; }
        [ForeignKey("Course")]
        public int CourseID { get; set; }
        public Course Course { get; set; }
    }
}
