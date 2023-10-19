
using Delegt_Prac_2_Example;
using static Delegt_Prac_2_Example.Employee;

Employee aEmployee =  new Employee();


bool IsPromoted(Employee emp)
{
    if(emp.Experience > 2 && (emp.salary <= 30000 && emp.salary >= 20000) )
    {
        return true;
    }
    else
        return false;
}

List<Employee> employees = new List<Employee>()
{
    new Employee() { ID = 134, Name = "A", Experience = 4, salary = 30000},
    new Employee() {ID = 123, Name = "B", Experience = 5, salary = 60000},
    new Employee() { ID = 133, Name = "C", Experience = 2, salary = 30000},
    new Employee() {ID = 135, Name = "D", Experience = 1, salary = 60000}
};
// called the method
aEmployee.Promoted(employees,IsPromoted);