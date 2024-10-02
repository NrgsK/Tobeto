using Core.DataAccess.EntityFramework;
using Core.Utilities.Results;
using DataAccess.Abstracts;
using Entities.Concretes;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes.EntityFramework
{
    public class EfCourseDal : EfEntityRepositoryBase<Course, TobetoAcademyContext>, ICourseDal
    {
      public List<CourseDetailDto> GetCourseDetails()
        {
            using (TobetoAcademyContext context=new TobetoAcademyContext())
            {
                var result = from c in context.Courses
                             join cat in context.Categories
                             on c.CategoryId equals cat.CategoryId
                             join i in context.Instructors
                             on c.InstructorId equals i.InstructorId
                             select new CourseDetailDto { CourseId=c.CourseId,CourseName=c.CourseName,InstructorName=i.FirstName,CategoryName=cat.CategoryName  };
                return result.ToList();
            }
        }
    }
}
