using System;

public class SuporteVida
{
    private double nivelOxigenio;
    private double nivelCO2;
    private double temperatura;

    public SuporteVida(double o2, double co2, double temp)
    {
        nivelOxigenio = o2;
        nivelCO2 = co2;
        temperatura = temp;
    }

    public string MonitorarAmbiente()
    {
        string status = "";
        status += nivelOxigenio < 19.5 ? "ALERTA: Oxigênio crítico!\n" : $"Oxigênio OK: {nivelOxigenio}%\n";
        status += nivelCO2 > 0.5 ? "ALERTA: CO2 alto!\n" : $"CO2 OK: {nivelCO2}%\n";
        status += (temperatura < 18 || temperatura > 27) ? "ALERTA: Temperatura fora do limite!\n" : $"Temperatura OK: {temperatura}°C\n";
        return status;
    }

    public static void Main(string[] args)
    {
        SuporteVida modulo = new SuporteVida(20.9, 0.3, 22.5);
        Console.WriteLine(modulo.MonitorarAmbiente());
    }
}