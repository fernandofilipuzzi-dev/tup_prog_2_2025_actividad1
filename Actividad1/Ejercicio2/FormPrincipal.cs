using Ejercicio2.Models;

namespace Ejercicio2
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnDescribir_Click(object sender, EventArgs e)
        {
            FiguraVolumetrica[] figuras = new FiguraVolumetrica[6];

            //construyendo los objetos
            figuras[0] = new Cilindro(3, 3);
            figuras[1] = new Cubo(3);
            figuras[2] = new Ortoedro(7, 7, 21);
            figuras[3] = new Cilindro(9, 13);
            figuras[4] = new Cubo(7);
            figuras[5] = new Cilindro(13, 23);

            //llamando al mensaje común de todos los objetos figura
            tbDescripcion.Text += "[ \n";
            foreach (FiguraVolumetrica figura in figuras)
            {
                tbDescripcion.Text += figura.Describir() + ",\n";
            }
            tbDescripcion.Text += "]";
        }
    }
}
