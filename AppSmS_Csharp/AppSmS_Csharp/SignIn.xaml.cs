using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppSmS_Csharp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SignIn : ContentPage
    {
        public SignIn()
        {
            InitializeComponent();
        }

        async private void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Forgot());
        }

        async private void ImageButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }
    }
}