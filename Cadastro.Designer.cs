namespace Criando_minha_autenticacao
{
    partial class btn_Cadastro
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
            txt1_Email = new TextBox();
            txt1_Senha = new TextBox();
            txt_Confirmacao = new TextBox();
            lbl1_Email = new Label();
            lbl1_Senha = new Label();
            lbl_Confirmacao = new Label();
            btn_Cadastrar = new Button();
            btn_Cancelar = new Button();
            SuspendLayout();
            // 
            // txt1_Email
            // 
            txt1_Email.Location = new Point(114, 82);
            txt1_Email.Name = "txt1_Email";
            txt1_Email.Size = new Size(163, 23);
            txt1_Email.TabIndex = 1;
            // 
            // txt1_Senha
            // 
            txt1_Senha.Location = new Point(114, 139);
            txt1_Senha.Name = "txt1_Senha";
            txt1_Senha.PasswordChar = '*';
            txt1_Senha.Size = new Size(163, 23);
            txt1_Senha.TabIndex = 2;
            // 
            // txt_Confirmacao
            // 
            txt_Confirmacao.Location = new Point(114, 194);
            txt_Confirmacao.Name = "txt_Confirmacao";
            txt_Confirmacao.PasswordChar = '*';
            txt_Confirmacao.Size = new Size(163, 23);
            txt_Confirmacao.TabIndex = 3;
            // 
            // lbl1_Email
            // 
            lbl1_Email.AutoSize = true;
            lbl1_Email.Location = new Point(114, 64);
            lbl1_Email.Name = "lbl1_Email";
            lbl1_Email.Size = new Size(96, 15);
            lbl1_Email.TabIndex = 4;
            lbl1_Email.Text = "Digite seu e-mail";
            // 
            // lbl1_Senha
            // 
            lbl1_Senha.AutoSize = true;
            lbl1_Senha.Location = new Point(114, 121);
            lbl1_Senha.Name = "lbl1_Senha";
            lbl1_Senha.Size = new Size(93, 15);
            lbl1_Senha.TabIndex = 5;
            lbl1_Senha.Text = "Digite sua senha";
            // 
            // lbl_Confirmacao
            // 
            lbl_Confirmacao.AutoSize = true;
            lbl_Confirmacao.Location = new Point(114, 176);
            lbl_Confirmacao.Name = "lbl_Confirmacao";
            lbl_Confirmacao.Size = new Size(112, 15);
            lbl_Confirmacao.TabIndex = 6;
            lbl_Confirmacao.Text = "Confirme sua senha";
            // 
            // btn_Cadastrar
            // 
            btn_Cadastrar.Location = new Point(114, 240);
            btn_Cadastrar.Name = "btn_Cadastrar";
            btn_Cadastrar.Size = new Size(163, 30);
            btn_Cadastrar.TabIndex = 7;
            btn_Cadastrar.Text = "Cadastrar";
            btn_Cadastrar.UseVisualStyleBackColor = true;
            btn_Cadastrar.Click += btn_Cadastrar_Click;
            // 
            // btn_Cancelar
            // 
            btn_Cancelar.Location = new Point(114, 286);
            btn_Cancelar.Name = "btn_Cancelar";
            btn_Cancelar.Size = new Size(163, 30);
            btn_Cancelar.TabIndex = 8;
            btn_Cancelar.Text = "Cancelar";
            btn_Cancelar.UseVisualStyleBackColor = true;
            btn_Cancelar.Click += btn_Cancelar_Click;
            // 
            // btn_Cadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(397, 450);
            Controls.Add(btn_Cancelar);
            Controls.Add(btn_Cadastrar);
            Controls.Add(lbl_Confirmacao);
            Controls.Add(lbl1_Senha);
            Controls.Add(lbl1_Email);
            Controls.Add(txt_Confirmacao);
            Controls.Add(txt1_Senha);
            Controls.Add(txt1_Email);
            Name = "btn_Cadastro";
            Text = "Cadastro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt1_Email;
        private TextBox txt1_Senha;
        private TextBox txt_Confirmacao;
        private Label lbl1_Email;
        private Label lbl1_Senha;
        private Label lbl_Confirmacao;
        private Button btn_Cadastrar;
        private Button btn_Cancelar;
    }
}