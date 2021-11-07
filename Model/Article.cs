using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace blogs.Model {
    public class Article {
        public long Id { get; set; }

        [Required, StringLength(500)]
        public string Title { get; set; }

        [Required, StringLength(2000)]
        public string Description { get; set; }

        public bool Active { get; set; }

        public DateTime CreatedOn { get; set; }

        public SeoPageAttributes SeoAttributes { get; set; }

        public IList<Content> ContentItems { get; set; }

        public IList<Comment> Comments { get; set; }
    }
}