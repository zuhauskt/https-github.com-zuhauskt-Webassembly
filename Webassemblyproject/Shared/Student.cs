// Webassemblyproject.Shared.Student
namespace Webassemblyproject.Shared
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public int Mark { get; set; }

        // Navigation Property
        public int CourseId { get; set; }
        public Course Course { get; set; }
    }
}
