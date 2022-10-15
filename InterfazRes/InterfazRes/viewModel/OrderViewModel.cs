using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace InterfazRes.viewModel
{
    public class OrderViewModel : BaseViewModel
    {
        public OrderViewModel()
        {
            MenuList = GetMenu();
        }
        public List<Pick> MenuList { get; set; }
        //public ICommand BackCommand => new Command(() => ApplicationException.Current.MainPage.Navigation.PopAsync());

        public List<Pick> GetMenu()
        {
            return new List<Pick>
            {
                new Pick{Title="", Image="Hotdog.png", Description="Perro exquisito con ripio y pico de gallo", Price="23.000$"},
                new Pick{Title="", Image="hamburgesa.png", Description="Hamburguesa triple con queso, pepinillos y salsa de la casa", Price="25.000$"},
                new Pick{Title="", Image="pizza.png", Description="Pizza de champiñones con japon y 3 quesos", Price="30.000$"}
            };
        }
    }
}
