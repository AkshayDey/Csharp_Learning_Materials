using UnitOfWorkPattern;
using UnitOfWorkPattern.Class;

string sqlConnection = "";

TrainingUnitOfWork trainingUnitOfWork = new TrainingUnitOfWork(sqlConnection);
trainingUnitOfWork.Add(new Course { Title= "C#", Fees = 8000, IsActive = true });
trainingUnitOfWork.Add(new Student { Name = "A", CGPA = 3.06 });

trainingUnitOfWork.Commit();