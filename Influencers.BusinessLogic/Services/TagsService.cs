using Influencers.Models.Model;
using Influencers.Repository.Abstractions;
using Influencers.Repository.Repositories;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Influencers.BusinessLogic.Services
{
    public class TagsService
    {
        private ITagsRepository tagsRepository;
        private IArticleTags articleTagsRepository;

        public TagsService(ITagsRepository tagsRepository, IArticleTags articleTagsRepository)
        {
            this.tagsRepository = tagsRepository;
            this.articleTagsRepository = articleTagsRepository;
        }

        public string GetAllTags(int id)
        {
            List<ArticleTags> articleTags = articleTagsRepository.GetAllTagsByArticleId(id);
            List<int> tagsId = new List<int>();
            string tagNames = "";

            foreach(var tag in articleTags)
            {
                tagsId.Add((int)tag.TagsId);
            }
            foreach (var tagId in tagsId)
            {
                tagNames = tagNames + " " + tagsRepository.GetTagsNameByTagsId(tagId);
            }
            return tagNames;
        }
        public List<Tags> GetAllTagsByNames(string name)
        {
            return tagsRepository.GetAllTagsByNames(name);
        }
        public int GetTagIdByName(string Name)
        {
            return tagsRepository.GetTagIdByName(Name);
        }

        public bool CheckIfTagExists(string Name)
        {
            return tagsRepository.CheckIfTagExists(Name);
        }

        public void AddArticleTags(int tagId, int articleId)
        {
            articleTagsRepository.Add(new ArticleTags
            {
                TagsId = tagId,
                ArticleId = articleId
            });
        }
        
        public void AddTag(string tagName)
        {
            tagsRepository.Add(new Tags
            {
                Name = tagName
            });
        }

        public void UpdateArticleTags(ArticleTags articleTags)
        {
            articleTagsRepository.Update(articleTags);
        }
        public void UpdateTags(Tags tags)
        {
            tagsRepository.Update(tags);
        }

        public ArticleTags GetArticleTagsByTagId(int tagId)
        {
            return articleTagsRepository.GetArticleTagsById(tagId);
        }
    }
}
                              
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 