
using NewSwitchStatementPracticeExample;

static bool CheckEmployeeEligibility(Employee aEmployee, bool empAbsent)
{
    switch (aEmployee.EmpStatus)
    {
        case EmployeeStatus.Junior:
            return true;
        case EmployeeStatus.Senior:
            return false;
        case EmployeeStatus.Absent:
            return empAbsent;

        default: return false;
    }
}

// Instead of writing this conventional Switch case statement we can write the new switch case statement like below

static bool GetEmpEligibility(Employee aEmployee) =>
    aEmployee.EmpStatus switch
    {
        EmployeeStatus.Present => true,
        EmployeeStatus.Junior => true,
        _ => false
    };
