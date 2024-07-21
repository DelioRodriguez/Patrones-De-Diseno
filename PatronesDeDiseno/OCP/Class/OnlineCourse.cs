
namespace OCP.Class
{
    public class OnlineCourse : Courses
    {
        public override void Subscribe(Student std)
        {
            Console.WriteLine("Inscrito en el curso oonline");
        }
    }
}
