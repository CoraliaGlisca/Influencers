using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Influencers.Models.Model
{
    public partial class ArticleTags
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("ArticleID")]
        public int ArticleId { get; set; }
        [Column("TagsID")]
        public int TagsId { get; set; }

        [ForeignKey(nameof(ArticleId))]
        [InverseProperty("ArticleTags")]
        public virtual Article Article { get; set; }
        [ForeignKey(nameof(TagsId))]
        [InverseProperty("ArticleTags")]
        public virtual Tags Tags { get; set; }
    }
}
