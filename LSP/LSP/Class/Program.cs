using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP.Class
{
    public class Program
    {
        static void Main(string[] args)
        {
            Course onlineCourse = new OnlineCourse { CourseId = 1,Title = "C# Principiante"};
            Course offlineCourse = new OfflineCOurse { CourseId = 2, Title = "C# Intermedio" };
            Course hybridCourse = new HybridCOurse { CourseId = 3, Title = "C# avanzado" };

            Student student = new Student { StudentID = 1, Name = "Delio" };

            onlineCourse.Subscribe(student);
            offlineCourse.Subscribe(student);   
            hybridCourse.Subscribe(student);
            Console.WriteLine(onlineCourse.GetCourseDetails());
            Console.WriteLine(offlineCourse.GetCourseDetails());
            Console.WriteLine(hybridCourse.GetCourseDetails());
        }

   
    }
}
