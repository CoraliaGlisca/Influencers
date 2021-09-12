using Influencers.Models.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Influencers.Repository.Abstractions
{
    public interface ITagsRepository: IRepository<Tags>
    {
        string GetTagsNameByTagsId(int id);

        bool CheckIfTagExists(string Name);

        int GetTagIdByName(string Name);

        List<Tags> GetAllTagsByNames(string Name);

    }
}
