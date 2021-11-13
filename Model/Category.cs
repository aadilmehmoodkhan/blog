using System;
using System.ComponentModel.DataAnnotations;

namespace blogs.Model {
    public class Category {
        public int Id { get; set; }
        
        [Required, StringLength(30)]
        public string? Name { get; set; }

        [StringLength(500)]
        public string? Description { get; set; }

        public bool Active { get; set; }

        public DateTime CreatedOn { get; set; }

        public int LikeCount { get; set; }

        public SeoPageAttributes? SeoAttributes { get; set; }
    }
}