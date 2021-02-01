using Microsoft.AspNetCore.Mvc.RazorPages;
using CS7;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace NorthwindWeb.Pages
{

    public class KlientModel : PageModel
    {
        private Northwind db;

        [BindProperty]
        public Customer Klient { get; set; }

        public KlientModel(Northwind wstrzyknietyKontekst)
        {
            db = wstrzyknietyKontekst;
        }
        
        
        public async Task<IActionResult> OnGet(string id)
        {
            if(id == null)
            {
                return StatusCode(400);
            }

            Klient = await db.Customers
                    .Where(s => s.CustomerID == id)
                    .Include(c => c.Orders)
                    .ThenInclude(s => s.Shipper)
                    .FirstOrDefaultAsync();

            if (Klient == null)
            {
                return StatusCode(400);
            }

            ViewData["Tytul"] = $"Witryna WWW firmy Northwind - Klient nr {id}";

            return  Page();
        }
    }
}