using System.Linq;
using BigSchool.Models;

namespace BigSchool.Controllers
{
    internal class CoursesViewModel
    {
        public IQueryable<Course> UpCommingCourses { get; set; }
        public bool ShowAction { get; set; }
    }
}