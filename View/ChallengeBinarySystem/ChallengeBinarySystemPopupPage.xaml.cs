using CommunityToolkit.Maui.Views;
using mobile_systems_project.Model;
using mobile_systems_project.Repository;
using System.Text;

namespace mobile_systems_project.View.ChallengeBinarySystem;

public partial class ChallengeBinarySystemPopupPage : Popup
{
	List<int> numberList;
	Number[] numbers;
	NumberRepository repository = new NumberRepository();

    public ChallengeBinarySystemPopupPage( List<int> numberList)
	{
		InitializeComponent();
		this.numberList = numberList;
		numbers = repository.GetNumbers();
		PrepareOutput();

    }

	public void PrepareOutput()
	{
		if(numberList == null) { NumbersLabel.Text = " "; }
		else
		{
            StringBuilder sb = new StringBuilder();
            foreach (int number in numberList)
            {
                if (number.ToString().Length == 2)
                {
                    sb.Append(number);
                    sb.Append(" - ");

                    sb.Append(numbers[number - 1].TextualValue);

                    sb.Append('\n');
                }
                else
                {
                    sb.Append(number);
                }


            }
            NumbersLabel.Text = sb.ToString();
        }

		

    }
}