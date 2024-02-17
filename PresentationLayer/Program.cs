using BusinessLogicLayer.Concrete;
using DataAccessLayer.Concretes;
using EntitiesLayer.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Course course1 = new Course();
            course1.Id = 1;
            course1.Name = "Flutter";
            course1.Comment = "Hayat ne güzel";
            course1.CategoryId = 1;

            Course course2 = new Course();
            course2.Id = 2;
            course2.Name = "Java";
            course2.Comment = "Java adalarında bir dil";
            course2.CategoryId = 2;

            Course course3 = new Course();
            course2.Id = 2;
            course2.Name = "Visual Basic";
            course2.Comment = "Güncel Kurs";
            course2.CategoryId = 2;
            
            Course course4 = new Course();
            course2.Id = 3;
            course2.Name = "PHP";
            course2.Comment = "Web programlama zamanı";
            course2.CategoryId = 2;

            Course course5 = new Course();
            course2.Id = 3;
            course2.Name = "PHP";
            course2.Comment = "Web programlama zamanı";
            course2.CategoryId = 2;


            CourseManager courseManager = new CourseManager(new CourseDal());

            courseManager.Add(course1);
            courseManager.Add(course2);
            courseManager.Update(course2);
            courseManager.Delete(course5);

            List<Course> courses = courseManager.GetAll();



            foreach (var item in courses)
            {
                Console.WriteLine($"İd:{item.Id} - Adı: {item.Name} - Açıklama: {item.Comment} - Kategori Id: {item.CategoryId}");
            }



            Console.ReadLine();
        }
    }
}
