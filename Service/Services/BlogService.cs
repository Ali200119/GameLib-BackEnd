﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Models;
using Repository.Repositories.Interfaces;
using Service.Services.Interfaces;

namespace Service.Services
{
    public class BlogService : IBlogService
    {
        private readonly IBlogRepository _blogRepo;

        public BlogService(IBlogRepository blogRepo)
        {
            _blogRepo = blogRepo;
        }



        public async Task<IEnumerable<Blog>> GetAllWithIncludesAsync() => await _blogRepo.GetAllAsync(b => b.BlogImages, b => b.BlogAuthor);
        
        public async Task<Blog> GetByIdWithIncludesAsync(int? id) => await _blogRepo.GetByIdAsync(id, b => b.BlogImages, b => b.BlogAuthor);
    }
}