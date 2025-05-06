using _25E2_4_TP1_Console.Models;

namespace _25E2_4_TP1_Console.Services
{
    public class EventService
    {
        // Delegate que será acionado quando um evento for criado
        public static event Action<Event>? OnEventCreated;

        // Método para criar um novo evento
        public void CreateEvent(string title, DateTime date, string location)
        {
            var newEvent = new Event
            {
                Title = title,
                Date = date,
                Location = location
            };

            // Dispara o evento para registrar a criação
            OnEventCreated?.Invoke(newEvent);
        }
    }
}
