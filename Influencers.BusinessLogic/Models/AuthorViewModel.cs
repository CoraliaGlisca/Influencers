using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Influencers.Models
{
    public class AuthorViewModel
    {
       public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        [Display(Name ="Enter Nickname: ")]
        public string NickName { get; set; }

        [MaxLength(50)]
        [Display(Name = "Enter First Name: ")]
        public string FirstName { get; set; }

        [MaxLength(50)]
        [Display(Name = "Enter Last Name: ")]
        public string LastName { get; set; }

        [Required]
        [MaxLength(50)]
        [Display(Name = "Enter Email: ")]
        public string Email { get; set; }
        public int? Votes { get; set; }

        public string Image { get; set; }
        public string Description { get; set; }
        
    }
}
