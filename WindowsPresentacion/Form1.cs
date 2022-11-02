using PracticoPol.CasoInstrumentos;
using PracticoPol.CasoAnimales;
using PracticoPol.CasoMedico;
using PracticoPol.CasoAjedrez;
namespace WindowsPresentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAfinar_Click(object sender, EventArgs e)
        {
            Guitarra guitarra = new Guitarra()
            {
                Nombre = "guitarra"
            };
            MessageBox.Show(guitarra.Afinar());
            Piano piano = new Piano()
            {
                Nombre = "piano"
            };
            MessageBox.Show(piano.Afinar());
            Violin violin = new Violin()
            {
                Nombre = "violin"
            };
            MessageBox.Show(violin.Afinar());
        }

        private void btnAjedrez_Click(object sender, EventArgs e)
        {
            Torre torre = new Torre();
            Peon peon = new Peon();
            Caballo caballo= new Caballo();
            MessageBox.Show(peon.Mover());
            MessageBox.Show(torre.Mover());
            MessageBox.Show(caballo.Mover());
        }

        private void btnMedico_Click(object sender, EventArgs e)
        {
            Paciente paciente = new Paciente("Juan", "Perez", "112233");
            MessageBox.Show(paciente.ToString());
            Medico medico = new Medico("Ricardo", "Wilson", "Cardiologo");
            MessageBox.Show(medico.ToString());
        }

        private void btnAnimales_Click(object sender, EventArgs e)
        {
            Leon leon = new Leon("5", "200 kg", "1.5 m", "60");
            MessageBox.Show(leon.Imprimir() + " " + leon.ImprimirComida("carne"));
        }

        private void btnConejo_Click(object sender, EventArgs e)
        {
            Conejo conejo= new Conejo("2", "1.5 kg", "30 cm", "blanco");
            MessageBox.Show(conejo.Imprimir() + " " + conejo.ImprimirComida("zanahoria"));
        }

        private void btnLoro_Click(object sender, EventArgs e)
        {
            Loro loro = new Loro("25", "2 kg", "35 cm", "260");
            MessageBox.Show(loro.Imprimir() + " "+ loro.ImprimirComida("alpiste"));
        }
    }
}