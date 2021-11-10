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
        public IList<Category>? Categories { get; private set; }

        [TempData]
        public string? Message { get; set; }

        public IndexModel(ILogger<IndexModel> logger, SiteDbContext context)
        {
            _logger = logger;
            this.context = context;
        }



        public void OnGet()
        {
            context.Database.EnsureCreated();
            Categories = context.Categories.ToList();
        }

        public async Task<IActionResult> OnPostLikeCategoryAsync() {
            if (!ModelState.IsValid) {
                return Page();
            }
            await Task.Run(() => {});
            return Page();
        }

        public async Task<IActionResult> OnPostUnlikeCategoryAsync() {
            if (!ModelState.IsValid) {
                return Page();
            }
            await Task.Run(() => {});
            return Page();
        }

    }
}
