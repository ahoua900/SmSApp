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

       async private void Button_Clicked(object sender, EventArgs e)
        {
            Données Elvis = new Données();
            Elvis.email = "elvisahoua@gmail.com";
            Elvis.password = "elv1234";

            Données Alex = new Données();
            Alex.email = "kafaloalex@gmail.com";
            Alex.password = "ale1234";

            Données Oliver = new Données();
            Oliver.email = "kraolivier@gmail.com";
            Oliver.password = "oli1234";

            Données Ami = new Données();
            Ami.email = "amitraore@gmail.com";
            Ami.password = "ami1234";

            if (email.Text == Ami.email)
            {
                pull.Text = Ami.password;
            }
            else
            {
                pull.Text = "Non reconnu";
            }

            if (email.Text != Elvis.email)
            {
                 pull.Text = "Non reconnu";
            }
            else
            {
                pull.Text = Elvis.password;
            }

            if (email.Text == Oliver.email)
            {
                pull.Text = Oliver.password;
            }
            else
            {
                pull.Text = "Non reconnu";
            }

            if (email.Text == Alex.email)
            {
                pull.Text = Alex.password;
            }
            else
            {
                pull.Text = "Non reconnu";
            }
        }
    }
}