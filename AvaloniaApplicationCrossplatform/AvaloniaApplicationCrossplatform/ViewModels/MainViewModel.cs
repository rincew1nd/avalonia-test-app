using System.Net.Http;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;

namespace AvaloniaApplicationCrossplatform.ViewModels;

public partial class MainViewModel : ObservableObject
{
    [ObservableProperty]
    private string _htmlContent;
    
    public async Task CallAsync()
    {
        var response = await new HttpClient().GetAsync("google.com");
        if (response.IsSuccessStatusCode)
        {
            HtmlContent = await response.Content.ReadAsStringAsync();
        }
    }
}