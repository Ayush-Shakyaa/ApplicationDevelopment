using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Bislerium.Models
{
    public class Blog
    {
        [Key]
        public Guid Id { get; set; }
        public string? Content { get; set; }
        public string? Title { get; set; }

        public DateTime? Created_at { get; set; }
        public string? Image { get; set; }
        public int Like_count { get; set; }

        public int Popularity { get; set; }

        public int Dislikes_count { get; set; }
        [ForeignKey(nameof(User))]
        public string? Author { get; set; }

        public virtual AppUser? User { get; set; }

    }
}
