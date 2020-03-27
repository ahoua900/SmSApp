using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppSmS_Csharp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Forgot : ContentPage
    {
        public Forgot()
        {
            InitializeComponent();
        }

        async private void ImageButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SignIn());
        }
    }
}