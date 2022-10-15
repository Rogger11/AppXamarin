using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace InterfazRes
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registro : ContentPage
    {
        public Registro()
        {
            InitializeComponent();
        }

        public event PropertyChangedEventHandler PropertyChanged = delegate { };
        private string email;
        private string password;
        private string password2;

        public string Email
        {
            get { return email; }
            set
            {
                email = value;
                PropertyChanged(this, new PropertyChangedEventArgs("txtEmail"));
            }
        }
        public string Password2
        {
            get { return password2; }
            set
            {
                password2 = value;
                PropertyChanged(this, new PropertyChangedEventArgs("txtPassword2"));
            }
        }

        public string Password
        {
            get { return password; }
            set
            {
                password = value;
                PropertyChanged(this, new PropertyChangedEventArgs("txtPassword"));
            }
        }

        private void BotonRegistrarse(object sender, EventArgs e)
        {
            String email = txtEmail.Text;
            String password = txtPassword.Text;
            String password2 = txtPassword2.Text;

            if (email == null || password == null || password2 == null)
            {
                DisplayAlert("Alerta", "Todos los campos son obligatorios.", "Ok");
            }
            else if ((!(email.ToString().Contains("@")) || password != password2)) 
            {
                DisplayAlert("Alerta", "Contraseña o correo incorrectos.", "Ok");
            }
            else
            {
                Application.Current.MainPage.Navigation.PushAsync(new MainPage());
            }
        }

        private void PaginaLogin(object sender, EventArgs e)
        {
            Application.Current.MainPage.Navigation.PushAsync(new Page1());
        }

    }
}