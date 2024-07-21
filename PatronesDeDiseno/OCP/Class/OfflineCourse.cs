

namespace OCP.Class
{
    public class OfflineCourse : Courses
    {
        public override void Subscribe(Student std)
        {
            Console.WriteLine("Estudiante inscrito en el curso Offline");
        }
    }
}
