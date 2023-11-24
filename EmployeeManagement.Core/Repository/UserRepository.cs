using EmployeeManagement.Core.Entities;
using EmployeeManagement.Core.Interfaces;
using EmployeeManagement.Infrastructure.Interfaces;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Core.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly string _connectionString;
        private readonly IRepository repository;

        public UserRepository(IConfiguration configuration, IRepository repository)
        {
            this._connectionString = configuration.GetConnectionString("UserDBConn");
            this.repository = repository;
        }

        public async Task<IEnumerable<UserEntity>> GetUsersByRole()
        {
            var result = await repository.GetAllAsync<UserEntity>("spGetUsersWithRole");
            return result;
        }

        public async Task<IEnumerable<UserEntity>> GetUsersWithNoRole()
        {
            var result = await repository.GetAllAsync<UserEntity>("spGetUsersWithNoRole");
            return result;
        }
    }
}
