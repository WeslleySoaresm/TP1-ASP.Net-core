using System;

namespace WebMonitoramentoTemperatura.Models
{
    public class TemperatureSensor
    {
        public delegate void TemperatureExceededHandler(double temperatura);
        public event TemperatureExceededHandler? TemperatureExceeded;

        public string Resultado { get; private set; } = string.Empty;

        public void Verificar(double temperatura)
        {
            if (temperatura > 100)
            {
                TemperatureExceeded?.Invoke(temperatura);
            }
            else
            {
                Resultado = $"Temperatura normal: {temperatura}°C";
            }
        }

        public void AoExceder(double temperatura)
        {
            Resultado = $"⚠️ ALERTA: Temperatura excedida! Valor: {temperatura}°C";
        }
    }
}
