using CommunityToolkit.Maui.Markup;

namespace FormattingBug;

public class MainPage : ContentPage
{
    public MainPage()
    {
        BindingContext = new MainPageViewModel();

        var testEntry = new Entry { Placeholder = "Money", HorizontalTextAlignment = TextAlignment.End, Keyboard = Keyboard.Numeric };
        testEntry.Bind(Entry.TextProperty, nameof(MainPageViewModel.EntryValue), BindingMode.TwoWay, new DecimalCurrencyConverter());
        Content = new StackLayout
        {
            Margin = new Thickness(50),
            VerticalOptions = LayoutOptions.Center,
            Children = {
                testEntry
            }
        };
    }
}
