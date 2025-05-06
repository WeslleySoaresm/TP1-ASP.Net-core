using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorProductApp.Models;

namespace RazorProductApp.Pages
{
    public class IndexModel : PageModel
    {
        public List<Product> Produtos { get; set; } = new();

        public void OnGet()
        {
            Produtos = new List<Product>
            {
                new Product { Name = "Notebook Dell", Price = 4500.00M },
                new Product { Name = "Smartphone Galaxy", Price = 2200.00M },
                new Product { Name = "Monitor LG", Price = 999.99M }
            };
        }
    }
}
