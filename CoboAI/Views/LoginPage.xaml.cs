namespace CoboAI;

public partial class LoginPage : ContentPage
{
    public LoginPage()
    {
        InitializeComponent();
    }

    private async void OnLoginClicked(object sender, EventArgs e)
    {
        // For now just navigate to the main app shell
        Application.Current.MainPage = new AppShell();
        await Task.CompletedTask;
    }
}
