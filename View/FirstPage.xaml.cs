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
}