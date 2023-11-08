using Application.Dtos.Employee;
using Application.Dtos.Project;
using AutoMapper;
using ProjectWork.ViewModels.Employees;
using ProjectWork.ViewModels.Projects;

namespace ProjectWork.AutomapperConfiguration;

public class AutoMapperProfile : Profile
{
    public AutoMapperProfile()
    {
        CreateMap<AddEmployeeDto, CreateEmployeeDto>();
        CreateMap<EditEmployeeDto, UpdateEmployeeDto>();

        CreateMap<AddProjectForm, CreateProjectDto>();
        CreateMap<EditProjectForm, UpdateProjectDto>();
    }
}