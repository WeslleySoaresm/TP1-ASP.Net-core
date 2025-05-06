using EventManagementApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EventManagementApp.Pages
{
    public class AddEventModel : PageModel
    {
        [BindProperty]
        public Event Event { get; set; }

        // Delegate Action para registrar o evento no console
        public Action<Event> EventCreated;

        public AddEventModel()   
        {
            // Inicializando o delegate com um método para registrar no console
            EventCreated = RegisterEventInConsole;
        }

        public void OnPost()
        {
            // Disparar o delegate sempre que um evento for criado
            if (Event != null)
            {
                // Exibir evento no console
                EventCreated.Invoke(Event);
            }
        }

        // Método que será chamado pelo delegate
        private void RegisterEventInConsole(Event eventDetails)
        {
            Console.WriteLine($"Novo evento criado: {eventDetails.Title}, Data: {eventDetails.Date}, Local: {eventDetails.Location}");
        }
    }
}
