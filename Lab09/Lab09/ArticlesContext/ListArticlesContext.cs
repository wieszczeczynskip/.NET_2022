using Lab09.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Lab09.ArticlesContext
{
    public class ListArticlesContext : IArticlesContext
    {
        List<Article> articles = new List<Article>() {
            new Article(0,"Coke",5.50,new DateTime(2022, 12, 30),Category.Drinks),
            new Article(1,"Bread",2.00,new DateTime(2022, 12, 10),Category.Food)
        };

        public void AddArticle(Article article)
        {
            int nextNumber = 0;
            if (articles.Count > 0)
            {
                nextNumber = articles.Max(s => s.Id) + 1;
            }
            article.Id = nextNumber;
            articles.Add(article);
        }

        public Article GetArticle(int id)
        {
            return articles.FirstOrDefault(s => s.Id == id);
        }

        public List<Article> GetArticles()
        {
            return articles;
        }

        public void RemoveArticle(int id)
        {
            Article artToRemove = articles.FirstOrDefault(s => s.Id == id);
            if(artToRemove != null)
            {
                articles.Remove(artToRemove);
            }
        }

        public void UpdateArticle(Article article)
        {
            //Article artToUpdate = articles.FirstOrDefault(s => s.Id == article.Id);
            articles = articles.Select(s => (s.Id == article.Id) ? article : s).ToList();
        }
    }
}
