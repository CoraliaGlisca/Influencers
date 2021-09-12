using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Influencers.Models.Model
{
    public partial class Article
    {
        public Article()
        {
            ArticleTags = new HashSet<ArticleTags>();
            Comments = new HashSet<Comments>();
        }

        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("AuthorID")]
        public int AuthorId { get; set; }
        [Required]
        [StringLength(255)]
        public string Title { get; set; }
        [Required]
        public string Content { get; set; }
        [Column(TypeName = "date")]
        public DateTime Date { get; set; }
        public string Image { get; set; }

        [Column("Votes")]
        public int? Votes { get; set; }

        [ForeignKey(nameof(AuthorId))]
        [InverseProperty("Article")]
        public virtual Author Author { get; set; }
        [InverseProperty("Article")]
        public virtual ICollection<ArticleTags> ArticleTags { get; set; }
        [InverseProperty("Article")]
        public virtual ICollection<Comments> Comments { get; set; }
        public void AddVote(int votes)
        {
            if (Votes == null)
            {
                Votes = 0;
            }
            Votes += votes;
        }
    }
}
