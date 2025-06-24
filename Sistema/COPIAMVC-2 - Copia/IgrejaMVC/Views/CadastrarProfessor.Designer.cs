namespace IgrejaMVC.Views
{
    partial class CadastrarProfessor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastrarProfessor));
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            pictureBox4 = new PictureBox();
            txtCadSenhaProfessor = new TextBox();
            txtCadNomeProfessor = new TextBox();
            btnCadastrarprof = new Button();
            label3 = new Label();
            pictureBox3 = new PictureBox();
            textRepitaSenha = new TextBox();
            cmbPerfil = new ComboBox();
            pictureBox6 = new PictureBox();
            pictureBox5 = new PictureBox();
            txtSenhaChave = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(939, 451);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 64;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cooper Black", 32.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SteelBlue;
            label1.Location = new Point(869, 275);
            label1.Name = "label1";
            label1.Size = new Size(389, 49);
            label1.TabIndex = 62;
            label1.Text = "CADASTRAR-SE";
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(880, 394);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 27);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 61;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(880, 346);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(50, 27);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 60;
            pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Lavender;
            panel2.Controls.Add(pictureBox4);
            panel2.Location = new Point(0, -1);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(683, 771);
            panel2.TabIndex = 59;
            panel2.Paint += panel2_Paint;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.logo_ccb_light;
            pictureBox4.Location = new Point(71, 234);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(532, 346);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 8;
            pictureBox4.TabStop = false;
            // 
            // txtCadSenhaProfessor
            // 
            txtCadSenhaProfessor.BorderStyle = BorderStyle.FixedSingle;
            txtCadSenhaProfessor.Font = new Font("Century Gothic", 12F);
            txtCadSenhaProfessor.Location = new Point(935, 394);
            txtCadSenhaProfessor.Margin = new Padding(3, 4, 3, 4);
            txtCadSenhaProfessor.MaxLength = 20;
            txtCadSenhaProfessor.Name = "txtCadSenhaProfessor";
            txtCadSenhaProfessor.PlaceholderText = "Digite a sua senha";
            txtCadSenhaProfessor.Size = new Size(288, 27);
            txtCadSenhaProfessor.TabIndex = 58;
            txtCadSenhaProfessor.UseSystemPasswordChar = true;
            // 
            // txtCadNomeProfessor
            // 
            txtCadNomeProfessor.BorderStyle = BorderStyle.FixedSingle;
            txtCadNomeProfessor.Font = new Font("Century Gothic", 12F);
            txtCadNomeProfessor.Location = new Point(936, 346);
            txtCadNomeProfessor.Margin = new Padding(3, 4, 3, 4);
            txtCadNomeProfessor.MaxLength = 60;
            txtCadNomeProfessor.Name = "txtCadNomeProfessor";
            txtCadNomeProfessor.PlaceholderText = "Digite o seu nome";
            txtCadNomeProfessor.Size = new Size(289, 27);
            txtCadNomeProfessor.TabIndex = 57;
            // 
            // btnCadastrarprof
            // 
            btnCadastrarprof.BackColor = Color.SteelBlue;
            btnCadastrarprof.FlatAppearance.BorderColor = Color.Black;
            btnCadastrarprof.Font = new Font("Century Gothic", 12F);
            btnCadastrarprof.Location = new Point(935, 584);
            btnCadastrarprof.Margin = new Padding(3, 4, 3, 4);
            btnCadastrarprof.Name = "btnCadastrarprof";
            btnCadastrarprof.Size = new Size(289, 41);
            btnCadastrarprof.TabIndex = 56;
            btnCadastrarprof.Text = "Cadastrar";
            btnCadastrarprof.UseVisualStyleBackColor = false;
            btnCadastrarprof.Click += btnCadastrarprof_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(939, 510);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 67;
            // 
            // pictureBox3
            // 
            pictureBox3.Cursor = Cursors.Hand;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(880, 439);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(50, 27);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 66;
            pictureBox3.TabStop = false;
            // 
            // textRepitaSenha
            // 
            textRepitaSenha.BorderStyle = BorderStyle.FixedSingle;
            textRepitaSenha.Font = new Font("Century Gothic", 12F);
            textRepitaSenha.Location = new Point(935, 439);
            textRepitaSenha.Margin = new Padding(3, 4, 3, 4);
            textRepitaSenha.MaxLength = 20;
            textRepitaSenha.Name = "textRepitaSenha";
            textRepitaSenha.PlaceholderText = "Repita a senha digitada";
            textRepitaSenha.Size = new Size(288, 27);
            textRepitaSenha.TabIndex = 65;
            textRepitaSenha.UseSystemPasswordChar = true;
            textRepitaSenha.TextChanged += textBox1_TextChanged;
            // 
            // cmbPerfil
            // 
            cmbPerfil.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPerfil.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbPerfil.FormattingEnabled = true;
            cmbPerfil.Items.AddRange(new object[] { "Administrador", "Professor" });
            cmbPerfil.Location = new Point(936, 488);
            cmbPerfil.Name = "cmbPerfil";
            cmbPerfil.Size = new Size(288, 29);
            cmbPerfil.TabIndex = 68;
            cmbPerfil.SelectedIndexChanged += cmbPerfil_SelectedIndexChanged;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(1250, 12);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(57, 41);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 121;
            pictureBox6.TabStop = false;
            pictureBox6.Click += pictureBox6_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(1313, 12);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(45, 41);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 123;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // txtSenhaChave
            // 
            txtSenhaChave.BorderStyle = BorderStyle.FixedSingle;
            txtSenhaChave.Font = new Font("Century Gothic", 12F);
            txtSenhaChave.Location = new Point(935, 538);
            txtSenhaChave.Margin = new Padding(3, 4, 3, 4);
            txtSenhaChave.MaxLength = 20;
            txtSenhaChave.Name = "txtSenhaChave";
            txtSenhaChave.PlaceholderText = "Digite a senha chave";
            txtSenhaChave.Size = new Size(288, 27);
            txtSenhaChave.TabIndex = 124;
            txtSenhaChave.UseSystemPasswordChar = true;
            txtSenhaChave.TextChanged += txtSenhaChave_TextChanged;
            // 
            // CadastrarProfessor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 749);
            Controls.Add(txtSenhaChave);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox6);
            Controls.Add(cmbPerfil);
            Controls.Add(label3);
            Controls.Add(pictureBox3);
            Controls.Add(textRepitaSenha);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Controls.Add(panel2);
            Controls.Add(txtCadSenhaProfessor);
            Controls.Add(txtCadNomeProfessor);
            Controls.Add(btnCadastrarprof);
            Name = "CadastrarProfessor";
            Text = "CadastrarProfessor";
            Load += CadastrarProfessor_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Panel panel2;
        private PictureBox pictureBox4;
        private TextBox txtCadSenhaProfessor;
        private TextBox txtCadNomeProfessor;
        private Button btnCadastrarprof;
        private Label label3;
        private PictureBox pictureBox3;
        private TextBox textRepitaSenha;
        private ComboBox cmbPerfil;
        private PictureBox pictureBox6;
        private PictureBox pictureBox5;
        private TextBox txtSenhaChave;
    }
}