using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Infrastructure.Interfaces
{
    public interface IRepository
    {
        Task<IEnumerable<TEntity>> GetAllAsync<TEntity>(string ptocedureName, object parameters = null);
    }
}
