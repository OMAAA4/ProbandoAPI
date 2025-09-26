namespace PrimeraVezConAPIs
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtNombre = new TextBox();
            btnBuscar = new Button();
            lbBusqueda = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            progressBar6 = new ProgressBar();
            progressBar3 = new ProgressBar();
            progressBar5 = new ProgressBar();
            progressBar4 = new ProgressBar();
            progressBar2 = new ProgressBar();
            progressBar1 = new ProgressBar();
            label12 = new Label();
            label8 = new Label();
            label11 = new Label();
            label7 = new Label();
            label10 = new Label();
            lblHp = new Label();
            lblTipo2 = new Label();
            lblTipo1 = new Label();
            lblNombre = new Label();
            dgvPokedex = new DataGridView();
            dgvHabilidades = new DataGridView();
            label2 = new Label();
            label6 = new Label();
            label9 = new Label();
            label4 = new Label();
            label1 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPokedex).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvHabilidades).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(217, 19);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(189, 27);
            txtNombre.TabIndex = 0;
            txtNombre.KeyPress += txtNombre_KeyPress;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(412, 18);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(94, 29);
            btnBuscar.TabIndex = 1;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // lbBusqueda
            // 
            lbBusqueda.AutoSize = true;
            lbBusqueda.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbBusqueda.ForeColor = SystemColors.ButtonHighlight;
            lbBusqueda.Location = new Point(12, 18);
            lbBusqueda.Name = "lbBusqueda";
            lbBusqueda.Size = new Size(199, 25);
            lbBusqueda.TabIndex = 2;
            lbBusqueda.Text = "Nombre del Pokémon:";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ButtonHighlight;
            pictureBox1.Location = new Point(17, 18);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(359, 318);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pictureBox2.BackColor = SystemColors.ButtonHighlight;
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.Location = new Point(893, 378);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(176, 176);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label3.Location = new Point(893, 352);
            label3.Name = "label3";
            label3.Size = new Size(68, 23);
            label3.TabIndex = 6;
            label3.Text = "Espalda";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Cornsilk;
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(31, 36);
            panel1.Name = "panel1";
            panel1.Size = new Size(396, 357);
            panel1.TabIndex = 7;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Green;
            panel2.Controls.Add(lbBusqueda);
            panel2.Controls.Add(txtNombre);
            panel2.Controls.Add(btnBuscar);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(1116, 60);
            panel2.TabIndex = 8;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ButtonHighlight;
            panel3.Controls.Add(panel1);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(lblTipo2);
            panel3.Controls.Add(lblTipo1);
            panel3.Controls.Add(lblNombre);
            panel3.Controls.Add(dgvPokedex);
            panel3.Controls.Add(dgvHabilidades);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(pictureBox2);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 63);
            panel3.Name = "panel3";
            panel3.Size = new Size(1116, 575);
            panel3.TabIndex = 9;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel4.BackColor = Color.Cornsilk;
            panel4.Controls.Add(progressBar6);
            panel4.Controls.Add(progressBar3);
            panel4.Controls.Add(progressBar5);
            panel4.Controls.Add(progressBar4);
            panel4.Controls.Add(progressBar2);
            panel4.Controls.Add(progressBar1);
            panel4.Controls.Add(label12);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(label11);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(label10);
            panel4.Controls.Add(lblHp);
            panel4.Location = new Point(464, 48);
            panel4.Name = "panel4";
            panel4.Size = new Size(621, 125);
            panel4.TabIndex = 10;
            // 
            // progressBar6
            // 
            progressBar6.Location = new Point(421, 96);
            progressBar6.Name = "progressBar6";
            progressBar6.Size = new Size(175, 17);
            progressBar6.Step = 1;
            progressBar6.TabIndex = 1;
            // 
            // progressBar3
            // 
            progressBar3.Location = new Point(99, 96);
            progressBar3.Name = "progressBar3";
            progressBar3.Size = new Size(175, 17);
            progressBar3.Step = 1;
            progressBar3.TabIndex = 1;
            // 
            // progressBar5
            // 
            progressBar5.Location = new Point(421, 55);
            progressBar5.Name = "progressBar5";
            progressBar5.Size = new Size(175, 17);
            progressBar5.Step = 1;
            progressBar5.TabIndex = 1;
            // 
            // progressBar4
            // 
            progressBar4.Location = new Point(421, 13);
            progressBar4.Name = "progressBar4";
            progressBar4.Size = new Size(175, 17);
            progressBar4.Step = 1;
            progressBar4.TabIndex = 1;
            // 
            // progressBar2
            // 
            progressBar2.Location = new Point(99, 55);
            progressBar2.Name = "progressBar2";
            progressBar2.Size = new Size(175, 17);
            progressBar2.Step = 1;
            progressBar2.TabIndex = 1;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(99, 13);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(175, 17);
            progressBar1.Step = 1;
            progressBar1.TabIndex = 1;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(294, 93);
            label12.Name = "label12";
            label12.Size = new Size(51, 20);
            label12.TabIndex = 0;
            label12.Text = "Speed";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(16, 93);
            label8.Name = "label8";
            label8.Size = new Size(63, 20);
            label8.TabIndex = 0;
            label8.Text = "Defensa";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(294, 52);
            label11.Name = "label11";
            label11.Size = new Size(121, 20);
            label11.TabIndex = 0;
            label11.Text = "Defensa Especial";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(16, 52);
            label7.Name = "label7";
            label7.Size = new Size(57, 20);
            label7.TabIndex = 0;
            label7.Text = "Ataque";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(294, 10);
            label10.Name = "label10";
            label10.Size = new Size(115, 20);
            label10.TabIndex = 0;
            label10.Text = "Ataque Especial";
            // 
            // lblHp
            // 
            lblHp.AutoSize = true;
            lblHp.Location = new Point(16, 10);
            lblHp.Name = "lblHp";
            lblHp.Size = new Size(29, 20);
            lblHp.TabIndex = 0;
            lblHp.Text = "Hp";
            // 
            // lblTipo2
            // 
            lblTipo2.AutoSize = true;
            lblTipo2.Font = new Font("Segoe UI Light", 10.8F, FontStyle.Underline);
            lblTipo2.Location = new Point(148, 491);
            lblTipo2.Name = "lblTipo2";
            lblTipo2.Size = new Size(57, 25);
            lblTipo2.TabIndex = 9;
            lblTipo2.Text = "label5";
            lblTipo2.Visible = false;
            // 
            // lblTipo1
            // 
            lblTipo1.AutoSize = true;
            lblTipo1.Font = new Font("Segoe UI Light", 10.8F, FontStyle.Underline);
            lblTipo1.Location = new Point(148, 451);
            lblTipo1.Name = "lblTipo1";
            lblTipo1.Size = new Size(57, 25);
            lblTipo1.TabIndex = 9;
            lblTipo1.Text = "label5";
            lblTipo1.Visible = false;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI Light", 10.8F, FontStyle.Underline);
            lblNombre.Location = new Point(148, 401);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(57, 25);
            lblNombre.TabIndex = 9;
            lblNombre.Text = "label5";
            lblNombre.Visible = false;
            // 
            // dgvPokedex
            // 
            dgvPokedex.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvPokedex.BackgroundColor = Color.Cornsilk;
            dgvPokedex.BorderStyle = BorderStyle.None;
            dgvPokedex.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPokedex.Location = new Point(464, 357);
            dgvPokedex.Name = "dgvPokedex";
            dgvPokedex.RowHeadersWidth = 51;
            dgvPokedex.Size = new Size(355, 216);
            dgvPokedex.TabIndex = 8;
            // 
            // dgvHabilidades
            // 
            dgvHabilidades.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvHabilidades.BackgroundColor = Color.FromArgb(192, 255, 192);
            dgvHabilidades.BorderStyle = BorderStyle.None;
            dgvHabilidades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHabilidades.Location = new Point(464, 211);
            dgvHabilidades.Name = "dgvHabilidades";
            dgvHabilidades.RowHeadersWidth = 51;
            dgvHabilidades.Size = new Size(355, 99);
            dgvHabilidades.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonHighlight;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(31, 444);
            label2.Name = "label2";
            label2.Size = new Size(59, 28);
            label2.TabIndex = 7;
            label2.Text = "Tipo:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.ButtonHighlight;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label6.Location = new Point(464, 323);
            label6.Name = "label6";
            label6.Size = new Size(215, 28);
            label6.TabIndex = 7;
            label6.Text = "# Pokedex por juegos";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = SystemColors.ButtonHighlight;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label9.Location = new Point(464, 17);
            label9.Name = "label9";
            label9.Size = new Size(122, 28);
            label9.TabIndex = 7;
            label9.Text = "Estadisticas";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ButtonHighlight;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.Location = new Point(464, 180);
            label4.Name = "label4";
            label4.Size = new Size(123, 28);
            label4.TabIndex = 7;
            label4.Text = "Habilidades";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonHighlight;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(31, 396);
            label1.Name = "label1";
            label1.Size = new Size(94, 28);
            label1.TabIndex = 7;
            label1.Text = "Nombre:";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1130, 674);
            tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(panel3);
            tabPage1.Controls.Add(panel2);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1122, 641);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Búsqueda individual";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1122, 641);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Todos los pokémones";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleGreen;
            ClientSize = new Size(1130, 674);
            Controls.Add(tabControl1);
            MaximumSize = new Size(1148, 721);
            MinimumSize = new Size(1148, 721);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPokedex).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvHabilidades).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtNombre;
        private Button btnBuscar;
        private Label lbBusqueda;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label3;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private DataGridView dgvHabilidades;
        private Label label2;
        private Label label4;
        private Label label1;
        private Label lblNombre;
        private Label lblTipo2;
        private Label lblTipo1;
        private DataGridView dgvPokedex;
        private Label label6;
        private Panel panel4;
        private Label label9;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label8;
        private Label label7;
        private Label lblHp;
        private Label label12;
        private Label label11;
        private Label label10;
        private ProgressBar progressBar6;
        private ProgressBar progressBar3;
        private ProgressBar progressBar5;
        private ProgressBar progressBar4;
        private ProgressBar progressBar2;
        private ProgressBar progressBar1;
    }
}
