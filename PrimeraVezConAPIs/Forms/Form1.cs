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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ConsultarDatos();
        }

        private async void ConsultarDatos()
        {
            ObtenerPokemon obtenerPokemon = new();
            var pokemon = await obtenerPokemon.DatosPokemon(txtNombre.Text);
            if (pokemon != null)
            {
                BaseModelado DatosPokemon = await ModelarPokemon.DatosPokemon(pokemon);

                pictureBox1.Image = DatosPokemon.spriteFrontal;
                pictureBox2.Image = DatosPokemon.spriteEspalda;

                lblNombre.Visible = true;
                lblNombre.Text = DatosPokemon.Nombre.ToUpper();

                dgvHabilidades.DataSource = DatosPokemon.Habilidades.Select(h => new { h.Nombre, h.Oculta }).ToList();

                dgvPokedex.DataSource = DatosPokemon.Pokedex.Select(p => new { p.GameIndex, p.VersionNombre}).ToList();

                string tipo1, tipo2;

                tipo1 = DatosPokemon.Tipos.First().Nombre;
                tipo2 = DatosPokemon.Tipos.Skip(1).FirstOrDefault()?.Nombre ?? "";

                lblTipo1.Visible = true;
                lblTipo2.Visible = true;

                lblTipo1.Text = tipo1.ToUpper();
                lblTipo2.Text = tipo2.ToUpper();
            }
            else
            {
                MessageBox.Show("Nombre de Pokémon invalido", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ((char)Keys.Enter))
            {
                e.Handled = true;
                ConsultarDatos();
            }
        }
    }
}
