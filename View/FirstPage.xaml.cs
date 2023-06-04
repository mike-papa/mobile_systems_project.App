namespace mobile_systems_project.View;

public partial class FirstPage : ContentPage
{
	public FirstPage()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new EditBinarySystemPage());
    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {
        Navigation.PushAsync(new LearnBinarySystemPage());
    }

    private void Button_Clicked_2(object sender, EventArgs e)
    {
        Navigation.PushAsync(new ChallengeBinarySystem.ChallengeBinarySystemPage());
    }
}