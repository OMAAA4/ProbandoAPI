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
            BaseModelado DatosPokemon = ModelarPokemon.DatosPokemon(pokemon);

            label1.Text = DatosPokemon.Nombre;
            dataGridView1.DataSource = DatosPokemon.Habilidades.Select(h => new { h.Nombre, h.Oculta}).ToList();
        }
    }
}
