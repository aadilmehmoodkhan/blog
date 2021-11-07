using System;
using System.ComponentModel.DataAnnotations;

namespace blogs.Model {
    public class SeoPageAttributes {
        public long Id { get; set; }
        
        [Required, StringLength(300)]
        public string Sludge { get; set; }

        [StringLength(1000)]
        public string Keywords { get; set; }
        
        [StringLength(1000)]
        public string Description { get; set; }
    }
}