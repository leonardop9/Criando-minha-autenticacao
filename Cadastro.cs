using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FirebaseAdmin;
using FirebaseAdmin.Auth;
using Google.Apis.Auth.OAuth2;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;


namespace Criando_minha_autenticacao
{
    public partial class btn_Cadastro : Form
    {
        FirebaseAuth auth = FirebaseAuth.DefaultInstance;
        public btn_Cadastro()
        {
            InitializeComponent();
            FirebaseApp.Create(new AppOptions()
            {

                Credential = GoogleCredential.FromFile("C:\\Users\\leonardo.palmeida3\\source\\repos\\Criando minha autenticacao\\bin\\Debug\\net6.0-windows\\Auth.json")
            });
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            Hide();
            login.Closed += fecharFormulario;
            login.Show();
        }
        private void fecharFormulario(object? enviado, EventArgs args)
        {
            this.Close();
        }

        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {

            if (txt1_Senha.Text != txt_Confirmacao.Text)
            {
                MessageBox.Show("As senhas não batem, favor revisar");
                return;
            }
            if (txt1_Senha.Text.Length <= 8)
            {
                MessageBox.Show("Digite um sneha com no minimo 8 caracteres");
                return;

            }

            try
            {
                var usuario = FirebaseAuth.DefaultInstance.CreateUserAsync(new UserRecordArgs()
                {

                    Email = txt1_Email.Text,
                    Password = txt1_Senha.Text,
                }).Result;
                MessageBox.Show(usuario.Uid);
                MessageBox.Show(usuario.EmailVerified.ToString());

                Principal principal = new Principal();
                Hide();
                principal.Closed += fecharFormulario;
                principal.Show();
            }
            catch (Exception ex)
            {
                if(ex.Message.Contains("One or more errors occurred. (The user with the provieded email already exists(EMAIL_EXISTS).)")) 
                     {      
                       MessageBox.Show(ex.Message);
                     }
                else { 
                       MessageBox.Show("Erroe:" + ex.Message); //Clipboard.SetText(ex.Message 
                     }
           
            }
        }
    }
}
