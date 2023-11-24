using AutoMapper;
using EmployeeManagement.Business.Interfaces;
using EmployeeManagement.Business.Models;
using EmployeeManagement.Core.Interfaces;
using EmployeeManagement.Core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Business.Services
{
    public class UserService:IUserService
    {
        private IUserRepository _userRepository;
        private IMapper _mapper;

        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            this._userRepository = userRepository;
            this._mapper = mapper;
        }

        public async Task<IEnumerable<User>> GetUsersByRole()
        {
            var result = await _userRepository.GetUsersByRole();

            var userInfo = _mapper.Map<IEnumerable<User>>(result);

            return userInfo;
        }

        public async Task<IEnumerable<User>> GetUsersWithNoRole()
        {
            var result = await _userRepository.GetUsersWithNoRole();

            var userInfo = _mapper.Map<IEnumerable<User>>(result);

            return userInfo;
        }
    }
}
