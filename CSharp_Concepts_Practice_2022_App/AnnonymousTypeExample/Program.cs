dynamic dataOne  = new { Id = 23, Name = "Annonymous Object", Age = 34 };
dynamic dataTwo = new { Id = 34, Name = "Another annonymous Object", Age = 23 };

//Console.WriteLine("DataOne Id is {0} and Name is {1}", dataOne.Id, dataOne.Name);

dynamic d;
int num = 100;

d = (dynamic)num;
Console.WriteLine(d);  // dynamic data type >>
                       // Run time check 