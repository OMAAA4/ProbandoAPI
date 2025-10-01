using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimeraVezConAPIs.Forms
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private ToolStripMenuItem menuItem = new();
        private PokemonForm pokemonForm;
        private int Contador = 1;

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuItem.Name = "menuItem";
            menuItem.Text = "Ventanas";
            menuItem.Size = new Size(120, 28);

            var item = menuPrincipal.Items.IndexOf(menuItem);
            if (item == -1)
            {
                menuPrincipal.Items.Add(menuItem);
                menuPrincipal.MdiWindowListItem = menuItem;
            }

            pokemonForm = new PokemonForm();
            pokemonForm.Name = string.Concat("Pokemon ",Contador.ToString());
            pokemonForm.Text = pokemonForm.Name;
            pokemonForm.MdiParent = this;
            pokemonForm.Show();
            pokemonForm.WindowState = FormWindowState.Maximized;

            Contador++;
        }
    }
}
