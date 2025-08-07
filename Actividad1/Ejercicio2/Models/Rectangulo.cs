using System.Globalization;

namespace Ejercicio2.Models;

public class Rectangulo:FiguraPlana
{
    public double Largo { get; set; }
    public double Ancho { get; set; }

    public Rectangulo(double ancho, double largo)
    {
        Largo = largo;
        Ancho = ancho;
    }
    override public double CalcularArea()
    {
        return Largo * Ancho;
    }

    public override string Describir()
    {
        var culture = CultureInfo.InvariantCulture;

        return @$"
{{ 
  ""Tipo"": ""Rectangulo"", 
  ""Largo"": {Largo.ToString("f2", culture)}, 
  ""Ancho"": {Ancho.ToString("f2", culture)}, 
  ""Area"": {CalcularArea().ToString("f2", culture)}
}}";
    }
}
