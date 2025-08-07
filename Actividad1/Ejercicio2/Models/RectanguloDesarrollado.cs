using System.Globalization;

namespace Ejercicio2.Models;

public class RectanguloDesarrollado:Rectangulo
{
    public RectanguloDesarrollado(double radio, double altura) : base(2 * Math.PI * radio, altura)
    {
    }

    public override string Describir()
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
