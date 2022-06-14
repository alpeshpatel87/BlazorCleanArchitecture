using Application.Interfaces;
using Domain.Entities;
using Infrastructure.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class ProjectRepository : IProjectRepository
    {
        public ProjectDbContext _context;
        public ProjectRepository(ProjectDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Projects> GetProjects()
        {
            return _context.Projects;
        }
    }
}
