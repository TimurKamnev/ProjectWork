using Application.Dtos.Project;
using Domain.Enums;

namespace ProjectWork.ViewModels.Projects;

public class SortAndFilterDto
{
    public ProjectFilterDto Filter { get; set; } = new();
}