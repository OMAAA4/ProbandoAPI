namespace PrimeraVezConAPIs
{
    partial class PokemonForm
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
            panel2 = new Panel();
            panel3 = new Panel();
            panel1 = new Panel();
            label5 = new Label();
            MSonidoViejo = new Button();
            lblNombre = new Label();
            label13 = new Label();
            lblTipo1 = new Label();
            MSonidoNuevo = new Button();
            lblTipo2 = new Label();
            label9 = new Label();
            panel4 = new Panel();
            progressBar6 = new ProgressBar();
            progressBar3 = new ProgressBar();
            progressBar5 = new ProgressBar();
            progressBar4 = new ProgressBar();
            progressBar2 = new ProgressBar();
            progressBar1 = new ProgressBar();
            lblVel = new Label();
            label8 = new Label();
            lblDefensae = new Label();
            label7 = new Label();
            lblAtaqueE = new Label();
            numVe = new Label();
            numDf = new Label();
            numDe = new Label();
            numAe = new Label();
            numAt = new Label();
            numHp = new Label();
            lblHp = new Label();
            dgvPokedex = new DataGridView();
            dgvHabilidades = new DataGridView();
            label6 = new Label();
            label4 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            panelPrincipal = new Panel();
            panelSecundario = new Panel();
            panelSuperior = new Panel();
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPokedex).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvHabilidades).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panelPrincipal.SuspendLayout();
            panelSuperior.SuspendLayout();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(215, 19);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(189, 27);
            txtNombre.TabIndex = 0;
            txtNombre.KeyPress += txtNombre_KeyPress;
            // 
            // btnBuscar
            // 
            btnBuscar.Cursor = Cursors.Hand;
            btnBuscar.Location = new Point(411, 18);
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
            lbBusqueda.Location = new Point(11, 19);
            lbBusqueda.Name = "lbBusqueda";
            lbBusqueda.Size = new Size(199, 25);
            lbBusqueda.TabIndex = 2;
            lbBusqueda.Text = "Nombre del Pokémon:";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ButtonHighlight;
            pictureBox1.Location = new Point(47, 18);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(234, 234);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pictureBox2.BackColor = SystemColors.ButtonHighlight;
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.Location = new Point(1102, 492);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(176, 175);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label3.Location = new Point(1102, 465);
            label3.Name = "label3";
            label3.Size = new Size(68, 23);
            label3.TabIndex = 6;
            label3.Text = "Espalda";
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
            panel2.Size = new Size(1324, 60);
            panel2.TabIndex = 8;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ButtonHighlight;
            panel3.Controls.Add(panel1);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(dgvPokedex);
            panel3.Controls.Add(dgvHabilidades);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(pictureBox2);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 63);
            panel3.Name = "panel3";
            panel3.Size = new Size(1324, 688);
            panel3.TabIndex = 9;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(MSonidoViejo);
            panel1.Controls.Add(lblNombre);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(lblTipo1);
            panel1.Controls.Add(MSonidoNuevo);
            panel1.Controls.Add(lblTipo2);
            panel1.Location = new Point(41, 26);
            panel1.Name = "panel1";
            panel1.Size = new Size(326, 496);
            panel1.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            label5.Location = new Point(47, 373);
            label5.Name = "label5";
            label5.Size = new Size(169, 31);
            label5.TabIndex = 12;
            label5.Text = "Sonido Nuevo:";
            // 
            // MSonidoViejo
            // 
            MSonidoViejo.Cursor = Cursors.Hand;
            MSonidoViejo.Image = Properties.Resources.speaker_filled_audio_tool;
            MSonidoViejo.Location = new Point(234, 432);
            MSonidoViejo.Margin = new Padding(3, 4, 3, 4);
            MSonidoViejo.Name = "MSonidoViejo";
            MSonidoViejo.Size = new Size(47, 31);
            MSonidoViejo.TabIndex = 13;
            MSonidoViejo.UseVisualStyleBackColor = true;
            MSonidoViejo.Click += MSonidoViejo_Click;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombre.ForeColor = SystemColors.MenuText;
            lblNombre.Location = new Point(140, 255);
            lblNombre.Name = "lblNombre";
            lblNombre.Padding = new Padding(10, 4, 10, 4);
            lblNombre.Size = new Size(49, 46);
            lblNombre.TabIndex = 9;
            lblNombre.Text = "_";
            lblNombre.TextAlign = ContentAlignment.MiddleCenter;
            lblNombre.Visible = false;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            label13.Location = new Point(47, 434);
            label13.Name = "label13";
            label13.Size = new Size(183, 31);
            label13.TabIndex = 12;
            label13.Text = "Sonido Antiguo:";
            // 
            // lblTipo1
            // 
            lblTipo1.AutoSize = true;
            lblTipo1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTipo1.Location = new Point(80, 313);
            lblTipo1.Name = "lblTipo1";
            lblTipo1.Size = new Size(20, 25);
            lblTipo1.TabIndex = 9;
            lblTipo1.Text = "_";
            lblTipo1.Visible = false;
            // 
            // MSonidoNuevo
            // 
            MSonidoNuevo.Cursor = Cursors.Hand;
            MSonidoNuevo.Image = Properties.Resources.speaker_filled_audio_tool;
            MSonidoNuevo.Location = new Point(234, 377);
            MSonidoNuevo.Margin = new Padding(3, 4, 3, 4);
            MSonidoNuevo.Name = "MSonidoNuevo";
            MSonidoNuevo.Size = new Size(47, 31);
            MSonidoNuevo.TabIndex = 11;
            MSonidoNuevo.UseVisualStyleBackColor = true;
            MSonidoNuevo.Click += MSonidoNuevo_Click;
            // 
            // lblTipo2
            // 
            lblTipo2.AutoSize = true;
            lblTipo2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTipo2.Location = new Point(224, 313);
            lblTipo2.Name = "lblTipo2";
            lblTipo2.Size = new Size(20, 25);
            lblTipo2.TabIndex = 9;
            lblTipo2.Text = "_";
            lblTipo2.Visible = false;
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
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel4.BackColor = SystemColors.ButtonHighlight;
            panel4.Controls.Add(progressBar6);
            panel4.Controls.Add(progressBar3);
            panel4.Controls.Add(progressBar5);
            panel4.Controls.Add(progressBar4);
            panel4.Controls.Add(progressBar2);
            panel4.Controls.Add(progressBar1);
            panel4.Controls.Add(lblVel);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(lblDefensae);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(lblAtaqueE);
            panel4.Controls.Add(numVe);
            panel4.Controls.Add(numDf);
            panel4.Controls.Add(numDe);
            panel4.Controls.Add(numAe);
            panel4.Controls.Add(numAt);
            panel4.Controls.Add(numHp);
            panel4.Controls.Add(lblHp);
            panel4.Location = new Point(464, 48);
            panel4.Name = "panel4";
            panel4.Size = new Size(830, 125);
            panel4.TabIndex = 10;
            // 
            // progressBar6
            // 
            progressBar6.Location = new Point(436, 96);
            progressBar6.Name = "progressBar6";
            progressBar6.Size = new Size(175, 17);
            progressBar6.Step = 1;
            progressBar6.TabIndex = 1;
            // 
            // progressBar3
            // 
            progressBar3.Location = new Point(110, 96);
            progressBar3.Name = "progressBar3";
            progressBar3.Size = new Size(175, 17);
            progressBar3.Step = 1;
            progressBar3.TabIndex = 1;
            // 
            // progressBar5
            // 
            progressBar5.Location = new Point(436, 55);
            progressBar5.Name = "progressBar5";
            progressBar5.Size = new Size(175, 17);
            progressBar5.Step = 1;
            progressBar5.TabIndex = 1;
            // 
            // progressBar4
            // 
            progressBar4.Location = new Point(436, 13);
            progressBar4.Name = "progressBar4";
            progressBar4.Size = new Size(175, 17);
            progressBar4.Step = 1;
            progressBar4.TabIndex = 1;
            // 
            // progressBar2
            // 
            progressBar2.Location = new Point(110, 55);
            progressBar2.Name = "progressBar2";
            progressBar2.Size = new Size(175, 17);
            progressBar2.Step = 1;
            progressBar2.TabIndex = 1;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(110, 13);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(175, 17);
            progressBar1.Step = 1;
            progressBar1.TabIndex = 1;
            // 
            // lblVel
            // 
            lblVel.AutoSize = true;
            lblVel.Location = new Point(291, 93);
            lblVel.Name = "lblVel";
            lblVel.Size = new Size(75, 20);
            lblVel.TabIndex = 0;
            lblVel.Text = "Velocidad";
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
            // lblDefensae
            // 
            lblDefensae.AutoSize = true;
            lblDefensae.Location = new Point(291, 52);
            lblDefensae.Name = "lblDefensae";
            lblDefensae.Size = new Size(121, 20);
            lblDefensae.TabIndex = 0;
            lblDefensae.Text = "Defensa Especial";
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
            // lblAtaqueE
            // 
            lblAtaqueE.AutoSize = true;
            lblAtaqueE.Location = new Point(291, 11);
            lblAtaqueE.Name = "lblAtaqueE";
            lblAtaqueE.Size = new Size(115, 20);
            lblAtaqueE.TabIndex = 0;
            lblAtaqueE.Text = "Ataque Especial";
            // 
            // numVe
            // 
            numVe.AutoSize = true;
            numVe.Location = new Point(409, 95);
            numVe.Name = "numVe";
            numVe.Size = new Size(15, 20);
            numVe.TabIndex = 0;
            numVe.Text = "_";
            // 
            // numDf
            // 
            numDf.AutoSize = true;
            numDf.Location = new Point(79, 93);
            numDf.Name = "numDf";
            numDf.Size = new Size(15, 20);
            numDf.TabIndex = 0;
            numDf.Text = "_";
            // 
            // numDe
            // 
            numDe.AutoSize = true;
            numDe.Location = new Point(409, 55);
            numDe.Name = "numDe";
            numDe.Size = new Size(15, 20);
            numDe.TabIndex = 0;
            numDe.Text = "_";
            // 
            // numAe
            // 
            numAe.AutoSize = true;
            numAe.Location = new Point(409, 12);
            numAe.Name = "numAe";
            numAe.Size = new Size(15, 20);
            numAe.TabIndex = 0;
            numAe.Text = "_";
            // 
            // numAt
            // 
            numAt.AutoSize = true;
            numAt.Location = new Point(79, 53);
            numAt.Name = "numAt";
            numAt.Size = new Size(15, 20);
            numAt.TabIndex = 0;
            numAt.Text = "_";
            // 
            // numHp
            // 
            numHp.AutoSize = true;
            numHp.Location = new Point(79, 11);
            numHp.Name = "numHp";
            numHp.Size = new Size(15, 20);
            numHp.TabIndex = 0;
            numHp.Text = "_";
            // 
            // lblHp
            // 
            lblHp.AutoSize = true;
            lblHp.Location = new Point(16, 11);
            lblHp.Name = "lblHp";
            lblHp.Size = new Size(29, 20);
            lblHp.TabIndex = 0;
            lblHp.Text = "Hp";
            // 
            // dgvPokedex
            // 
            dgvPokedex.AllowUserToAddRows = false;
            dgvPokedex.AllowUserToDeleteRows = false;
            dgvPokedex.AllowUserToResizeColumns = false;
            dgvPokedex.AllowUserToResizeRows = false;
            dgvPokedex.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvPokedex.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPokedex.BackgroundColor = SystemColors.ButtonHighlight;
            dgvPokedex.BorderStyle = BorderStyle.None;
            dgvPokedex.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPokedex.Location = new Point(464, 360);
            dgvPokedex.Name = "dgvPokedex";
            dgvPokedex.RowHeadersVisible = false;
            dgvPokedex.RowHeadersWidth = 51;
            dgvPokedex.Size = new Size(564, 308);
            dgvPokedex.TabIndex = 8;
            // 
            // dgvHabilidades
            // 
            dgvHabilidades.AllowUserToAddRows = false;
            dgvHabilidades.AllowUserToDeleteRows = false;
            dgvHabilidades.AllowUserToResizeColumns = false;
            dgvHabilidades.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvHabilidades.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHabilidades.BackgroundColor = SystemColors.ButtonHighlight;
            dgvHabilidades.BorderStyle = BorderStyle.None;
            dgvHabilidades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHabilidades.Location = new Point(464, 224);
            dgvHabilidades.Name = "dgvHabilidades";
            dgvHabilidades.RowHeadersVisible = false;
            dgvHabilidades.RowHeadersWidth = 51;
            dgvHabilidades.Size = new Size(564, 96);
            dgvHabilidades.TabIndex = 8;
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
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ButtonHighlight;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.Location = new Point(464, 193);
            label4.Name = "label4";
            label4.Size = new Size(123, 28);
            label4.TabIndex = 7;
            label4.Text = "Habilidades";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1338, 787);
            tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(panel3);
            tabPage1.Controls.Add(panel2);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1330, 754);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Búsqueda individual";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(tableLayoutPanel2);
            tabPage2.Controls.Add(panelSuperior);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1330, 754);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Todos los pokémones";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.8398781F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 62.1601219F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel1, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 66);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(1324, 685);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(panelPrincipal, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 92.64706F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.352941F));
            tableLayoutPanel1.Size = new Size(495, 679);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panelPrincipal
            // 
            panelPrincipal.BackColor = Color.Gainsboro;
            panelPrincipal.Controls.Add(panelSecundario);
            panelPrincipal.Dock = DockStyle.Fill;
            panelPrincipal.Location = new Point(25, 25);
            panelPrincipal.Margin = new Padding(25);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Padding = new Padding(10);
            panelPrincipal.Size = new Size(445, 579);
            panelPrincipal.TabIndex = 0;
            panelPrincipal.Resize += panelPrincipal_Resize;
            // 
            // panelSecundario
            // 
            panelSecundario.BackColor = Color.White;
            panelSecundario.Dock = DockStyle.Fill;
            panelSecundario.Location = new Point(10, 10);
            panelSecundario.Name = "panelSecundario";
            panelSecundario.Size = new Size(425, 559);
            panelSecundario.TabIndex = 1;
            panelSecundario.Resize += panelSecundario_Resize;
            // 
            // panelSuperior
            // 
            panelSuperior.BackColor = Color.ForestGreen;
            panelSuperior.Controls.Add(button1);
            panelSuperior.Controls.Add(textBox1);
            panelSuperior.Controls.Add(label1);
            panelSuperior.Dock = DockStyle.Top;
            panelSuperior.Location = new Point(3, 3);
            panelSuperior.Name = "panelSuperior";
            panelSuperior.Size = new Size(1324, 63);
            panelSuperior.TabIndex = 1;
            panelSuperior.Resize += panelSuperior_Resize;
            // 
            // button1
            // 
            button1.Location = new Point(451, 17);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 5;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(230, 19);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(196, 27);
            textBox1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(25, 18);
            label1.Name = "label1";
            label1.Size = new Size(199, 25);
            label1.TabIndex = 3;
            label1.Text = "Nombre del Pokémon:";
            // 
            // PokemonForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(1338, 787);
            Controls.Add(tabControl1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "PokemonForm";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPokedex).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvHabilidades).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panelPrincipal.ResumeLayout(false);
            panelSuperior.ResumeLayout(false);
            panelSuperior.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtNombre;
        private Button btnBuscar;
        private Label lbBusqueda;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label3;
        private Panel panel2;
        private Panel panel3;
        private DataGridView dgvHabilidades;
        private Label label4;
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
        private Label lblVel;
        private Label lblDefensae;
        private Label lblAtaqueE;
        private ProgressBar progressBar6;
        private ProgressBar progressBar3;
        private ProgressBar progressBar5;
        private ProgressBar progressBar4;
        private ProgressBar progressBar2;
        private ProgressBar progressBar1;
        private Button MSonidoNuevo;
        private Label label13;
        private Label label5;
        private Button MSonidoViejo;
        private Label numVe;
        private Label numDf;
        private Label numDe;
        private Label numAe;
        private Label numAt;
        private Label numHp;
        private Panel panel1;
        private Panel panelSuperior;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panelPrincipal;
        private Button button1;
        private TextBox textBox1;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panelSecundario;
    }
}
