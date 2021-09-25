using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Portfolio.Data;
using Portfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.Pages
{
    public class IndexModel : PageModel
    {
        private readonly PortfolioContext _context;
        public IList<Blog> Blogs;

        [BindProperty]
        public int Counter { get; set; }

        public IndexModel(Data.PortfolioContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> OnGetAsync()
        {
           Blogs = await _context.Blog.ToListAsync();

            return Page();
        }
    }
}
