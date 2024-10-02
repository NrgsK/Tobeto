using Business.Concretes;
using DataAccess.Concretes.EntityFramework;
using Entities.Concretes;

CourseTest();


static void CourseTest()
{
    CourseManager courseManager = new CourseManager(new EfCourseDal());

    Course course = new Course()
    {
        CourseName = "C#",
        CategoryId = 1,
        InstructorId = 1

    };

    var result = courseManager.Add(course); //**
    Console.WriteLine(result.Message);
}

//Sıfırdan proje oluşturunuz --> TobetoETrade
//Product sınıfını katmanlarında işletiniz.
//Product --> Id,Name,Unitprice