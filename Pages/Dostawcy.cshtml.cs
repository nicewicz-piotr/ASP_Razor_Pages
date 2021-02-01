using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using CS7;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace NorthwindWeb.Pages
{
    public class DostawcyModel : PageModel
    {
        private Northwind db;

        [BindProperty]
        public Supplier Dostawca { get; set; }

        public DostawcyModel(Northwind wstrzyknietyKontekst)
        {
            db = wstrzyknietyKontekst;
        }
        public IEnumerable<string> Dostawcy { get; set; }

        public async Task<IActionResult> OnPost()
        {
            if(ModelState.IsValid)
            {
                db.Suppliers.Add(Dostawca);
                await db.SaveChangesAsync();
                return RedirectToPage("/dostawcy");
            }

            return Page();
        }

        public void OnGet()
        {
            //Dostawcy = new[] { "Alpha Co", "Beta Limited", "Gamma Corp"};
            Dostawcy = db.Suppliers.Select(s => s.CompanyName).ToArray();
            ViewData["Tytul"] = "Witryna WWW firmy Northwind - Dostawcy";
        }
    }
}