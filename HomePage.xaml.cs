namespace EzCheckme;

public partial class HomePage : ContentPage
{
	public HomePage()
	{
		InitializeComponent();
	}

   

    private void OnCheckInButtonClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new CheckInPage());
    }

    private void OnHistoryButtonClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new History());
    }

    private void OnMessagesButtonClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new MessagePage());
    }
}