// Webassemblyproject.Shared.Course
namespace Webassemblyproject.Shared
{
    public class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }

        // Navigation Property
        public List<Student> Students { get; set; }
    }
}
