using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Firebase.Auth;
using Firebase.Auth.Providers;
using Firebase.Auth.Repository;

namespace Criando_minha_autenticacao
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void btn_Logoff_Click(object sender, EventArgs e)
        {
            var config = new FirebaseAuthConfig
            {
                ApiKey = "AIzaSyD7FUYuXx53nZHU12X4vPgv3IxRqc7lRLI",


                AuthDomain = "fir-7094b.firebaseapp.com",
                Providers = new FirebaseAuthProvider[] 
                {
                new EmailProvider()
                },
                UserRepository = new FileUserRepository("NossosDados")
            };
            var Cliente = new FirebaseAuthClient(config);
            Cliente.SignOut();
        }
    }
}
