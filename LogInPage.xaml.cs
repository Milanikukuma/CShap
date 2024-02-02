namespace EzCheckme;

public partial class LogInPage : ContentPage
{
	public LogInPage()
	{
		InitializeComponent();
	}
    private void OnEnterButtonClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new HomePage());
    }
}