using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebDownloadNotification.Models;

namespace WebDownloadNotification.Pages
{
    public class IndexModel : PageModel
    {
        public string? Resultado { get; set; }

        public void OnPost()
        {
            var gerente = new DownloadManager();

            // Inscreve o método no evento
            gerente.DownloadCompleted += gerente.AoConcluir;

            // Inicia o "download"
            gerente.IniciarDownload();

            // Pega a mensagem definida pelo evento
            Resultado = gerente.Mensagem;
        }
    }
}
