using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppSmS_Csharp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SignUp : ContentPage
    {
        public SignUp()
        {
            InitializeComponent();
        }

        async private void ImageButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }
    }
}