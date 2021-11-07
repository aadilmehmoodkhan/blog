using System;
using System.ComponentModel.DataAnnotations;

namespace blogs.Model {
    public class Comment {
        public long Id { get; set; }

        [Required, StringLength(300)]
        public string PosterEmail { get; set; }

        [Required, StringLength(100)]
        public string PosterName { get; set; }

        [Required, StringLength(4000)]
        public string CommentText { get; set; }

        [Required]
        public DateTime PostedOn { get; set; }

        [Required]
        public bool Moderated { get; set; }
    }
}