using Prism.Navigation;

namespace TemplateSample.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        public MainViewModel(INavigationService navigationService):
            base(navigationService)
        {
        }

    }
}
