﻿using SenaiApi.Repository.Contexts;
using SenaiApi.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenaiApi.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {

        private ApiContext _context;

        public GenericRepository(ApiContext context)
        {
            _context = context;
        }

        public IQueryable<T> GetAll()
        {
            return _context.Set<T>();
        }
    }
}
