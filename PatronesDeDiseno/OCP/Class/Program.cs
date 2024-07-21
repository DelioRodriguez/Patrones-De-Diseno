
namespace OCP.Class
{
    public class Program
    {
        static void Main(string[] args) {
            Student student = new Student { StudentId = 1, StudentName = "Francis" };
            Courses onlineCourse = new OnlineCourse();
            Courses offlineCourse = new OfflineCourse();
            Courses hybridCourse = new HybridCourse();

            onlineCourse.Subscribe(student);
            offlineCourse.Subscribe(student);
            hybridCourse.Subscribe(student);
        }
    }
}
