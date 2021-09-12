using Influencers.Models.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Influencers.Repository.Abstractions
{
    public interface IAuthorRepository : IRepository<Author>
    {
        string GetNicknameById(int id);  

        bool CheckIfAuthorExists(string Email);

        int GetAuthorIdByEmail(string Email);

        Author GetAuthorById(int id);

        int GetAuthorIdByArticleId(int id);

        string GetAuthorEmailByAuthorId(int id);

        Author UploadAuthorFile(int id);
    }
}
