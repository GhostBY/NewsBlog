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

        public void Create(Article article)
        {
            context.Articles.Add(article);
            context.SaveChanges();
        }

        public Article Find(int Id)
        {
            Articles = context.Articles.ToList();
            Article article = Articles.Where(p=>p.Id==Id).SingleOrDefault();
            //if(article!=null)
            //{
            //    return article;
            //}
            return article;
        }

        public IQueryable<Article> GetAll()
        {
            return context.Articles;
        }

        public void Remove(int Id)
        {
            throw new NotImplementedException();
        }

        public void Update(Article article)
        {
            throw new NotImplementedException();
        }
    }
}
