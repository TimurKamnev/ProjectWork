using Application.Dtos.Project;
using Domain.Entities;

namespace ProjectWork.ViewModels.Projects;

public class ProjectIndexViewModel
{
    public List<Project> Projects { get; set; }
    public ProjectFilterDto Filter { get; set; }
 
}