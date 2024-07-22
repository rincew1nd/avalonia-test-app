using System.Net.Http;
using Avalonia.Controls;
using Avalonia.Interactivity;

namespace AvaloniaApplicationCrossplatform.Views;

public partial class MainView : UserControl
{
    public MainView()
    {
        InitializeComponent();
    }

    private async void Button_OnClick(object? sender, RoutedEventArgs e)
    {
        var response = await new HttpClient().GetAsync("google.com");
        if (response.IsSuccessStatusCode)
        {
            HtmlContent.Text = await response.Content.ReadAsStringAsync();
        }
    }
}