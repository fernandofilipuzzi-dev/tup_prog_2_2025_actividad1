
using System.Globalization;

namespace Ejercicio1.Models;

public class RectanguloDesarrollado
{
    public double Largo { get; set; }
    public double Ancho { get; set; }

    public RectanguloDesarrollado(double radio, double altura)
    {
        Ancho = 2 * Math.PI * radio;
        Largo = altura;
    }
    public double CalcularArea()
    {
        return Largo * Ancho;
    }

    public string Describir()
    {
        var culture = CultureInfo.InvariantCulture;

        return @$"
{{ 
  ""Tipo"": ""RectanguloDesarrollado"", 
  ""Lago"": {Largo.ToString("f2", culture)}, 
  ""Ancho"": {Ancho.ToString("f2", culture)}, 
  ""Area"": {CalcularArea().ToString("f2", culture)}
}}";
    }
}
