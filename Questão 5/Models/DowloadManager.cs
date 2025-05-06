using System;
using System.Threading;

namespace WebDownloadNotification.Models
{
    public class DownloadManager
    {
        public delegate void DownloadCompletedHandler();
        public event DownloadCompletedHandler? DownloadCompleted;

        public string Mensagem { get; private set; } = "";

        public void IniciarDownload()
        {
            // Simula o tempo de download (3 segundos)
            Thread.Sleep(3000);

            // Dispara o evento
            DownloadCompleted?.Invoke();
        }

        public void AoConcluir()
        {
            Mensagem = "✅ Download concluído com sucesso!";
        }
    }
}
