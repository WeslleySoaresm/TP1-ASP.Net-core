using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebMonitoramentoTemperatura.Models;

namespace WebMonitoramentoTemperatura.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public double Temperatura { get; set; }

        public string? Resultado { get; set; }

        public void OnPost()
        {
            var sensor = new TemperatureSensor();

            // Inscreve o manipulador no evento
            sensor.TemperatureExceeded += sensor.AoExceder;

            // Verifica a temperatura (pode disparar o evento)
            sensor.Verificar(Temperatura);

            // Obtém o resultado definido
            Resultado = sensor.Resultado;
        }
    }
}
