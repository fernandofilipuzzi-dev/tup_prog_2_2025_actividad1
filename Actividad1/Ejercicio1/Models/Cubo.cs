
using Ejercicio1.Models;
using System.Globalization;

namespace Ejercicio1.Models;

public class Cubo
{
    protected Cuadrado[] caras { get; set; }
   
    public Cubo(double lado)
    {
        caras = new Cuadrado[6];
        for (int n = 0; n < caras.Length; n++)
        {
            caras[n] = new Cuadrado(lado);
        }
    }

    public double CalcularArea()
    {
        double area = 4*caras[0].CalcularArea();

        return area;
    }

    public double CalcularVolumen()
    {
        double lado = caras[0].Ancho;
        return Math.Pow(lado,3);
    }

    public string Describir()
    {
        var culture = CultureInfo.InvariantCulture;

        string lateralesDescripcion = "";
        for (int n = 0; n < 6; n++)
        {
            lateralesDescripcion += caras[n].Describir() + ", \n";
        }

        string descripcion = @$"{{  
  ""Tipo"": ""Cubo"", 
  ""Caras"": 
  [
    {lateralesDescripcion}
  ],  
  ""Area"": {CalcularArea().ToString("f2", culture)},
  ""Volumen"": {CalcularVolumen().ToString("f2", culture)}
}}";
        return descripcion;
    }
}
