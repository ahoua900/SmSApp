using System;
using System.Collections.Generic;
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

       async  private void Button_Clicked(object sender, EventArgs e)
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

            List<Données> list = new List<Données>(){ Ami, Elvis, Oliver, Alex };

            if (email.Text != Elvis.email || password.Text != Elvis.password)
            {
                error.Text = "vous n'etes pas de l'equipe C# ou l'email est incorrect";
            }
            else
            {
                 correct.Text = "Inscription reussie !";
                 await Navigation.PushAsync(new Account());
            }

            if (email.Text != Oliver.email || password.Text != Oliver.password)
            {
                error.Text = "vous n'etes pas de l'equipe C# ou l'email est incorrect";
            }
            else
            {
                correct.Text = "Inscription reussie !";
                await Navigation.PushAsync(new Account());
            }

            if (email.Text != Alex.email || password.Text != Alex.password)
            {
                error.Text = "vous n'etes pas de l'equipe C# ou l'email est incorrect";
            }
            else
            {
                correct.Text = "Inscription reussie !";
                await Navigation.PushAsync(new Account());
            }

            if (email.Text !=Ami.email || password.Text != Ami.password)
            {
                error.Text = "vous n'etes pas de l'equipe C# ou l'email est incorrect";
            }
            else
            {
                error.IsVisible = false;
                correct.Text = "Inscription reussie !";
                await Navigation.PushAsync(new Account());
            }
        }
    }
}