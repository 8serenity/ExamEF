namespace ExamEF
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;

    public class UniversityModel : DbContext
    {
        // Your context has been configured to use a 'UniversityModel' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'ExamEF.UniversityModel' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'UniversityModel' 
        // connection string in the application configuration file.
        public UniversityModel()
            : base("name=UniversityModel")
        {
            Database.SetInitializer(new UniversityDbInitializer());
        }
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Lecturer> Lecturers { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Student> Students { get; set; }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    public class UniversityDbInitializer : CreateDatabaseIfNotExists<UniversityModel>
    {
        protected override void Seed(UniversityModel context)
        {
            Group testGroup = new Group();
            testGroup.Name = "TestName";
            testGroup.Semester = 1;
            context.Groups.Add(testGroup);

            Student testStudent1 = new Student();
            testStudent1.Name = "Maksat";
            testStudent1.Semester = 1;
            testStudent1.GroupId = 1;
            Student testStudent2 = new Student();
            testStudent2.Name = "Kairat";
            testStudent2.Semester = 1;
            testStudent2.GroupId = 1;
            Student testStudent3 = new Student();
            testStudent3.Name = "John";
            testStudent3.Semester = 1;
            testStudent3.GroupId = 1;
            context.Students.AddRange(new List<Student>() { testStudent1, testStudent2, testStudent3 });


            Lecturer testLecturer1 = new Lecturer();
            testLecturer1.Name = "Lecturer 1";
            testLecturer1.Position = "Position test 1";
            testLecturer1.Rank = "Rank test 1";
            Lecturer testLecturer2 = new Lecturer();
            testLecturer2.Name = "Lecturer 2";
            testLecturer2.Position = "Position test 2";
            testLecturer2.Rank = "Rank test 33";
            Lecturer testLecturer3 = new Lecturer();
            testLecturer3.Name = "Lecturer 3";
            testLecturer3.Position = "Position test 21";
            testLecturer3.Rank = "Rank test 111";
            context.Lecturers.AddRange(new List<Lecturer>() { testLecturer1, testLecturer2, testLecturer3 });


            Course testCourse1 = new Course();
            testCourse1.Name = "Math";
            testCourse1.Lecturers.Add(testLecturer1);
            testCourse1.Lecturers.Add(testLecturer2);
            testCourse1.Lecturers.Add(testLecturer3);
            Course testCourse2 = new Course();
            testCourse2.Name = "Art";
            testCourse2.Lecturers.Add(testLecturer2);
            Course testCourse3 = new Course();
            testCourse3.Name = "C#";
            testCourse3.Lecturers.Add(testLecturer3);
            context.Courses.AddRange(new List<Course>() { testCourse1, testCourse2, testCourse3 });

            Schedule testSchedule = new Schedule
            {
                TimeCourse = new DateTime(2018, 04, 25, 11, 30, 0),
                GroupId = 1,
                LecturerId = 3,
                CourseID = 3
            };
            context.Schedules.Add(testSchedule);


            //context.Standards.AddRange(defaultStandards);

            base.Seed(context);
        }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}