using System;
using System.IO;

namespace WebLogger.Models
{
    public class Logger
    {
        private readonly string _logPath = "log.txt";
        public string Resultado { get; private set; } = "";

        public void LogToConsole(string mensagem)
        {
            Resultado += $"🖥️ Console: {mensagem}\n";
        }

        public void LogToFile(string mensagem)
        {
            File.AppendAllText(_logPath, $"[Arquivo] {mensagem}{Environment.NewLine}");
            Resultado += $"📁 Arquivo: {mensagem}\n";
        }

        public void LogToDatabase(string mensagem)
        {
            // Simulação de log em banco de dados
            Resultado += $"🗄️ Banco de Dados: {mensagem}\n";
        }
    }
}
