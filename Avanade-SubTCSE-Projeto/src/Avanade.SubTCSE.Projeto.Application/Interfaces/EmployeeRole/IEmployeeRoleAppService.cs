using Avanade.SubTCSE.Projeto.Application.Dtos.EmployeeRole;
using System;
using System.Collections.Generic;
using System.Text;

namespace Avanade.SubTCSE.Projeto.Application.Interfaces.EmployeeRole
{
    public interface IEmployeeRoleAppService
    {
        void AddEmployeeRole(EmployeeRoleDto employeeRoleDto);
    }
}
