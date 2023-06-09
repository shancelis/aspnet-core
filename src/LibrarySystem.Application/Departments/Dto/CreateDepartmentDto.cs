﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Abp.Domain.Entities;
using Abp.AutoMapper;
using LibrarySystem.Entities;
using LibrarySystem.Departments.Dto;

namespace LibrarySystem.Departments.Dto
{
    [AutoMapFrom(typeof(DepartmentDto))]
    [AutoMapTo(typeof(Department))]

    public class CreateDepartmentDto
    {
        public string Name { get; set; }
    }


}
