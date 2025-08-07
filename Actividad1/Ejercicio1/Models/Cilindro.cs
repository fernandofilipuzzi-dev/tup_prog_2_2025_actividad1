
using System.Globalization;

namespace Ejercicio1.Models;

public class Cilindro
{
    Circulo[] tapas;
    RectanguloDesarrollado lado;

    public Cilindro(double radio, double altura) 
    {
        tapas= new Circulo[2];
        tapas[0] = new Circulo(radio);
        tapas[1] = new Circulo(radio);

        lado = new RectanguloDesarrollado(radio,altura);
    }

    public double CalcularArea()
    {
        double area = 2 * tapas[0].CalcularArea()+lado.CalcularArea();
        return area;
    }

    public double CalcularVolumen()
    {
        return tapas[0].CalcularArea() * lado.Largo;
    }

    public string Describir()
    {
        var culture = CultureInfo.InvariantCulture;

        string descripcion= @$"{{
  ""Tipo"": ""Cilindro"", 
  ""Tapas"": 
  [
    {tapas[0].Describir()}, 
    {tapas[1].Describir()}
  ],
  ""Lado"": { lado.Describir() },
  ""Area"": {CalcularArea().ToString("f2",culture)},
  ""Volumen"": {CalcularVolumen().ToString("f2", culture)}
}}";
        return descripcion;
    }
}
