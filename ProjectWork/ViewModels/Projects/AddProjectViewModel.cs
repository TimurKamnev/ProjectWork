using Microsoft.AspNetCore.Mvc.Rendering;

namespace ProjectWork.ViewModels.Projects;

public class AddProjectViewModel
{
    public AddProjectForm AddProjectForm { get; set; }
    
    public List<SelectListItem> EmployeesListItems { get; set; }
}