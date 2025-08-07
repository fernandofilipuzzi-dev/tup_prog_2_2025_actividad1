using System.Globalization;

namespace Ejercicio1.Models;

public class Ortoedro
{
    protected Rectangulo[] bases { get; set; }
    protected Rectangulo[] laterales { get; set; }

    public Ortoedro(double anchoBase, double ladoComun, double largoLateral)
    {
        bases = new Rectangulo[2];
        bases[0] = new Rectangulo(anchoBase, ladoComun);
        bases[1] = new Rectangulo(anchoBase, ladoComun);

        laterales = new Rectangulo[4];
        for (int n = 0; n < laterales.Length; n++)
        {
            laterales[n] = new Rectangulo(ladoComun, largoLateral);
        }
    }

    public double CalcularArea()
    {
        double area = bases[0].CalcularArea() + bases[1].CalcularArea();

        for (int n = 0; n < 4; n++)
        {
            area += laterales[n].CalcularArea();
        }
        return area;
    }
    
    public double CalcularVolumen()
    {
        double ancho = bases[0].Ancho;
        double alto = bases[0].Largo; //este seria el lado común
        double largo = laterales[0].Ancho;
        return ancho * alto * largo;
    }

    public string Describir()
    {
        var culture = CultureInfo.InvariantCulture;

        string lateralesDescripcion = "";
        for (int n=0; n<3; n++)
        {
            lateralesDescripcion += laterales[n].Describir()+", \n";
        }
        lateralesDescripcion += laterales[3].Describir();

        string descripcion = @$"{{  
  ""Tipo"": ""Ortoedro"", 
  ""Tapas"": 
  [
    {bases[0].Describir()}, 
    {bases[1].Describir()}
  ],
  ""Laterales"": 
    [
      { lateralesDescripcion },
    ],
  ""Area"": {CalcularArea().ToString("f2", culture)},
  ""Volumen"": {CalcularVolumen().ToString("f2", culture)}
}}";
        return descripcion;
    }
}
