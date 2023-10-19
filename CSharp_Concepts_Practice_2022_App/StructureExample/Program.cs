using StructExample;

Student s = new Student();
s.Name = "Random";

Student s2 = s;
s2.Name = "New Random";

Console.WriteLine(s.Name);  // Value type uses stack memory
Console.WriteLine(s2.Name);

Teacher aTeacher = new Teacher();
aTeacher.Name = "Rafa";

Teacher bTeacher = new Teacher();
bTeacher = aTeacher;  // copies the same memory location of the new Instance object

bTeacher.Name = "Farhan"; // so changing here will also change all the copied memory address
// reference type uses heap memory



//Console.WriteLine(aTeacher.Name);
//Console.WriteLine(bTeacher.Name);

Test(s2);

Console.WriteLine(s2.Name);

void Test(Student aStudent)
{
    aStudent.Name = "Rafiq";
}
