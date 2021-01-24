using Core.Entities;
using Core.Interfaces.Repositories;
using Repository.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        MentoriaContext _context;

        public UserRepository(MentoriaContext context) : base(context)
        {
            _context = context;
        }
    }
}
