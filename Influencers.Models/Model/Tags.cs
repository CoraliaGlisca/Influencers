using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Influencers.Models.Model
{
    public partial class Tags
    {
        public Tags()
        {
            ArticleTags = new HashSet<ArticleTags>();
        }

        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [InverseProperty("Tags")]
        public virtual ICollection<ArticleTags> ArticleTags { get; set; }
    }
}
