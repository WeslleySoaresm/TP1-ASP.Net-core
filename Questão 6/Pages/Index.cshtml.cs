using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebLogger.Models;

namespace WebLogger.Pages
{
    public class IndexModel : PageModel
    {
        public string? LogResultado { get; set; }

        public void OnPost()
        {
            var logger = new Logger();

            // Delegate multicast
            Action<string> logDelegate = logger.LogToConsole;
            logDelegate += logger.LogToFile;
            logDelegate += logger.LogToDatabase;

            // Dispara o log
            logDelegate("Evento importante registrado!");

            LogResultado = logger.Resultado;
        }
    }
}
