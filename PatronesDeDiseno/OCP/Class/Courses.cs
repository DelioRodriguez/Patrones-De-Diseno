
namespace OCP.Class
{
    public abstract class Courses
    {
        public int CourseId { get; set; }
        public String Title { get; set; }

        public abstract void Subscribe(Student std);
    }
}
