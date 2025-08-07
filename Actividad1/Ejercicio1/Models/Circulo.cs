
using System.Globalization;

namespace Ejercicio1.Models;

public class Circulo
{
    public double Radio { get; set; }

    public Circulo(double radio)
    {
        Radio = radio;
    }

    public double CalcularArea()
    {
        return Math.PI*Math.Pow(Radio,2);
    }

    public string Describir()
    {
        var culture = CultureInfo.InvariantCulture;

        return @$"{{  
  ""Tipo"":""Circulo"", 
  ""Radio"": {Radio.ToString("f2", culture)}, 
  ""Area"": {CalcularArea().ToString("f2", culture)}
}}";
    }
}
