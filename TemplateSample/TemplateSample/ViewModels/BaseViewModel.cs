using Prism.Mvvm;
using Prism.Navigation;

namespace TemplateSample.ViewModels
{
    public class BaseViewModel : BindableBase, INavigationAware, IInitialize
    {
        protected readonly INavigationService _navigationService;

        public BaseViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        public virtual void Initialize(INavigationParameters parameters)
        {
            
        }

        public virtual void OnNavigatedFrom(INavigationParameters parameters)
        {
            
        }

        public virtual void OnNavigatedTo(INavigationParameters parameters)
        {
            
        }
    }
}
