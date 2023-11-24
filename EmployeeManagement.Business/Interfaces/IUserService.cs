using EmployeeManagement.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Business.Interfaces
{
    public interface IUserService
    {
        Task<IEnumerable<User>> GetUsersByRole();
        Task<IEnumerable<User>> GetUsersWithNoRole();
    }
}
