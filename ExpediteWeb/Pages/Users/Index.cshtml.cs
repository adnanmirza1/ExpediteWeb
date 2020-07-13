using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ExpediteWeb.Data;
using ExpediteWeb.Models;

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

        public async Task OnGetAsync()
        {
            User = await _context.User.ToListAsync();
        }
    }
}
