using System.Collections.Generic;
using Lab09.ViewModels;

namespace Lab09.ArticlesContext
{
    public interface IArticlesContext
    {
        List<Article> GetArticles();
        Article GetArticle(int id);
        void AddArticle(Article article);
        void RemoveArticle(int id);
        void UpdateArticle(Article article);

    }
}
