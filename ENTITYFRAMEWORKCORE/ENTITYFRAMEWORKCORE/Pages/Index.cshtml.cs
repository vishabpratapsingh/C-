﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ENTITYFRAMEWORKCORE.Models;

namespace ENTITYFRAMEWORKCORE.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ENTITYFRAMEWORKCORE.Models.DataContext _context;

        public IndexModel(ENTITYFRAMEWORKCORE.Models.DataContext context)
        {
            _context = context;
        }

        public IList<Product> Product { get;set; }

        public async Task OnGetAsync()
        {
            Product = await _context.Product.ToListAsync();
        }
    }
}
