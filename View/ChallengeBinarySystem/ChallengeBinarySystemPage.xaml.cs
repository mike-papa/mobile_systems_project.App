using CommunityToolkit.Maui.Views;
using System.Text;

namespace mobile_systems_project.View.ChallengeBinarySystem;

public partial class ChallengeBinarySystemPage : ContentPage
{
    private int numberOfDigits;
    private List<int> digitsList;
    private List<int> numberList;
    string output;
    public ChallengeBinarySystemPage()
	{
		InitializeComponent();
	}



    private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
        ChallengeBinarySystemPopupPage popup = new ChallengeBinarySystemPopupPage(numberList);

        this.ShowPopupAsync(popup);
    }

    private void SwipeGestureRecognizer_Swiped(object sender, SwipedEventArgs e)
    {
        switch (e.Direction)
        {
            case SwipeDirection.Left:
                FormattedNumberListLabel.Text = "a";
                updateOutput();
                break;
            case SwipeDirection.Right:
                updateOutput();
                break;
        }
    }

    private void Entry_TextChanged(object sender, TextChangedEventArgs e)
    {
        if(e.NewTextValue != null && int.TryParse(e.NewTextValue, out int number))
        {
            numberOfDigits = int.Parse(e.NewTextValue);
        }
        
    }

    private void GenerateRandomNumber()
    {
        digitsList = new List<int>();
        Random random = new Random();
        for(int i = 0;i< numberOfDigits;i++)
        {
            digitsList.Add(random.Next(1,10));
        }

    }

    public void FormatNumberList()
    {
        StringBuilder formattedString = new StringBuilder();

        for (int i = 0; i < digitsList.Count; i += 2)
        {
            if (i != 0)
            {
                // Add a space and a hyphen before each pair of numbers except the first one
                formattedString.Append(" - ");
            }

            // Get the first number in the pair
            int firstNumber = digitsList[i];
            formattedString.Append(firstNumber);

            // Check if there is a second number in the pair
            if (i + 1 < digitsList.Count)
            {
                // Get the second number in the pair
                int secondNumber = digitsList[i + 1];
                formattedString.Append(" ");
                formattedString.Append(secondNumber);
            }
        }

        output = formattedString.ToString();
    }
    public void updateOutput()
    {
        GenerateRandomNumber();
        FormatNumberList();
        CreateNumberList();
        FormattedNumberListLabel.Text = output;
    }

    private void CreateNumberList()
    {
        numberList = new List<int>();
        for (int i = 0; i < digitsList.Count; i += 2)
        {
            // Get the first number in the pair
            int firstNumber = digitsList[i];

            // Check if there is a second number in the pair
            if (i + 1 < digitsList.Count)
            {
                // Get the second number in the pair
                int secondNumber = digitsList[i + 1];

                // Combine the two numbers and add to the transformed list
                int combinedNumber = (firstNumber * 10) + secondNumber;
                numberList.Add(combinedNumber);
            }
            else
            {
                // Add the single number to the transformed list
                numberList.Add(firstNumber);
            }
        }
    }
}