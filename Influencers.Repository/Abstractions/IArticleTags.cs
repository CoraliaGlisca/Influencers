using Influencers.Models.Model;
using Influencers.Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Influencers.Repository.Abstractions
{
    public interface IArticleTags : IRepository<ArticleTags>
    {
        List<ArticleTags> GetAllTagsByArticleId(int id);

        List<ArticleTags> GetArticleIdByTagId(int id);

        ArticleTags GetArticleTagsById(int id);
      
    }    
}
