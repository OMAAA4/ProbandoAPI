using PrimeraVezConAPIs.Modelo;
using PrimeraVezConAPIs.Modelo.Habilidades;
using PrimeraVezConAPIs.Servicios;
using System.Security.Cryptography.X509Certificates;

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
            BaseModeladoListado pokemones = await ModelarPokemon.Pokemones( await ObtenerPokemon.MostrarPokemones());

            var autoComplete = new AutoCompleteStringCollection();
            autoComplete.AddRange([.. pokemones.nombre]);
            txtNombre.AutoCompleteCustomSource = autoComplete;
            txtNombre.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtNombre.AutoCompleteSource = AutoCompleteSource.CustomSource;

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ConsultarDatos();
        }

        private async void ConsultarDatos()
        {
            int hp, ataque, defensa, atEspecial, defEspecial, velocidad;
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

                dgvPokedex.DataSource = DatosPokemon.Pokedex.Select(p => new { p.GameIndex, p.VersionNombre }).ToList();

                string tipo1, tipo2;

                tipo1 = DatosPokemon.Tipos.First().Nombre;
                tipo2 = DatosPokemon.Tipos.Skip(1).FirstOrDefault()?.Nombre ?? "";

                lblTipo1.Visible = true;
                lblTipo2.Visible = true;

                lblTipo1.Text = tipo1.ToUpper();
                lblTipo2.Text = tipo2.ToUpper();


                hp = DatosPokemon.estadisticas.FirstOrDefault(e => e.nombre.Equals("hp")).baseInicio;
                ataque = DatosPokemon.estadisticas.FirstOrDefault(e => e.nombre.Equals("attack")).baseInicio;
                defensa = DatosPokemon.estadisticas.FirstOrDefault(e => e.nombre.Equals("defense")).baseInicio;
                atEspecial = DatosPokemon.estadisticas.FirstOrDefault(e => e.nombre.Equals("special-attack")).baseInicio;
                defEspecial = DatosPokemon.estadisticas.FirstOrDefault(e => e.nombre.Equals("special-defense")).baseInicio;
                velocidad = DatosPokemon.estadisticas.FirstOrDefault(e => e.nombre.Equals("speed")).baseInicio;

                progressBar1.Maximum = 255;
                progressBar2.Maximum = 255;
                progressBar3.Maximum = 255;
                progressBar4.Maximum = 255;
                progressBar5.Maximum = 255;
                progressBar6.Maximum = 255;

                progressBar1.Value = Math.Min(hp, progressBar1.Maximum);
                progressBar2.Value = Math.Min(ataque, progressBar2.Maximum);
                progressBar3.Value = Math.Min(defensa, progressBar3.Maximum);
                progressBar4.Value = Math.Min(atEspecial, progressBar4.Maximum);
                progressBar5.Value = Math.Min(defEspecial, progressBar5.Maximum);
                progressBar6.Value = Math.Min(velocidad, progressBar6.Maximum);
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
