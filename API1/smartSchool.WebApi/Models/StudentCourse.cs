using System;

namespace smartSchool.WebApi.Models
{
    public class StudentCourse
    {

        public StudentCourse()
        {

        }

        public StudentCourse(int StudentId, int courseId)
        {
            this.StudentId = StudentId;
            this.CourseId = courseId;
        }

        public DateTime IniDate { get; set; } = DateTime.Now;
        public DateTime? EndDate { get; set; } = null;
        public int StudentId { get; set; }
        public Student Student { get; set;}
        public int CourseId { get; set; }
        public Course Course { get; set; }
    }
}