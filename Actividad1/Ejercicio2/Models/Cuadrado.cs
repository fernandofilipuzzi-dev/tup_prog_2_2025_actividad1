
using System.Globalization;

namespace Ejercicio2.Models;

public class Cuadrado: Rectangulo
{
    public Cuadrado(double lado):base(lado,lado)
    {
    }

    public override string Describir()
    {
        var culture = CultureInfo.InvariantCulture;

        return @$"{{ 
  ""Tipo"":""Cuadrado"", 
  ""Largo"": {Largo.ToString("f2", culture)}, 
  ""Ancho"": {Ancho.ToString("f2", culture)}, 
  ""Area"": {CalcularArea().ToString("f2", culture)}
}}";
    }
}