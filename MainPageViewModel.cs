using System.ComponentModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
namespace MauiApp1
{
    public class MainPageViewModel : ObservableObject
    {
        [ObservableProperty]
        private string _expressionDisplay = string.Empty;
        
        [ObservableProperty]
        private string _expressionResult = string.Empty;
        
        [RelayCommand]
        public void HandleButton(string buttonText)
        {
            
        }
    }
}