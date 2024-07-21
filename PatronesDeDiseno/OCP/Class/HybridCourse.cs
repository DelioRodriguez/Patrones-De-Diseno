
namespace OCP.Class
{
    public class HybridCourse : Courses
    {
    
        public override void Subscribe(Student std)
        {
            Console.WriteLine("Inscrito en el curso hybrido");
        }
    }
}
