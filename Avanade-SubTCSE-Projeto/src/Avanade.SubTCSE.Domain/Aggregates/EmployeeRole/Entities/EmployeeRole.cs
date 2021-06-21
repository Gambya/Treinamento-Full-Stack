using System;
using System.Collections.Generic;
using System.Text;

namespace Avanade.SubTCSE.Projeto.Domain.Aggregates.EmployeeRole.Entities
{
    public record EmployeeRole
    {
        public EmployeeRole(int id, string roleName)
        {
            Id = id;
            RoleName = roleName;
        }

        public int Id { get; init; }
        public string RoleName { get; init; }
    }
}
