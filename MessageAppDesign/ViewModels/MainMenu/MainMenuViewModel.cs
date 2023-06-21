namespace MessageAppDesign.WPF.ViewModels.MainMenu
{
    public class MainMenuViewModel : VMBase
    {
        // public LeftMenuViewModel LeftMenuVM;

        private VMBase _contentPage;
        public VMBase ContentPage 
        { 
            get => _contentPage; private set 
            {
                _contentPage = value;
                OnPropertyChanged();
            } 
        }

        public MainMenuViewModel(VMBase defaultContentPage)
        {
            ContentPage = defaultContentPage;
        }
    }
}
