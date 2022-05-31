namespace NavigationIssue;

public class AppShell : Shell
{
    public AppShell()
    {
        Routing.RegisterRoute($"//Home/{nameof(NewPage2)}", typeof(NewPage2));

        var flyout = new FlyoutItem
        {
            FlyoutDisplayOptions = FlyoutDisplayOptions.AsSingleItem,
            Title = "Home",
            Route = "Home",
        };

        flyout.Items.Add(new Tab
        {
            Title = "New Page 1",
            Items = {
                new ShellContent
                {
                    Title = "New Page 1",
                    Route = nameof(NewPage1),
                    ContentTemplate = new DataTemplate(typeof(NewPage1)),
                }
            }
        });

        flyout.Items.Add(new Tab
        {
            Title = "New Page 2",
            Items = {
                new ShellContent
                {
                    Title = "New Page 2",
                    Route = nameof(NewPage2),
                    ContentTemplate = new DataTemplate(typeof(NewPage2)),
                }
            }
        });

        Items.Add(flyout);
    }
}
