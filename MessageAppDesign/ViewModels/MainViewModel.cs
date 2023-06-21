using MessageAppDesign.WPF.ViewModels.MainMenu;
using System.Runtime.CompilerServices;

namespace MessageAppDesign.WPF.ViewModels
{
    public class MainViewModel : VMBase
    {
        private VMBase _currentViewModel;
        public VMBase CurrentViewModel 
        { 
            get => _currentViewModel; private set 
            {
                _currentViewModel = value;
                OnPropertyChanged();
            } 
        }

        public MainViewModel()
        {
            CurrentViewModel = new MainMenuViewModel(null);
        }
    }
}
