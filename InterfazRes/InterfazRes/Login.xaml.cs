using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace InterfazRes
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }

        public event PropertyChangedEventHandler PropertyChanged = delegate { };
        private string email;
        private string password;

        public string Email
        {
            get { return email; }
            set
            {
                email = value;
                PropertyChanged(this, new PropertyChangedEventArgs("txtEmail"));
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


        private void Button_Clicked(object sender, EventArgs e)
        {
            String email = txtEmail.Text;
            String password = txtPassword.Text;

            if ( (email != null && password != null) && (email == "admin@imperial.co" && password == "1234") )
            {
                Application.Current.MainPage.Navigation.PushAsync(new MainPage());
            }
            else
            {
                DisplayAlert("Error", "Correo o contraseña no válido.", "Ok");
            }
        }

        private void PaginaRegistro(object sender, EventArgs e)
        {
            Application.Current.MainPage.Navigation.PushAsync(new Registro());
        }
    }
}