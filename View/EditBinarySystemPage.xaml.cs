using mobile_systems_project.Model;
using mobile_systems_project.Repository;

namespace mobile_systems_project.View;

public partial class EditBinarySystemPage : ContentPage
{
    private Number[] numbers;
    private NumberRepository NumberRepository = new NumberRepository();

    public Number[] Numbers
    {
        get { return numbers; }
        set { numbers = value; }
    }

    public EditBinarySystemPage()
    {
        InitializeComponent();
        Numbers = NumberRepository.GetNumbers(); // Retrieve the numbers from the repository or any other data source
        NumbersListView.ItemsSource = Numbers;
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        NumberRepository.SaveNumbers(Numbers);

    }
}