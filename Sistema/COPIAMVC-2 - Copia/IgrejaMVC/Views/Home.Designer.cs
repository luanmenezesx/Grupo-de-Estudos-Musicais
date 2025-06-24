namespace IgrejaMVC.Views
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            panel1 = new Panel();
            lblPerfil = new Label();
            lblUsuario = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox6 = new PictureBox();
            button4 = new Button();
            pictureBox5 = new PictureBox();
            pictureBox1 = new PictureBox();
            btnInstrumento = new Button();
            button1 = new Button();
            pictureBox2 = new PictureBox();
            button2 = new Button();
            pictureBox3 = new PictureBox();
            button3 = new Button();
            pictureBox4 = new PictureBox();
            pictureBox7 = new PictureBox();
            txtQuantInstrumentos = new Label();
            label3 = new Label();
            cartesianChart1 = new LiveChartsCore.SkiaSharpView.WinForms.CartesianChart();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            cmbAnos = new ComboBox();
            cartesianChart2 = new LiveChartsCore.SkiaSharpView.WinForms.CartesianChart();
            cmbFiltraGraph = new ComboBox();
            label4 = new Label();
            button5 = new Button();
            cartesianChart3 = new LiveChartsCore.SkiaSharpView.WinForms.CartesianChart();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Lavender;
            panel1.Controls.Add(lblPerfil);
            panel1.Controls.Add(lblUsuario);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox6);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(pictureBox5);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnInstrumento);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(pictureBox4);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(281, 749);
            panel1.TabIndex = 17;
            // 
            // lblPerfil
            // 
            lblPerfil.AutoSize = true;
            lblPerfil.ForeColor = Color.Red;
            lblPerfil.Location = new Point(68, 203);
            lblPerfil.Name = "lblPerfil";
            lblPerfil.Size = new Size(38, 15);
            lblPerfil.TabIndex = 25;
            lblPerfil.Text = "label4";
            lblPerfil.Visible = false;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.ForeColor = Color.Red;
            lblUsuario.Location = new Point(68, 178);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(38, 15);
            lblUsuario.TabIndex = 24;
            lblUsuario.Text = "label3";
            lblUsuario.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 203);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 23;
            label2.Text = "Perfil:";
            label2.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 178);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 22;
            label1.Text = "Usuário:";
            label1.Visible = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(29, 484);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(47, 32);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 21;
            pictureBox6.TabStop = false;
            // 
            // button4
            // 
            button4.BackColor = Color.Lavender;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Century Gothic", 14F);
            button4.ForeColor = Color.SteelBlue;
            button4.Location = new Point(-3, 474);
            button4.Name = "button4";
            button4.Size = new Size(281, 55);
            button4.TabIndex = 20;
            button4.Text = "Docentes";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click_1;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(29, 422);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(47, 32);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 19;
            pictureBox5.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_adicionar_grupo_de_usuários_mulher_homem_30;
            pictureBox1.Location = new Point(29, 366);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(47, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // btnInstrumento
            // 
            btnInstrumento.BackColor = Color.Lavender;
            btnInstrumento.FlatAppearance.BorderSize = 0;
            btnInstrumento.FlatStyle = FlatStyle.Flat;
            btnInstrumento.Font = new Font("Century Gothic", 14F);
            btnInstrumento.ForeColor = Color.SteelBlue;
            btnInstrumento.Location = new Point(-3, 413);
            btnInstrumento.Name = "btnInstrumento";
            btnInstrumento.Size = new Size(281, 55);
            btnInstrumento.TabIndex = 18;
            btnInstrumento.Text = "Cadastrar\r\n Instrumento";
            btnInstrumento.UseVisualStyleBackColor = false;
            btnInstrumento.Click += btnInstrumento_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Lavender;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 14F);
            button1.ForeColor = Color.SteelBlue;
            button1.Location = new Point(0, 352);
            button1.Name = "button1";
            button1.Size = new Size(281, 55);
            button1.TabIndex = 7;
            button1.Text = "Novo Aluno";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(29, 304);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(47, 32);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Lavender;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Century Gothic", 14F);
            button2.ForeColor = Color.SteelBlue;
            button2.Location = new Point(0, 298);
            button2.Name = "button2";
            button2.Size = new Size(281, 48);
            button2.TabIndex = 5;
            button2.Text = "Alunos";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(29, 252);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(47, 32);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.Control;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Century Gothic", 14F);
            button3.ForeColor = Color.SteelBlue;
            button3.Location = new Point(3, 244);
            button3.Name = "button3";
            button3.Size = new Size(278, 48);
            button3.TabIndex = 1;
            button3.Text = "DashBoard";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.logo_ccb_light;
            pictureBox4.Location = new Point(12, 31);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(251, 134);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 0;
            pictureBox4.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(1313, 12);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(45, 41);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 18;
            pictureBox7.TabStop = false;
            pictureBox7.Click += pictureBox7_Click;
            // 
            // txtQuantInstrumentos
            // 
            txtQuantInstrumentos.AutoSize = true;
            txtQuantInstrumentos.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtQuantInstrumentos.ForeColor = Color.SteelBlue;
            txtQuantInstrumentos.Location = new Point(660, 263);
            txtQuantInstrumentos.Name = "txtQuantInstrumentos";
            txtQuantInstrumentos.Size = new Size(0, 21);
            txtQuantInstrumentos.TabIndex = 119;
            txtQuantInstrumentos.Click += txtQuantInstrumentos_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cooper Black", 32.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.SteelBlue;
            label3.Location = new Point(660, 116);
            label3.Name = "label3";
            label3.Size = new Size(321, 49);
            label3.TabIndex = 122;
            label3.Text = "DASHBOARD";
            // 
            // cartesianChart1
            // 
            cartesianChart1.BackColor = Color.Lavender;
            cartesianChart1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cartesianChart1.Location = new Point(517, 279);
            cartesianChart1.Margin = new Padding(4);
            cartesianChart1.MatchAxesScreenDataRatio = false;
            cartesianChart1.Name = "cartesianChart1";
            cartesianChart1.Size = new Size(418, 333);
            cartesianChart1.TabIndex = 123;
            cartesianChart1.Load += cartesianChart1_Load;
            // 
            // cmbAnos
            // 
            cmbAnos.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAnos.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbAnos.FormattingEnabled = true;
            cmbAnos.Location = new Point(942, 279);
            cmbAnos.Name = "cmbAnos";
            cmbAnos.Size = new Size(142, 29);
            cmbAnos.TabIndex = 124;
            cmbAnos.SelectedIndexChanged += cmbAnos_SelectedIndexChanged;
            // 
            // cartesianChart2
            // 
            cartesianChart2.BackColor = Color.Lavender;
            cartesianChart2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cartesianChart2.Location = new Point(517, 279);
            cartesianChart2.Margin = new Padding(4);
            cartesianChart2.MatchAxesScreenDataRatio = false;
            cartesianChart2.Name = "cartesianChart2";
            cartesianChart2.Size = new Size(418, 333);
            cartesianChart2.TabIndex = 125;
            cartesianChart2.Load += cartesianChart2_Load;
            // 
            // cmbFiltraGraph
            // 
            cmbFiltraGraph.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFiltraGraph.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbFiltraGraph.FormattingEnabled = true;
            cmbFiltraGraph.Location = new Point(712, 214);
            cmbFiltraGraph.Name = "cmbFiltraGraph";
            cmbFiltraGraph.Size = new Size(223, 29);
            cmbFiltraGraph.TabIndex = 127;
            cmbFiltraGraph.SelectedIndexChanged += cmbFiltraGraph_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Lavender;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(460, 705);
            label4.Name = "label4";
            label4.Size = new Size(696, 21);
            label4.TabIndex = 128;
            label4.Text = "*Clique no botão \"Ver Alunos Aptos\", caso queira ver os alunos aptos para realizar testes.";
            // 
            // button5
            // 
            button5.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.Location = new Point(893, 619);
            button5.Name = "button5";
            button5.Size = new Size(191, 28);
            button5.TabIndex = 129;
            button5.Text = "Ver Alunos Aptos";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // cartesianChart3
            // 
            cartesianChart3.BackColor = Color.Lavender;
            cartesianChart3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cartesianChart3.Location = new Point(517, 279);
            cartesianChart3.Margin = new Padding(4);
            cartesianChart3.MatchAxesScreenDataRatio = false;
            cartesianChart3.Name = "cartesianChart3";
            cartesianChart3.Size = new Size(418, 333);
            cartesianChart3.TabIndex = 130;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 749);
            Controls.Add(cartesianChart3);
            Controls.Add(button5);
            Controls.Add(label4);
            Controls.Add(cmbFiltraGraph);
            Controls.Add(cartesianChart2);
            Controls.Add(cmbAnos);
            Controls.Add(cartesianChart1);
            Controls.Add(label3);
            Controls.Add(txtQuantInstrumentos);
            Controls.Add(pictureBox7);
            Controls.Add(panel1);
            Name = "Home";
            Text = "Home";
            Load += Home_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Button button1;
        private PictureBox pictureBox2;
        private Button button2;
        private PictureBox pictureBox3;
        private Button button3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private Button btnInstrumento;
        private Button button4;
        private PictureBox pictureBox6;
        private Label lblPerfil;
        private Label lblUsuario;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox7;
        private Label txtQuantInstrumentos;
        private Label label3;
        private LiveChartsCore.SkiaSharpView.WinForms.CartesianChart cartesianChart1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ComboBox cmbAnos;
        private LiveChartsCore.SkiaSharpView.WinForms.CartesianChart cartesianChart2;
        private ComboBox cmbFiltraGraph;
        private Label label4;
        private Button button5;
        private LiveChartsCore.SkiaSharpView.WinForms.CartesianChart cartesianChart3;
        //        private HinoPorMes hinoPorMes1;
    }
}