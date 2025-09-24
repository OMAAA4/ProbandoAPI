using PrimeraVezConAPIs.Modelo;
using PrimeraVezConAPIs.Modelo.Habilidades;
using PrimeraVezConAPIs.Servicios;

namespace PrimeraVezConAPIs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            ObtenerPokemon obtenerPokemon = new();
            var pokemon = await obtenerPokemon.DatosPokemon(txtNombre.Text);
            BaseModelado DatosPokemon = await ModelarPokemon.DatosPokemon(pokemon);
            
            pictureBox1.Image = DatosPokemon.spriteFrontal;

        }
    }
}
