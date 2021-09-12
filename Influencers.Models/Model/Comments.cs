using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Influencers.Models.Model
{
    public partial class Comments
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public int ArticleId { get; set; }

        [ForeignKey(nameof(ArticleId))]
        [InverseProperty("Comments")]
        public virtual Article Article { get; set; }
    }
}
