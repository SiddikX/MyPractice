using EntityFrameworkExamples;
using Microsoft.EntityFrameworkCore;

TrainingDbContext context = new TrainingDbContext();

/*context.Courses.Add(new Course { Name = "ggjkng", Fees = 7000, ClassStartDate = DateTime.Now, IsActive = true });
context.Courses.Add(new Course { Name = "Dj", Fees = 4000, ClassStartDate = DateTime.Now, IsActive = true });
context.Students.Add(new Student { Name = "Siddik", CGPA = 3.26, Adress = "Dhaka" });
context.SaveChanges();*/

//Course course = context.Courses.Where(x => x.Id == 4).FirstOrDefault();

/*Console.WriteLine(course.Fees);

course.Fees = 10000;
context.SaveChanges();

context.Courses.Remove(course);
context.SaveChanges();*/

//if (course?.CourseTopics == null)
//{
//    course.CourseTopics = new List<Topic>();
//}

//course?.CourseTopics?.AddRange(new Topic[]
//{
//    new Topic { Title = "Getting Started"},
//    new Topic { Title = "Tool Installation"}

//});

//context.SaveChanges();

Course course2 = context.Courses.Where(x => x.Id == 4).Include(y => y.CourseTopics).FirstOrDefault();
foreach(var item in course2.CourseTopics)
{
    Console.WriteLine(item.Title);
}

Course c1 = new Course
{
    Name = "DevOps",
    Fees = 15000,
    IsActive = true,
    ClassStartDate = DateTime.Now,
    CourseTopics = new List<Topic>
    {
        new Topic { Title = "Docker"},
        new Topic { Title = "AWS"}
    },

    CourseStudents = new List<CourseStudent>
    {
        new CourseStudent {Student = new Student { Name = "Hasanul", CGPA = 3.6, Adress = "Dhaka" }},
        new CourseStudent {Student = new Student { Name = "Rahman", CGPA = 3.9, Adress = "Dhaka"}}
    }

};

context.Courses.Add(c1);
context.SaveChanges();