using System;
using Prism.Navigation;

namespace TemplateSample.ViewModels
{
    public class ProfileViewModel : BaseViewModel
    {
        public ProfileViewModel(INavigationService navigationService) :
            base(navigationService)
        {
        }
    }
}
