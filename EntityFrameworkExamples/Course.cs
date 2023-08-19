using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkExamples
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Fees { get; set; }
        public DateTime ClassStartDate { get; set; }
        public bool IsActive { get; set; }
        public List<Topic> CourseTopics { get; set; }
        public List<CourseStudent> CourseStudents { get; set; }

    }
}
