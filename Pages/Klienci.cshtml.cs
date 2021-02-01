using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using CS7;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace NorthwindWeb.Pages
{
    public class CustomersViewModel
    {
        public string CustomersIDs { get; set; }
        public string CustomersTites { get; set; }
    }

    public class KlienciModel : PageModel
    {
        private Northwind db;

        [BindProperty]
        public Customer Klient { get; set; }

        public KlienciModel(Northwind wstrzyknietyKontekst)
        {
            db = wstrzyknietyKontekst;
        }
        public IEnumerable<CustomersViewModel> Klienci { get; set; }
        
        public async Task<IActionResult> OnPost()
        {
            if(ModelState.IsValid)
            {
                db.Customers.Add(Klient);
                await db.SaveChangesAsync();
                return RedirectToPage("/klienci");
            }

            return Page();
        }
        
        public void OnGet()
        {
            //Klienci = new[] { "XXX", "YYY", "ZZZ"};
            Klienci = db.Customers.OrderBy(p => p.Country).Select(s => new CustomersViewModel { CustomersTites = s.ContactTitle, CustomersIDs = s.CustomerID }).ToArray();
            ViewData["Tytul"] = "Witryna WWW firmy Northwind - Klienci";
        }
    }
}