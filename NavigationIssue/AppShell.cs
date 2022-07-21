namespace NavigationIssue;

public class AppShell : Shell
{
    public AppShell()
    {
        var flyout = new FlyoutItem
        {
            FlyoutDisplayOptions = FlyoutDisplayOptions.AsSingleItem,
            Title = "Home",
            Route = "Home",
        };

        flyout.Items.Add(new Tab
        {
            Title = "New Page 1",
            Route = nameof(NewPage1),
            Items = {
                new ShellContent
                {
                    Title = "New Page 1",
                    ContentTemplate = new DataTemplate(typeof(NewPage1)),
                }
            }
        });

        flyout.Items.Add(new Tab
        {
            Title = "New Page 2",
            Route = nameof(NewPage2),
            Items = {
                new ShellContent
                {
                    Title = "New Page 2",
                    ContentTemplate = new DataTemplate(typeof(NewPage2)),
                }
            }
        });

        Items.Add(flyout);
    }
}
