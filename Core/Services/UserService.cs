using Core.Entities;
using Core.Interfaces.Repositories;
using Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Services
{
    public class UserService : GenericService<User>, IUserService
    {
        IUserRepository _repository;

        public UserService(IUserRepository repository) : base (repository)
        {
            _repository = repository;
        }
    }
}
