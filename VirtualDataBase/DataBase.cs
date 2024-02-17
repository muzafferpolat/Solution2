using EntitiesLayer.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualDataBase
{
    public class DataBase
    {

        List<Course> courses;

        public DataBase()
        {
            courses = new List<Course>();
        }
        public List<Course> coursesAll()
        {
            return courses;
        }
        public void Add(Course _course)
        {
            Course courseGelen = _course as Course;
            courses.Add(_course);
        }
        public void Update(Course _course)
        {

            foreach (var item in courses)
            {
                if (item.CategoryId == _course.CategoryId)
                {
                    item.Name = _course.Name;
                }
            }
        }

        public void Delete(Course _course)
        {
            if (_course != null)
            {
                courses.Remove(_course);
            }
            else
            {
                Console.WriteLine("Silmek istediğiniz kursu belirtin.");
            }
        }
    }
}
