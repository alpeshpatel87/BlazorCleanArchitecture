using Application.Interfaces;
using Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class ProjectService : IProjectService
    {
        public IProjectRepository _projectRepository;
        public ProjectService(IProjectRepository projectRepository)
        {
            _projectRepository = projectRepository;
        }
        public ProjectViewModel GetProjects()
        {
            return new ProjectViewModel()
            {
                Projects = _projectRepository.GetProjects()
            };
        }
    }
}
