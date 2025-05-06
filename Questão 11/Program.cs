
namespace TP1_ASP.NET_CORE.Exercicio11;

public class DelEnc
{
    public Func<string, string, string> ConcatenacaoNome = (nome, sobrenome) =>
    {
        string concatenado = $"{nome} {sobrenome}";
        concatenado = concatenado.ToUpper();
        concatenado = concatenado.Replace(" ", "");
        return concatenado;
    };



}

