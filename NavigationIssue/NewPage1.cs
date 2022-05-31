namespace NavigationIssue;

public class NewPage1 : ContentPage
{
    public NewPage1()
    {
        var navButton = new Button { Text = "Navigate to New Page 2" };
        navButton.Clicked += NavButton_Clicked;

        Content = new StackLayout
        {
            Children = {
                new Label { Text = "Welcome to New Page 1!" },
                navButton
            }
        };
    }

    private void NavButton_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync($"//Home/{nameof(NewPage2)}");
    }
}
