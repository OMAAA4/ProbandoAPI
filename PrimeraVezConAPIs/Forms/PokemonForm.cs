using PrimeraVezConAPIs.Modelo;
using PrimeraVezConAPIs.Modelo.Habilidades;
using PrimeraVezConAPIs.Servicios;
using System.Security.Cryptography.X509Certificates;
using NAudio.Wave;
using NAudio.Vorbis;
using PrimeraVezConAPIs.Forms;

namespace PrimeraVezConAPIs
{
    public partial class PokemonForm : Form
    {
        public PokemonForm()
        {
            InitializeComponent();
        }

        private MemoryStream sonidoV = new();
        private MemoryStream sonidoN = new();

        private async void Form1_Load(object sender, EventArgs e)

        {
            MSonidoNuevo.Enabled = false;
            MSonidoViejo.Enabled = false;

            BaseModeladoListado pokemones = await ModelarPokemon.Pokemones(await ObtenerPokemon.MostrarPokemones());

            var autoComplete = new AutoCompleteStringCollection();
            autoComplete.AddRange([.. pokemones.nombre]);
            txtNombre.AutoCompleteCustomSource = autoComplete;
            txtNombre.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtNombre.AutoCompleteSource = AutoCompleteSource.CustomSource;
            ModificacionInterfaz.RedondearLabel(lblNombre,5);
            lblNombre.BackColor = Color.Yellow;
            lblNombre.AutoSize = true;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ConsultarDatos();
        }

        private async void ConsultarDatos()
        {
            MSonidoNuevo.Enabled = false;
            MSonidoViejo.Enabled = false;
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


                hp = DatosPokemon.estadisticas?.FirstOrDefault(e => e.nombre.Equals("hp")).baseInicio ?? 0;
                ataque = DatosPokemon.estadisticas?.FirstOrDefault(e => e.nombre.Equals("attack")).baseInicio ?? 0;
                defensa = DatosPokemon.estadisticas?.FirstOrDefault(e => e.nombre.Equals("defense")).baseInicio ?? 0;
                atEspecial = DatosPokemon.estadisticas?.FirstOrDefault(e => e.nombre.Equals("special-attack")).baseInicio ?? 0;
                defEspecial = DatosPokemon.estadisticas?.FirstOrDefault(e => e.nombre.Equals("special-defense")).baseInicio ?? 0;
                velocidad = DatosPokemon.estadisticas?.FirstOrDefault(e => e.nombre.Equals("speed")).baseInicio ?? 0;

                progressBar1.Maximum = 255;
                progressBar2.Maximum = 255;
                progressBar3.Maximum = 255;
                progressBar4.Maximum = 255;
                progressBar5.Maximum = 255;
                progressBar6.Maximum = 255;

                numHp.Text = hp.ToString();
                numAt.Text = ataque.ToString();
                numDf.Text = defensa.ToString();
                numAe.Text = atEspecial.ToString();
                numDe.Text = defEspecial.ToString();
                numVe.Text = velocidad.ToString();

                progressBar1.Value = Math.Min(hp, progressBar1.Maximum);
                progressBar2.Value = Math.Min(ataque, progressBar2.Maximum);
                progressBar3.Value = Math.Min(defensa, progressBar3.Maximum);
                progressBar4.Value = Math.Min(atEspecial, progressBar4.Maximum);
                progressBar5.Value = Math.Min(defEspecial, progressBar5.Maximum);
                progressBar6.Value = Math.Min(velocidad, progressBar6.Maximum);

                sonidoN = DatosPokemon.sonidoNuevo;
                sonidoV = DatosPokemon.sonidoViejo;

                MSonidoNuevo.Enabled = true;
                MSonidoViejo.Enabled = true;
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

        private void MSonidoNuevo_Click(object sender, EventArgs e)
        {
            ReproducirSonido(sonidoN);
        }
        private void MSonidoViejo_Click(object sender, EventArgs e)
        {
            ReproducirSonido(sonidoV);
        }

        private static void ReproducirSonido(MemoryStream sonido)
        {
            if (sonido == null || sonido.Length == 0)
            {
                MessageBox.Show("sin sonido", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            WaveOut Salida = new();
            sonido.Position = 0;
            var vorbis = new VorbisWaveReader(sonido);
            Salida.Init(vorbis);
            Salida.Play();
        }

    }
}
