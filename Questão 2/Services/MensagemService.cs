using System;
using System.Collections.Generic;

namespace MultilingueApp.Services
{
    public static class MensagemService
    {
        // Delegate Action<string> armazenado por idioma
        public static readonly Dictionary<string, Action<string>> Mensagens = new()
        {
            { "pt", nome => Mensagem = $"Olá {nome}, bem-vindo à nossa plataforma!" },
            { "en", nome => Mensagem = $"Hello {nome}, welcome to our platform!" },
            { "es", nome => Mensagem = $"¡Hola {nome}, bienvenido a nuestra plataforma!" }
        };

        public static string Mensagem { get; private set; } = string.Empty;
    }
}
