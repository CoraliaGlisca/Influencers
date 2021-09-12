using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Influencers.Models.Model
{
    public partial class Author
    {
        public Author()
        {
            Article = new HashSet<Article>();
        }

        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string NickName { get; set; }
        [StringLength(255)]
        public string FirstName { get; set; }
        [StringLength(255)]
        public string LastName { get; set; }
        [Required]
        [StringLength(255)]
        public string Email { get; set; }
        public int? Votes { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }

        [InverseProperty("Author")]
        public virtual ICollection<Article> Article { get; set; }

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
