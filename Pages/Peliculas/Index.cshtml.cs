using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RP_PELICULAS.Data;
using RP_PELICULAS.Modelos;

namespace RP_PELICULAS.Pages.Peliculas
{
    public class IndexModel : PageModel
    {
        private readonly RP_PELICULAS.Data.RP_PELICULASContext _context;

        public IndexModel(RP_PELICULAS.Data.RP_PELICULASContext context)
        {
            _context = context;
        }

        public IList<Pelicula> Pelicula { get;set; }

        public async Task OnGetAsync()
        {
            Pelicula = await _context.Pelicula.ToListAsync();
        }
    }
}
