using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP.Class
{
    public class OnlineCourse : Course
    {
        public override string GetCourseDetails()
        {
            return $"Online COurse: {Title}";
        }

        public override void Subscribe(Student std)
        {
            Console.WriteLine("Ha sido inscrito en el curso Online");
        }
    }
}
