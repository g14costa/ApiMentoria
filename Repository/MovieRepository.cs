using Core.Entities;
using Core.Interfaces.Repositories;
using Repository.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository
{
    public class MovieRepository : GenericRepository<Movie>, IMovieRepository
    {
        private readonly MentoriaContext _context;

        public MovieRepository(MentoriaContext context) : base(context)
        {
            _context = context;
        }
    }
}
