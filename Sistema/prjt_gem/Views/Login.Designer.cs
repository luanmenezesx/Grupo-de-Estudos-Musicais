namespace IgrejaMVC.Views
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            btnSair = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            pictureBox4 = new PictureBox();
            txtSenhaProfessor = new TextBox();
            txtNomeProfessor = new TextBox();
            btnAcessar = new Button();
            label2 = new Label();
            linkLabel1 = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // btnSair
            // 
            btnSair.BackColor = Color.FromArgb(255, 128, 128);
            btnSair.FlatAppearance.BorderColor = Color.Black;
            btnSair.Font = new Font("Century Gothic", 12F);
            btnSair.Location = new Point(933, 479);
            btnSair.Margin = new Padding(3, 4, 3, 4);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(288, 41);
            btnSair.TabIndex = 53;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cooper Black", 32.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SteelBlue;
            label1.Location = new Point(865, 254);
            label1.Name = "label1";
            label1.Size = new Size(379, 49);
            label1.TabIndex = 52;
            label1.Text = "TELA DE LOGIN";
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(876, 386);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 27);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 51;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(876, 325);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(50, 27);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 50;
            pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Lavender;
            panel2.Controls.Add(pictureBox4);
            panel2.Location = new Point(1, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(683, 771);
            panel2.TabIndex = 49;
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
            // txtSenhaProfessor
            // 
            txtSenhaProfessor.BorderStyle = BorderStyle.FixedSingle;
            txtSenhaProfessor.Font = new Font("Century Gothic", 12F);
            txtSenhaProfessor.Location = new Point(932, 390);
            txtSenhaProfessor.Margin = new Padding(3, 4, 3, 4);
            txtSenhaProfessor.MaxLength = 20;
            txtSenhaProfessor.Name = "txtSenhaProfessor";
            txtSenhaProfessor.PlaceholderText = "Digite a sua senha";
            txtSenhaProfessor.Size = new Size(288, 27);
            txtSenhaProfessor.TabIndex = 48;
            txtSenhaProfessor.UseSystemPasswordChar = true;
            // 
            // txtNomeProfessor
            // 
            txtNomeProfessor.BorderStyle = BorderStyle.FixedSingle;
            txtNomeProfessor.Font = new Font("Century Gothic", 12F);
            txtNomeProfessor.Location = new Point(932, 329);
            txtNomeProfessor.Margin = new Padding(3, 4, 3, 4);
            txtNomeProfessor.MaxLength = 60;
            txtNomeProfessor.Name = "txtNomeProfessor";
            txtNomeProfessor.PlaceholderText = "Digite o seu nome";
            txtNomeProfessor.Size = new Size(289, 27);
            txtNomeProfessor.TabIndex = 47;
            // 
            // btnAcessar
            // 
            btnAcessar.BackColor = Color.SteelBlue;
            btnAcessar.FlatAppearance.BorderColor = Color.Black;
            btnAcessar.Font = new Font("Century Gothic", 12F);
            btnAcessar.Location = new Point(935, 430);
            btnAcessar.Margin = new Padding(3, 4, 3, 4);
            btnAcessar.Name = "btnAcessar";
            btnAcessar.Size = new Size(286, 41);
            btnAcessar.TabIndex = 46;
            btnAcessar.Text = "Acessar";
            btnAcessar.UseVisualStyleBackColor = false;
            btnAcessar.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(935, 430);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 54;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel1.Location = new Point(993, 524);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(227, 20);
            linkLabel1.TabIndex = 55;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Clique aqui para cadastrar-se";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 749);
            Controls.Add(linkLabel1);
            Controls.Add(label2);
            Controls.Add(btnSair);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Controls.Add(panel2);
            Controls.Add(txtSenhaProfessor);
            Controls.Add(txtNomeProfessor);
            Controls.Add(btnAcessar);
            Name = "Login";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSair;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Panel panel2;
        private PictureBox pictureBox4;
        private TextBox txtSenhaProfessor;
        private TextBox txtNomeProfessor;
        private Button btnAcessar;
        private Label label2;
        private LinkLabel linkLabel1;
    }
}