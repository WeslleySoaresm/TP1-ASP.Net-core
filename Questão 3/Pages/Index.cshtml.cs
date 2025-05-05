using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;

namespace CalculoAreaFuncWeb.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public double BaseRetangulo { get; set; }

        [BindProperty]
        public double AlturaRetangulo { get; set; }

        public double Area { get; set; }

        public void OnPost()
        {
            // Func para calcular a área
            Func<double, double, double> calcularArea = (baseR, altura) => baseR * altura;

            // Calcula a área
            Area = calcularArea(BaseRetangulo, AlturaRetangulo);
        }
    }
}
