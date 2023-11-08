using Domain.Entities;

namespace ProjectWork.ViewModels.Projects;

public class ProjectDetailsViewModel
{
    public Project Project { get; set; }
    public bool EmployeeHasProjects => Project.Employees.Count != 0;
}