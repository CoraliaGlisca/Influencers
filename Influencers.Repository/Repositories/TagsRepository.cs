using Influencers.Models.Model;
using Influencers.Repository.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Influencers.Repository.Repositories
{
    public class TagsRepository : BaseRepository<Tags>, ITagsRepository
    {
        public TagsRepository(InfluencersDbContext dbContext) : base(dbContext)
        {

        }
        //public List<Tags> GetTagsByArticleTags(ArticleTags articleTags)
        //{
        //    return dbContext.Tags.Where(a => a.ArticleTags == articleTags).ToList();
        //}

        public string GetTagsNameByTagsId(int id)
        {
            return dbContext.Tags.FirstOrDefault(x => x.Id == id).Name;
        }

        public bool CheckIfTagExists(string Name)
        {
            var dbEntry = dbContext.Tags.FirstOrDefault(x => x.Name == Name);

            if (dbEntry != null)
                return true;
            return false;
        }

        public int GetTagIdByName(string Name)
        {
            //var tags = dbContext.Tags.ToList();
            var dbEntry = dbContext.Tags.FirstOrDefault(x => x.Name == Name);

            //return dbEntry.Id;
            if (dbEntry == null)
                return -1;
            return dbEntry.Id;
        }

        public List<Tags> GetAllTagsByNames(string Name)
        {
            return dbContext.Tags.Where(x => x.Name == Name).ToList();
        }
    }
}
