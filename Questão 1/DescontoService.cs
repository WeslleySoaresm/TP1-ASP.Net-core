namespace DescontoDelegateApp.Services
{
    // Delegate personalizado
    public delegate decimal CalculateDiscount(decimal price);

    public class DescontoService
    {
        // Método compatível com o delegate
        public static decimal Aplicar10PorCento(decimal preco)
        {
            return preco * 0.90m;
        }
    }
}
