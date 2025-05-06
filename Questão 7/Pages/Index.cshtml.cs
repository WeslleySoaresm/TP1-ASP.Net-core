using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebLogger.Models;

namespace WebLogger.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public bool RegistrarLogs { get; set; }

        public string? LogResultado { get; set; }

        public void OnPost()
        {
            var logger = new Logger();

            Action<string>? logDelegate = null;

            if (RegistrarLogs)
            {
                // Multicast delegate com métodos
                logDelegate = logger.LogToConsole;
                logDelegate += logger.LogToFile;
                logDelegate += logger.LogToDatabase;
            }

            // Invocação segura
            logDelegate?.Invoke("Evento registrado com segurança.");

            LogResultado = logger.Resultado;
            if (!RegistrarLogs)
            {
                LogResultado = "⚠️ Nenhum método estava associado ao delegate. Nenhuma ação foi executada.";
            }
        }
    }
}
