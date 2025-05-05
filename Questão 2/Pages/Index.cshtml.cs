using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MultilingueApp.Services;

namespace MultilingueApp.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public string Nome { get; set; }

        [BindProperty]
        public string Idioma { get; set; }

        public string MensagemFinal { get; set; }

        public void OnPost()
        {
            // Usa a Action<string> para exibir mensagem conforme idioma
            if (MensagemService.Mensagens.TryGetValue(Idioma, out var acao))
            {
                acao(Nome); // Executa a ação
                MensagemFinal = MensagemService.Mensagem;
            }
            else
            {
                MensagemFinal = "Idioma não suportado.";
            }
        }
    }
}
