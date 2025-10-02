namespace PrimeraVezConAPIs.Forms
{
    partial class Principal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuPrincipal = new MenuStrip();
            menúToolStripMenuItem = new ToolStripMenuItem();
            nuevoToolStripMenuItem = new ToolStripMenuItem();
            guardarToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            menuPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // menuPrincipal
            // 
            menuPrincipal.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menuPrincipal.ImageScalingSize = new Size(20, 20);
            menuPrincipal.Items.AddRange(new ToolStripItem[] { menúToolStripMenuItem });
            menuPrincipal.Location = new Point(0, 0);
            menuPrincipal.Name = "menuPrincipal";
            menuPrincipal.Padding = new Padding(4, 1, 0, 1);
            menuPrincipal.Size = new Size(967, 37);
            menuPrincipal.TabIndex = 1;
            menuPrincipal.Text = "menuStrip1";
            // 
            // menúToolStripMenuItem
            // 
            menúToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nuevoToolStripMenuItem, guardarToolStripMenuItem, salirToolStripMenuItem });
            menúToolStripMenuItem.Name = "menúToolStripMenuItem";
            menúToolStripMenuItem.Size = new Size(87, 35);
            menúToolStripMenuItem.Text = "Menú";
            // 
            // nuevoToolStripMenuItem
            // 
            nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            nuevoToolStripMenuItem.Size = new Size(187, 36);
            nuevoToolStripMenuItem.Text = "Nuevo";
            nuevoToolStripMenuItem.Click += nuevoToolStripMenuItem_Click;
            // 
            // guardarToolStripMenuItem
            // 
            guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            guardarToolStripMenuItem.Size = new Size(187, 36);
            guardarToolStripMenuItem.Text = "Guardar";
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(187, 36);
            salirToolStripMenuItem.Text = "Salir";
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(967, 574);
            Controls.Add(menuPrincipal);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            IsMdiContainer = true;
            MainMenuStrip = menuPrincipal;
            Name = "Principal";
            Text = "Principal";
            WindowState = FormWindowState.Maximized;
            menuPrincipal.ResumeLayout(false);
            menuPrincipal.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuPrincipal;
        private ToolStripMenuItem menúToolStripMenuItem;
        private ToolStripMenuItem nuevoToolStripMenuItem;
        private ToolStripMenuItem guardarToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
    }
}