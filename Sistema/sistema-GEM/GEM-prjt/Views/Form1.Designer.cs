namespace IgrejaMVC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            pictureBox4 = new PictureBox();
            btnProfessores = new Button();
            pictureBox2 = new PictureBox();
            pictureBox5 = new PictureBox();
            btnInstrumento = new Button();
            button4 = new Button();
            pictureBox6 = new PictureBox();
            button5 = new Button();
            pictureBox7 = new PictureBox();
            button6 = new Button();
            pictureBox8 = new PictureBox();
            txtInstrumento = new ComboBox();
            txtDtNascimento = new DateTimePicker();
            txtDtInicio = new DateTimePicker();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            txtEndereco = new TextBox();
            label11 = new Label();
            txtNumero = new TextBox();
            label10 = new Label();
            txtCEP = new TextBox();
            label9 = new Label();
            label2 = new Label();
            txtEmail = new TextBox();
            label7 = new Label();
            txtTelefone = new TextBox();
            label3 = new Label();
            label6 = new Label();
            txtCPF = new TextBox();
            label5 = new Label();
            txtNome = new TextBox();
            label4 = new Label();
            DtCadastro = new Label();
            label1 = new Label();
            btnSalvar = new Button();
            txtEstadoCivil = new ComboBox();
            label8 = new Label();
            btnFoto = new Button();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox9 = new PictureBox();
            txtBairroA = new TextBox();
            txtCidade = new TextBox();
            txtEstado = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Lavender;
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(btnProfessores);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox5);
            panel1.Controls.Add(btnInstrumento);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(pictureBox6);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(pictureBox7);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(pictureBox8);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(281, 749);
            panel1.TabIndex = 16;
            panel1.Paint += panel1_Paint;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(29, 484);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(47, 32);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 122;
            pictureBox4.TabStop = false;
            // 
            // btnProfessores
            // 
            btnProfessores.BackColor = Color.Lavender;
            btnProfessores.FlatAppearance.BorderSize = 0;
            btnProfessores.FlatStyle = FlatStyle.Flat;
            btnProfessores.Font = new Font("Century Gothic", 14F);
            btnProfessores.ForeColor = Color.SteelBlue;
            btnProfessores.Location = new Point(0, 475);
            btnProfessores.Name = "btnProfessores";
            btnProfessores.Size = new Size(281, 55);
            btnProfessores.TabIndex = 121;
            btnProfessores.Text = "Docentes";
            btnProfessores.UseVisualStyleBackColor = false;
            btnProfessores.Click += btnProfessores_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(29, 423);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(47, 32);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 77;
            pictureBox2.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.icons8_adicionar_grupo_de_usuários_mulher_homem_30;
            pictureBox5.Location = new Point(29, 366);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(47, 32);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 8;
            pictureBox5.TabStop = false;
            // 
            // btnInstrumento
            // 
            btnInstrumento.BackColor = Color.Lavender;
            btnInstrumento.FlatAppearance.BorderSize = 0;
            btnInstrumento.FlatStyle = FlatStyle.Flat;
            btnInstrumento.Font = new Font("Century Gothic", 14F);
            btnInstrumento.ForeColor = Color.SteelBlue;
            btnInstrumento.Location = new Point(3, 414);
            btnInstrumento.Name = "btnInstrumento";
            btnInstrumento.Size = new Size(281, 55);
            btnInstrumento.TabIndex = 76;
            btnInstrumento.Text = "Cadastrar\r\n Instrumento";
            btnInstrumento.UseVisualStyleBackColor = false;
            btnInstrumento.Click += btnInstrumento_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.Control;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Century Gothic", 14F);
            button4.ForeColor = Color.SteelBlue;
            button4.Location = new Point(0, 352);
            button4.Name = "button4";
            button4.Size = new Size(281, 55);
            button4.TabIndex = 7;
            button4.Text = "Novo Aluno";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(29, 304);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(47, 32);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 6;
            pictureBox6.TabStop = false;
            // 
            // button5
            // 
            button5.BackColor = Color.Lavender;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Century Gothic", 14F);
            button5.ForeColor = Color.SteelBlue;
            button5.Location = new Point(0, 298);
            button5.Name = "button5";
            button5.Size = new Size(281, 48);
            button5.TabIndex = 5;
            button5.Text = "Alunos";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(29, 252);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(47, 32);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 4;
            pictureBox7.TabStop = false;
            // 
            // button6
            // 
            button6.BackColor = Color.Lavender;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Century Gothic", 14F);
            button6.ForeColor = Color.SteelBlue;
            button6.Location = new Point(3, 244);
            button6.Name = "button6";
            button6.Size = new Size(278, 48);
            button6.TabIndex = 1;
            button6.Text = "DashBoard";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = Properties.Resources.logo_ccb_light;
            pictureBox8.Location = new Point(12, 31);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(251, 134);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 0;
            pictureBox8.TabStop = false;
            // 
            // txtInstrumento
            // 
            txtInstrumento.DisplayMember = "nome_instrumento";
            txtInstrumento.DropDownStyle = ComboBoxStyle.DropDownList;
            txtInstrumento.Font = new Font("Century Gothic", 12F);
            txtInstrumento.FormattingEnabled = true;
            txtInstrumento.Location = new Point(1029, 325);
            txtInstrumento.Name = "txtInstrumento";
            txtInstrumento.Size = new Size(154, 29);
            txtInstrumento.TabIndex = 70;
            txtInstrumento.ValueMember = "id";
            txtInstrumento.SelectedIndexChanged += txtInstrumento_SelectedIndexChanged;
            // 
            // txtDtNascimento
            // 
            txtDtNascimento.CustomFormat = "dd/MM/yyyy";
            txtDtNascimento.Font = new Font("Century Gothic", 12F);
            txtDtNascimento.Location = new Point(878, 326);
            txtDtNascimento.Name = "txtDtNascimento";
            txtDtNascimento.Size = new Size(125, 27);
            txtDtNascimento.TabIndex = 69;
            // 
            // txtDtInicio
            // 
            txtDtInicio.CustomFormat = "dd/MM/yyyy";
            txtDtInicio.Font = new Font("Century Gothic", 12F);
            txtDtInicio.Location = new Point(736, 247);
            txtDtInicio.Name = "txtDtInicio";
            txtDtInicio.Size = new Size(122, 27);
            txtDtInicio.TabIndex = 68;
            txtDtInicio.ValueChanged += txtDtInicio_ValueChanged_1;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.SteelBlue;
            label14.Location = new Point(1093, 516);
            label14.Name = "label14";
            label14.RightToLeft = RightToLeft.Yes;
            label14.Size = new Size(64, 21);
            label14.TabIndex = 66;
            label14.Text = "Estado";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.SteelBlue;
            label13.Location = new Point(923, 516);
            label13.Name = "label13";
            label13.RightToLeft = RightToLeft.Yes;
            label13.Size = new Size(69, 21);
            label13.TabIndex = 64;
            label13.Text = "Cidade";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.SteelBlue;
            label12.Location = new Point(736, 516);
            label12.Name = "label12";
            label12.RightToLeft = RightToLeft.Yes;
            label12.Size = new Size(53, 21);
            label12.TabIndex = 62;
            label12.Text = "Bairro";
            // 
            // txtEndereco
            // 
            txtEndereco.Font = new Font("Century Gothic", 12F);
            txtEndereco.Location = new Point(860, 475);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(260, 27);
            txtEndereco.TabIndex = 61;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.SteelBlue;
            label11.Location = new Point(860, 448);
            label11.Name = "label11";
            label11.RightToLeft = RightToLeft.Yes;
            label11.Size = new Size(85, 21);
            label11.TabIndex = 60;
            label11.Text = "Endereço";
            // 
            // txtNumero
            // 
            txtNumero.Font = new Font("Century Gothic", 12F);
            txtNumero.Location = new Point(1129, 475);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(54, 27);
            txtNumero.TabIndex = 59;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.SteelBlue;
            label10.Location = new Point(1129, 448);
            label10.Name = "label10";
            label10.RightToLeft = RightToLeft.Yes;
            label10.Size = new Size(28, 21);
            label10.TabIndex = 58;
            label10.Text = "Nº";
            // 
            // txtCEP
            // 
            txtCEP.Font = new Font("Century Gothic", 12F);
            txtCEP.Location = new Point(736, 475);
            txtCEP.Name = "txtCEP";
            txtCEP.Size = new Size(106, 27);
            txtCEP.TabIndex = 57;
            txtCEP.TextChanged += txtCEP_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.SteelBlue;
            label9.Location = new Point(736, 448);
            label9.Name = "label9";
            label9.RightToLeft = RightToLeft.Yes;
            label9.Size = new Size(41, 21);
            label9.TabIndex = 56;
            label9.Text = "CEP";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.SteelBlue;
            label2.Location = new Point(1029, 299);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.Yes;
            label2.Size = new Size(105, 21);
            label2.TabIndex = 55;
            label2.Text = "Instrumento";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Century Gothic", 12F);
            txtEmail.Location = new Point(923, 409);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(260, 27);
            txtEmail.TabIndex = 54;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.SteelBlue;
            label7.Location = new Point(923, 382);
            label7.Name = "label7";
            label7.RightToLeft = RightToLeft.Yes;
            label7.Size = new Size(56, 21);
            label7.TabIndex = 53;
            label7.Text = "E-mail";
            // 
            // txtTelefone
            // 
            txtTelefone.Font = new Font("Century Gothic", 12F);
            txtTelefone.Location = new Point(736, 409);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(154, 27);
            txtTelefone.TabIndex = 52;
            txtTelefone.TextChanged += txtTelefone_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.SteelBlue;
            label3.Location = new Point(736, 382);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.Yes;
            label3.Size = new Size(76, 21);
            label3.TabIndex = 51;
            label3.Text = "Telefone";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.SteelBlue;
            label6.Location = new Point(890, 299);
            label6.Name = "label6";
            label6.RightToLeft = RightToLeft.Yes;
            label6.Size = new Size(123, 21);
            label6.TabIndex = 50;
            label6.Text = "DtNascimento";
            // 
            // txtCPF
            // 
            txtCPF.Font = new Font("Century Gothic", 12F);
            txtCPF.Location = new Point(736, 326);
            txtCPF.Name = "txtCPF";
            txtCPF.Size = new Size(122, 27);
            txtCPF.TabIndex = 49;
            txtCPF.TextChanged += txtCPF_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.SteelBlue;
            label5.Location = new Point(736, 299);
            label5.Name = "label5";
            label5.Size = new Size(40, 21);
            label5.TabIndex = 48;
            label5.Text = "CPF";
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Century Gothic", 12F);
            txtNome.Location = new Point(878, 247);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(309, 27);
            txtNome.TabIndex = 47;
            txtNome.TextChanged += txtNome_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.SteelBlue;
            label4.Location = new Point(878, 220);
            label4.Name = "label4";
            label4.Size = new Size(132, 21);
            label4.TabIndex = 46;
            label4.Text = "Nome do Aluno";
            // 
            // DtCadastro
            // 
            DtCadastro.AutoSize = true;
            DtCadastro.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DtCadastro.ForeColor = Color.SteelBlue;
            DtCadastro.Location = new Point(736, 220);
            DtCadastro.Name = "DtCadastro";
            DtCadastro.Size = new Size(103, 21);
            DtCadastro.TabIndex = 45;
            DtCadastro.Text = "DtCadastro";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cooper Black", 32.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SteelBlue;
            label1.Location = new Point(623, 116);
            label1.Name = "label1";
            label1.Size = new Size(564, 49);
            label1.TabIndex = 43;
            label1.Text = "CADASTRO DE ALUNOS";
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.SteelBlue;
            btnSalvar.FlatAppearance.BorderSize = 0;
            btnSalvar.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalvar.ForeColor = SystemColors.ControlLightLight;
            btnSalvar.Location = new Point(964, 603);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(223, 34);
            btnSalvar.TabIndex = 75;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // txtEstadoCivil
            // 
            txtEstadoCivil.DropDownStyle = ComboBoxStyle.DropDownList;
            txtEstadoCivil.Font = new Font("Century Gothic", 12F);
            txtEstadoCivil.FormattingEnabled = true;
            txtEstadoCivil.Items.AddRange(new object[] { "Casado", "Solteiro", "Divorciado", "Viúvo" });
            txtEstadoCivil.Location = new Point(736, 612);
            txtEstadoCivil.Name = "txtEstadoCivil";
            txtEstadoCivil.Size = new Size(132, 29);
            txtEstadoCivil.TabIndex = 74;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.SteelBlue;
            label8.Location = new Point(735, 588);
            label8.Name = "label8";
            label8.RightToLeft = RightToLeft.Yes;
            label8.Size = new Size(100, 21);
            label8.TabIndex = 73;
            label8.Text = "Estado Civil";
            // 
            // btnFoto
            // 
            btnFoto.BackColor = Color.SteelBlue;
            btnFoto.FlatAppearance.BorderSize = 0;
            btnFoto.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFoto.ForeColor = SystemColors.ControlLightLight;
            btnFoto.Location = new Point(468, 603);
            btnFoto.Name = "btnFoto";
            btnFoto.Size = new Size(219, 34);
            btnFoto.TabIndex = 71;
            btnFoto.Text = "Escolher Foto";
            btnFoto.UseVisualStyleBackColor = false;
            btnFoto.Click += btnFoto_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(442, 273);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(274, 279);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 44;
            pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(1248, 12);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(59, 41);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 121;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click_1;
            // 
            // pictureBox9
            // 
            pictureBox9.Image = (Image)resources.GetObject("pictureBox9.Image");
            pictureBox9.Location = new Point(1313, 12);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(45, 41);
            pictureBox9.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox9.TabIndex = 122;
            pictureBox9.TabStop = false;
            pictureBox9.Click += pictureBox9_Click;
            // 
            // txtBairroA
            // 
            txtBairroA.Font = new Font("Century Gothic", 12F);
            txtBairroA.Location = new Point(736, 542);
            txtBairroA.Name = "txtBairroA";
            txtBairroA.Size = new Size(154, 27);
            txtBairroA.TabIndex = 123;
            // 
            // txtCidade
            // 
            txtCidade.Font = new Font("Century Gothic", 12F);
            txtCidade.Location = new Point(923, 542);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(121, 27);
            txtCidade.TabIndex = 125;
            // 
            // txtEstado
            // 
            txtEstado.Font = new Font("Century Gothic", 12F);
            txtEstado.Location = new Point(1093, 542);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(94, 27);
            txtEstado.TabIndex = 126;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 749);
            Controls.Add(txtEstado);
            Controls.Add(txtCidade);
            Controls.Add(txtBairroA);
            Controls.Add(pictureBox9);
            Controls.Add(pictureBox3);
            Controls.Add(btnSalvar);
            Controls.Add(txtEstadoCivil);
            Controls.Add(label8);
            Controls.Add(btnFoto);
            Controls.Add(txtInstrumento);
            Controls.Add(txtDtNascimento);
            Controls.Add(txtDtInicio);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(txtEndereco);
            Controls.Add(label11);
            Controls.Add(txtNumero);
            Controls.Add(label10);
            Controls.Add(txtCEP);
            Controls.Add(label9);
            Controls.Add(label2);
            Controls.Add(txtEmail);
            Controls.Add(label7);
            Controls.Add(txtTelefone);
            Controls.Add(label3);
            Controls.Add(label6);
            Controls.Add(txtCPF);
            Controls.Add(label5);
            Controls.Add(txtNome);
            Controls.Add(label4);
            Controls.Add(DtCadastro);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox5;
        private Button button4;
        private PictureBox pictureBox6;
        private Button button5;
        private PictureBox pictureBox7;
        private Button button6;
        private PictureBox pictureBox8;
        private ComboBox txtInstrumento;
        private DateTimePicker txtDtNascimento;
        private DateTimePicker txtDtInicio;
        private Label label14;
        private Label label13;
        private Label label12;
        private TextBox txtEndereco;
        private Label label11;
        private TextBox txtNumero;
        private Label label10;
        private TextBox txtCEP;
        private Label label9;
        private Label label2;
        private TextBox txtEmail;
        private Label label7;
        private TextBox txtTelefone;
        private Label label3;
        private Label label6;
        private TextBox txtCPF;
        private Label label5;
        private TextBox txtNome;
        private Label label4;
        private Label DtCadastro;
        private Label label1;
        private Button btnSalvar;
        private ComboBox txtEstadoCivil;
        private Label label8;
        private Button btnFoto;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button btnInstrumento;
        private Button btnProfessores;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox9;
        private TextBox txtBairroA;
        public TextBox txtCidade;
        public TextBox txtEstado;
    }
}
