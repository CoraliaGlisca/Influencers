using Influencers.Models.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Influencers.Repository.Abstractions
{
    public interface IArticleRepository : IRepository<Article>
    {
        Article GetArticleById(int id);

        List<Article> GetAllArticlesById(int id);

        List<Article> GetAllArticles();

        int GetArticleIdByTitle(string title);

        int GetArticleIdByAuthorId(int id);
        Article UploadArticleFile(int id);

    }
}
