using Influencers.Models.Model;
using Influencers.Repository.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Influencers.BusinessLogic.Services
{
    public class CommentsService
    {
        private ICommentsRepository _commentsRepository;

        public CommentsService(ICommentsRepository commentsRepository)
        {
            _commentsRepository = commentsRepository;
        }

        public List<Comments> GetCommentsByArticleId(int id)
        {
            return _commentsRepository.GetCommentsByArticleId(id);
        }

        public void AddComments(string name, int articleId)
        {
            _commentsRepository.Add(new Comments()
            {
                Name = name,
                ArticleId = articleId
            });
        }

        public string GetCommentByArticleId(int id)
        {
            return _commentsRepository.GetCommentByArticleId(id);
        }

    }
}
