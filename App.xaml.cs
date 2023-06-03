using mobile_systems_project.View;

namespace mobile_systems_project;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new NavigationPage(new FirstPage());
	}
}
