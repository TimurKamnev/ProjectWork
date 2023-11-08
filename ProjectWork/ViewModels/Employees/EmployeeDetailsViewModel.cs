using Domain.Entities;

namespace ProjectWork.ViewModels.Employees;

public class EmployeeDetailsViewModel
{
    public Employee Employee { get; set; }

    public bool EmployeeHasProjects => Employee.Projects.Count != 0;
}