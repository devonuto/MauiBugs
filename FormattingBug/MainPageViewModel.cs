using CommunityToolkit.Mvvm.ComponentModel;

namespace FormattingBug;

public partial class MainPageViewModel : ObservableObject
{
    [ObservableProperty]
    private decimal entryValue;

    public MainPageViewModel()
    {
    }
}
