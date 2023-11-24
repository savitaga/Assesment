using AutoMapper;
using EmployeeManagement.Business.Models;
using EmployeeManagement.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Business.Config
{
    public class MapperConfig :Profile
    {
        public MapperConfig()
        {
            CreateMap<UserEntity, User>().ReverseMap();
        }

    }
}
