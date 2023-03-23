namespace Criando_minha_autenticacao
{
    partial class Login
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
            txt_Email = new TextBox();
            txt_Senha = new TextBox();
            lbl_Email = new Label();
            lbl_Senha = new Label();
            lbll_Senha = new LinkLabel();
            btn_Entrar = new Button();
            btn_Cadastrar = new Button();
            SuspendLayout();
            // 
            // txt_Email
            // 
            txt_Email.Location = new Point(108, 81);
            txt_Email.Name = "txt_Email";
            txt_Email.PlaceholderText = "nome@servidor.com";
            txt_Email.Size = new Size(163, 23);
            txt_Email.TabIndex = 0;
            // 
            // txt_Senha
            // 
            txt_Senha.Location = new Point(108, 139);
            txt_Senha.Name = "txt_Senha";
            txt_Senha.PasswordChar = '*';
            txt_Senha.PlaceholderText = "Abobora 123";
            txt_Senha.Size = new Size(163, 23);
            txt_Senha.TabIndex = 1;
            // 
            // lbl_Email
            // 
            lbl_Email.AutoSize = true;
            lbl_Email.Location = new Point(108, 63);
            lbl_Email.Name = "lbl_Email";
            lbl_Email.Size = new Size(106, 15);
            lbl_Email.TabIndex = 2;
            lbl_Email.Text = "Digite o seu e-mail";
            // 
            // lbl_Senha
            // 
            lbl_Senha.AutoSize = true;
            lbl_Senha.Location = new Point(108, 121);
            lbl_Senha.Name = "lbl_Senha";
            lbl_Senha.Size = new Size(93, 15);
            lbl_Senha.TabIndex = 3;
            lbl_Senha.Text = "Digite sua senha";
            // 
            // lbll_Senha
            // 
            lbll_Senha.AutoSize = true;
            lbll_Senha.Location = new Point(108, 174);
            lbll_Senha.Name = "lbll_Senha";
            lbll_Senha.Size = new Size(118, 15);
            lbll_Senha.TabIndex = 4;
            lbll_Senha.TabStop = true;
            lbll_Senha.Text = "Esqueci minha senha";
            // 
            // btn_Entrar
            // 
            btn_Entrar.Location = new Point(108, 209);
            btn_Entrar.Name = "btn_Entrar";
            btn_Entrar.Size = new Size(163, 30);
            btn_Entrar.TabIndex = 5;
            btn_Entrar.Text = "Entrar";
            btn_Entrar.UseVisualStyleBackColor = true;
            btn_Entrar.Click += button1_Click;
            // 
            // btn_Cadastrar
            // 
            btn_Cadastrar.Location = new Point(108, 256);
            btn_Cadastrar.Name = "btn_Cadastrar";
            btn_Cadastrar.Size = new Size(163, 30);
            btn_Cadastrar.TabIndex = 6;
            btn_Cadastrar.Text = "Cadastro";
            btn_Cadastrar.UseVisualStyleBackColor = true;
            btn_Cadastrar.Click += btn_Cadastrar_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(358, 460);
            Controls.Add(btn_Cadastrar);
            Controls.Add(btn_Entrar);
            Controls.Add(lbll_Senha);
            Controls.Add(lbl_Senha);
            Controls.Add(lbl_Email);
            Controls.Add(txt_Senha);
            Controls.Add(txt_Email);
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_Email;
        private TextBox txt_Senha;
        private Label lbl_Email;
        private Label lbl_Senha;
        private LinkLabel lbll_Senha;
        private Button btn_Entrar;
        private Button btn_Cadastrar;
    }
}