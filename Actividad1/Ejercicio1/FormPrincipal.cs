using Ejercicio1.Models;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDescribir_Click(object sender, EventArgs e)
        {
            //construyendo los objetos
            Cilindro objeto1 = new Cilindro(3, 3);
            Cubo objeto2= new Cubo(3);
            Ortoedro objeto3 = new Ortoedro(7, 7, 21);
            Cilindro objeto4 = new Cilindro(9, 13);
            Cubo objeto5 = new Cubo(7);
            Cilindro objeto6 = new Cilindro(13, 23);

            //llamando al mensaje común de todos los objetos figura
            tbDescripcion.Text += $@"[ 
  { objeto1.Describir() },
  { objeto2.Describir()},
  { objeto3.Describir()},
  { objeto4.Describir()},
  { objeto5.Describir()},
  { objeto6.Describir()},
            ]";
        }
     }
}
