﻿using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ViewModels
{
    public class ProjectViewModel
    {
        public IEnumerable<Projects> Projects { get; set; }
    }
}
