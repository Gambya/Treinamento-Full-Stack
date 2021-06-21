using AutoMapper;
using Avanade.SubTCSE.Projeto.Application.Dtos.EmployeeRole;
using Avanade.SubTCSE.Projeto.Domain.Aggregates.EmployeeRole.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avanade.SubTCSE.Projeto.Application.AutoMapperConfigs.Profiles.EmployeeRoleProfile
{
    public class EmployeeRoleProfile: Profile
    {
        public EmployeeRoleProfile()
        {
            CreateMap<EmployeeRoleDto, EmployeeRole>()
                .ForCtorParam("roleName", opt => opt.MapFrom(src => src.Cargo));

            CreateMap<EmployeeRole, EmployeeRoleDto>()
                .ForMember("roleCargo")
        }
    }
}
