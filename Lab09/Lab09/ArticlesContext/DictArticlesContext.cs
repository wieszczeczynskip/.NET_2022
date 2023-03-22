using Lab09.ViewModels;
using System.Collections.Generic;
using System;
using System.Linq;

namespace Lab09.ArticlesContext
{
    public class DictArticlesContext : IArticlesContext
    {
        SortedDictionary<int, Article> articles = new SortedDictionary<int, Article>() { { 0, new Article(0, "Coke", 5.50, new DateTime(2022, 12, 30), Category.Drinks) }, {1, new Article(1, "Bread", 2.00, new DateTime(2022, 12, 10), Category.Food) } };
        public void AddArticle(Article article)
        {
            int nextNumber = 0;
            if (articles.Count > 0)
            {
                foreach(var x in articles)
                {
                    if (x.Value.Id >= nextNumber)
                    {
                        nextNumber = x.Value.Id + 1;
                    }
                }
            }
            article.Id = nextNumber;
            articles.Add(article.Id, article);
        }

        public Article GetArticle(int id)
        {
            Article article = null;
            foreach (var x in articles)
            {
                if (x.Value.Id == id)
                {
                    article = x.Value;
                }
            }
            return article;
        }

        public List<Article> GetArticles()
        {
            return articles.Values.ToList();
        }

        public void RemoveArticle(int id)
        {
            Article artToRemove = null;
            foreach (var x in articles)
            {
                if (x.Value.Id == id)
                {
                    artToRemove = x.Value;
                }
            }
            if (artToRemove != null)
            {
                articles.Remove(artToRemove.Id);
            }
        }

        public void UpdateArticle(Article article)
        {
            Article artToUpdate = null;
            foreach (var x in articles)
            {
                if (x.Value.Id == article.Id)
                {
                    artToUpdate = x.Value;
                }
            }
            articles[artToUpdate.Id] = article;
        }
    }
}
