using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ExpediteWeb.Data;
using ExpediteWeb.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ExpediteWeb.Pages.Users
{
    public class IndexModel : PageModel
    {
        private readonly ExpediteWeb.Data.ExpediteWebContext _context;

        public IndexModel(ExpediteWeb.Data.ExpediteWebContext context)
        {
            _context = context;
        }

        public IList<User> User { get;set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        // Requires using Microsoft.AspNetCore.Mvc.Rendering;
        public SelectList Name { get; set; }
        [BindProperty(SupportsGet = true)]
        public string Role { get; set; }

        public async Task OnGetAsync()
        {
         


            var users = from m in _context.User
                         select m;
            if (!string.IsNullOrEmpty(SearchString))
            {
                users = users.Where(s => s.Name.Contains(SearchString));
            }
           

            User = await users.ToListAsync();
        }
    }
}
