using EmployeeManagement.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Collections;
using Microsoft.Extensions.Configuration;
using Dapper;

namespace EmployeeManagement.Infrastructure.Repository
{
    public class SqlRepository : IRepository
    {
        private readonly string _connectionString;

        public SqlRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("UserDBConn");
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync<TEntity>(string procedureName, object parameters = null)
        {
            using SqlConnection connection = new SqlConnection(_connectionString);
            connection.Open();

            var queryParameters = new DynamicParameters(parameters);

            var results = connection.Query<TEntity>(
                sql: procedureName,
                param: queryParameters,
                commandType: CommandType.StoredProcedure
            );

            return results;
        }

       
    }

}
