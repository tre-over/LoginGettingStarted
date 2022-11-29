using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LoginGettingStarted
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginUI : ContentPage
    {
        public LoginUI()
        {
            InitializeComponent();
        }
        private void button_clicked(object sender, EventArgs e)
        {
            if(txtUsername.Text=="admin" && txtPassword.Text == "123")
            {
                Navigation.PushAsync(new Home());
            }
            else
            {
                DisplayAlert("ops...,Username or Password is incorrect");
            }
        }

        private void DisplayAlert(string v)
        {
            throw new NotImplementedException();
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Registerpage());
        }

       
    }
}