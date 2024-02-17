using DataAccessLayer.Abstracts;
using EntitiesLayer.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concretes
{
    public class CourseDal:ICourseDal
    {
        VirtualDataBase.DataBase vb;
        public CourseDal()
        {
            vb = new VirtualDataBase.DataBase();
        }
        public List<Course> GetAll()
        {
            return vb.coursesAll();
        }
        public void Add(Course course)
        {
            vb.Add(course);
        }

        public void Delete(Course course)
        {
            vb.Delete(course);
        }

        public void Update(Course course)
        {
            vb.Update(course);
        }
    }
}
