
using System.Globalization;

namespace Ejercicio2.Models;

public class Circulo:FiguraPlana
{
    public double Radio { get; set; }

    public Circulo(double radio)
    {
        Radio = radio;
    }

    override public double CalcularArea()
    {
        return Math.PI*Math.Pow(Radio,2);
    }

    public override string Describir()
    {
        var culture = CultureInfo.InvariantCulture;

        return @$"{{  
  ""Tipo"":""Circulo"", 
  ""Radio"": {Radio.ToString("f2", culture)}, 
  ""Area"": {CalcularArea().ToString("f2", culture)}
}}";
    }
}
