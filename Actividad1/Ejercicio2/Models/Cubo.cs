
using System.Globalization;

namespace Ejercicio2.Models;

public class Cubo : Ortoedro
{
    public Cubo(double lado):base(lado, lado, lado)
    { 
    }

    public override string Describir()
    {
        var culture = CultureInfo.InvariantCulture;

        string lateralesDescripcion = "";
        for (int n = 0; n < 3; n++)
        {
            lateralesDescripcion += laterales[n].Describir() + ", \n";
        }
        lateralesDescripcion += laterales[3].Describir();

        string descripcion = @$"{{  
  ""Tipo"": ""Cubo"", 
  ""Caras"": 
  [
    {bases[0].Describir()}, 
    {bases[1].Describir()},
    {lateralesDescripcion}
  ],  
  ""Area"": {CalcularArea().ToString("f2", culture)},
  ""Volumen"": {CalcularVolumen().ToString("f2", culture)}
}}";
        return descripcion;
    }
}
