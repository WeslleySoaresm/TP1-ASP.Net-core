using Microsoft.AspNetCore.Mvc.RazorPages;
using DescontoDelegateApp.Services; // Importa a classe

namespace DescontoDelegateApp.Pages
{
    public class IndexModel : PageModel
    {
        public decimal PrecoOriginal { get; set; }
        public decimal PrecoComDesconto { get; set; }

        public void OnPost(decimal preco)
        {
            // Usa o delegate
            CalculateDiscount desconto = new CalculateDiscount(DescontoService.Aplicar10PorCento);
            PrecoOriginal = preco;
            PrecoComDesconto = desconto(preco);
        }
    }
}
