using mobile_systems_project.Model;
using mobile_systems_project.Repository;

namespace mobile_systems_project.View;

public partial class LearnBinarySystemPage : ContentPage
{
    private int currentIndex;
    private Number[] numbers;
    private bool randomMode;
    private NumberRepository numberRepository = new NumberRepository();
    public LearnBinarySystemPage()
	{
        InitializeComponent();

        numbers = numberRepository.GetNumbers();
        currentIndex = 0;
        randomMode = false;
        UpdateOutput();
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        randomMode = !randomMode;
        UpdateOutput();
    }

    //private void swipeView_SwipeChanging(object sender, SwipeChangingEventArgs e)
    //{
    //    if (e.SwipeDirection == SwipeDirection.Left)
    //    {
    //        // Swipe left to load previous output
    //        if (currentIndex > 0)
    //            currentIndex--;
    //    }
    //    else if (e.SwipeDirection == SwipeDirection.Right)
    //    {
    //        // Swipe right to load next output
    //        if (currentIndex < numbers.Length - 1)
    //            currentIndex++;
    //    }

    //    UpdateOutput();
    //}
    void OnSwiped(object sender, SwipedEventArgs e)
    {
        switch (e.Direction)
        {
            case SwipeDirection.Left:
                if (currentIndex < numbers.Length - 1)
                    currentIndex++;
                UpdateOutput();
                
                break;
            case SwipeDirection.Right:
                if (currentIndex > 0)
                    currentIndex--;
                UpdateOutput();
                break;
            case SwipeDirection.Up:
                // Handle the swipe
                break;
            case SwipeDirection.Down:
                // Handle the swipe
                break;
        }
    }
    private void UpdateOutput()
    {
        if (randomMode)
        {
            // Display random output
            var random = new Random();
            currentIndex = random.Next(0, numbers.Length);
        }

        var currentNumber = numbers[currentIndex];

        numberLabel.Text = $"{currentNumber.NumericValue}";
        textLabel.Text = $"{currentNumber.TextualValue}";
    }

    private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
    {
        textLabel.IsVisible = !textLabel.IsVisible;
    }
}