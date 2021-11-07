using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using blogs.Data;
using blogs.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace blogs.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly SiteDbContext context;

        public IndexModel(ILogger<IndexModel> logger, SiteDbContext context)
        {
            _logger = logger;
            this.context = context;
        }

        public IList<Category> Categories { get; private set; }

        public void OnGet()
        {
            Categories = context.Categories.ToList();
        }
    }
}
