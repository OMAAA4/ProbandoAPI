using PrimeraVezConAPIs.Modelo;
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
            ObtenerPokemon pokemon = new();
            string nombrePokemon = "Pikachu";
            var datos = await pokemon.DatosPokemon(nombrePokemon);
        }
    }
}
