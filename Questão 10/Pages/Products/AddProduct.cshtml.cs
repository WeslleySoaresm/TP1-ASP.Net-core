using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProductCatalog.Models;
namespace ProductCatalog.Pages.Products
{
    public class AddProductModel : PageModel
    {
        [BindProperty]
        public Product? Product { get; set; }

        public void OnGet() { }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
                return Page();

            // Apenas retorna a página com os dados exibidos
            return Page();
        }
    };
}
