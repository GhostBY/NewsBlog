using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NewsBlog.Models.Abstract;
using NewsBlog.Models.Entities;
using NewsBlog.Models.Context;

namespace NewsBlog.Models.Concrete
{
    public class ArticleRepository : IArticleRepository
    {
        List<Article> Articles = new List<Article>();
          ApplicationContext context = new ApplicationContext();
        public ArticleRepository(ApplicationContext context)
        {
            this.context = context;
        }
        public Article Find(int Id)
        {
            Article article = Articles.Where(p=>p.Id==Id).SingleOrDefault();
            //if(article!=null)
            //{
            //    return article;
            //}
            return article;
        }

        public IEnumerable<Article> GetAll()
        {
            return context.Articles.ToList();
        }
    }
}
