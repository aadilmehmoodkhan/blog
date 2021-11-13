using System;
using System.ComponentModel.DataAnnotations;

namespace blogs.Model {
    public class Content {
        public long Id { get; set; }

        [Required, StringLength(4000)]
        public string? TextContent { get; set; }

        [Required]
        public int Order { get; set; }
    }
}