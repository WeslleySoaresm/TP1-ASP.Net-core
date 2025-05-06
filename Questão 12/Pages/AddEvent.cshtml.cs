using _25E2_4_TP1_Console.Models;
using _25E2_4_TP1_Console.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace _25E2_4_TP1_Console.Pages
{
    public class AddEventModel : PageModel
    {
        private readonly EventService _eventService;

        // Propriedades para o bind no formulário
        [BindProperty]
        public string Title { get; set; }

        [BindProperty]
        public DateTime Date { get; set; }

        [BindProperty]
        public string Location { get; set; }

        public AddEventModel(EventService eventService)
        {
            _eventService = eventService;
        }

        // Método que é chamado quando o formulário é submetido
        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                // Cria o evento
                _eventService.CreateEvent(Title, Date, Location);
                return RedirectToPage("/Index"); // Redireciona para a página inicial
            }

            return Page();
        }

        // Método para exibir o evento no console quando ele é criado
        public static void RegisterEventCreation(Event newEvent)
        {
            Console.WriteLine($"Novo evento criado: {newEvent.Title} - {newEvent.Date} - {newEvent.Location}");
        }
    }
}
