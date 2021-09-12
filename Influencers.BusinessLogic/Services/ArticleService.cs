using Influencers.Models.Model;
using Influencers.Repository.Abstractions;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Influencers.BusinessLogic.Services
{
    public class ArticleService
    {
        private IArticleRepository articleRepository;
        private IArticleTags articleTagsRepository;
        private ITagsRepository tagsRepository;

        public ArticleService(IArticleRepository articleRepository, IArticleTags articleTags, ITagsRepository tagsRepository)
        {
            this.articleRepository = articleRepository;
            this.articleTagsRepository = articleTags;
            this.tagsRepository = tagsRepository;
        }

        public List<Article> getAllArticles()
        {
            List<Article> articleList = articleRepository.GetAllArticles();
            return articleList;
        }

        public IEnumerable<Article> GetAllArticles()
        {
            return articleRepository.GetAll();
        }

        public Article GetArticleById(int id)
        {
            return articleRepository.GetArticleById(id);
        }

        public Article AddArticle(int id, string Title, string Content, int AuthorId)
        {
            var art = articleRepository.Add(new Article()
            {
                //Id = id,
                Title = Title,
                Content = Content,
                Date = DateTime.Now,
                AuthorId = AuthorId,
                //Image = image
            }) ;
            return art;            

        }

        public Article UpdateArticle(Article article)
        {
            return articleRepository.Update(article);
        }
        //public Article UpdateArticleVotes(Article article, int votes)
        //{
        //    article.Votes += votes;
        //    return articleRepository.Update(article);
        //}
        public void AddArticleVote(int articleId, int votes)
        {
            var article = articleRepository.GetArticleById(articleId);
            article.AddVote(votes);
            articleRepository.Update(article);
        }

        public int GetArticleIdByTitle(string title)
        {
            return articleRepository.GetArticleIdByTitle(title);
        }

        public int GetArticleIdByAuthorId(int id)
        {
            return articleRepository.GetArticleIdByAuthorId(id);
        }

        public List<Article> GetArticlesByTags(string tagName)
        {
            int tagId = tagsRepository.GetTagIdByName(tagName);
            List<Article> articles = new List<Article>();
            
             List<ArticleTags> articleTags = articleTagsRepository.GetArticleIdByTagId(tagId);            
            
            foreach(var articleTag in articleTags)
            {
                articles.Add(articleRepository.GetArticleById(articleTag.ArticleId));
            }           
            
            return articles;
        }
        public void UploadFile(IFormFile file, int id)
        {
            var fileName = file.FileName;
            var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images", fileName);
            using (var fileStream = new FileStream(path, FileMode.Create))
            {
                file.CopyTo(fileStream);
            }
            var article = articleRepository.UploadArticleFile(id);
            article.Image = fileName;
            articleRepository.Update(article);
        }
    }
}
