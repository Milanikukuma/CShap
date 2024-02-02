namespace EzCheckme
{
    public partial class MainPage : ContentPage
    {
        

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnLoginButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LogInPage());
        }

        private void OnSignInButtonClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SignInPage());
        }
    }

}
