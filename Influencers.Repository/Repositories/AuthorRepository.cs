using Influencers.Models.Model;
using Influencers.Repository.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Influencers.Repository.Repositories
{
    public class AuthorRepository : BaseRepository<Author>, IAuthorRepository
    {
        public AuthorRepository(InfluencersDbContext dbContext) : base(dbContext)
        {

        }

        public bool CheckIfAuthorExists(string Email)
        {
            var dbEntry = dbContext.Author.FirstOrDefault(x => x.Email == Email);

            if (dbEntry != null)
                return true;
            return false;
        }

        public int GetAuthorIdByArticleId(int id)
        {
            var dbEntry = dbContext.Article.Where(x => x.Id == id).SingleOrDefault();
            return dbEntry.AuthorId;

        }

        public Author GetAuthorById(int id)
        {
            return dbContext.Author.FirstOrDefault(x => x.Id == id);
        }

        public int GetAuthorIdByEmail(string Email)
        {
            var dbEntry = dbContext.Author.Where(x => x.Email == Email).FirstOrDefault();
            //return dbContext.Author.Where(x => x.Email == Email).FirstOrDefault();
            if(dbEntry == null)
            {
                return -1;
            }

            return dbEntry.Id;
        }

        public string GetNicknameById(int id)
        {
            return dbContext.Author.SingleOrDefault(n => n.Id == id).NickName.ToString();
        }

        public string GetAuthorEmailByAuthorId(int id)
        {
            return dbContext.Author.FirstOrDefault( x => x.Id == id).Email;
        }

        public Author UploadAuthorFile(int id)
        {
            return dbContext.Author.FirstOrDefault(x => x.Id == id);
        }
    }
}
