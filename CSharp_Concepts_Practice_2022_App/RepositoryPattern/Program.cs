using RepositoryPattern;

CourseRepository courseRepo = new CourseRepository();

Course course = new Course()
{
    Title = "C#",
    ClassStartTime = DateTime.Now,
    Fees = 20.23,
    isActive= true,

};

courseRepo.Add(course);
//bool find = courses.Contains(course);
//courses.Remove(course);
courseRepo.Get(1);
courseRepo.Remove(course);