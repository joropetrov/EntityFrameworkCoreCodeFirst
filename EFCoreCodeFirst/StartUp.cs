namespace EFCoreCodeFirst
{
    using System;
    using System.Linq;
    using Data.Models;
    using EFCoreCodeFirst.Data;

    public class StartUp
    {
        public static void Main()
        {
            /*
     do 50 minuta  https://softuni.bg/trainings/resources/video/44106/video-31-october-2019-ivaylo-kenov-entity-framework-core-october-2019/2457
    */
            var studentType = typeof(Student)
                .GetProperty(nameof(Student.FirstName))
                .GetCustomAttributes(false);

            using (var db = new StudentDbContext())
            {
                db.Database.EnsureCreated();

                db.Students.Add(new Student
                {
                    FirstName = "Ivan",
                    MiddleName = "Petrov",
                    LastName = "Ivanov",
                    RegistrationDate = DateTime.UtcNow,
                    Type = StudentType.Enrolled
                });

                db.SaveChanges();

                db.Students.ToList();
            }
        }
    }
}
