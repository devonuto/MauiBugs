namespace NavigationIssue;

public class NewPage2 : ContentPage
{
    public NewPage2()
    {
        Content = new StackLayout
        {
            Children = {
                new Label { Text = "Welcome to New Page 2!" }
            }
        };
    }
}
