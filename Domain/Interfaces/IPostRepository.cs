﻿using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IPostRepository
    {
        //git test
        //git test 2
        IEnumerable<Post> GetAll();
        IEnumerable<Post> GetPostsByTitle(string title);
        Post GetById(int id);
        Post Add(Post post);
        void Update(Post post);
        void Delete(Post post);
                    
    }
}
