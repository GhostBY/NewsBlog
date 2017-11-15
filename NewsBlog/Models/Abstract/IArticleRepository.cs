﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NewsBlog.Models.Entities;

namespace NewsBlog.Models.Abstract
{
    public interface IArticleRepository
    {
        IQueryable<Article> GetAll();
        Article Find(int Id);
    }
}
