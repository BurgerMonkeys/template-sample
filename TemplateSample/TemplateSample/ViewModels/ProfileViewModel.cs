using Prism.Navigation;
using TemplateSample.Models;

namespace TemplateSample.ViewModels
{
    public class ProfileViewModel : BaseViewModel
    {
        private User user;
        public User User
        {
            get => user;
            set => SetProperty(ref user, value);
        }

        public ProfileViewModel(INavigationService navigationService) :
            base(navigationService)
        {
        }

        public override void Initialize(INavigationParameters parameters)
        {
            base.Initialize(parameters);
            User = new User
            {
                ProfileImg = "https://s.gravatar.com/avatar/9802e38d5bd2cd85db8b0720d5feed29?s=200",
                Name = "Ricardo Prestes",
                Email = "ricardo.logan@hotmail.com"
            };
        }

        public override void OnNavigatedTo(INavigationParameters parameters)
        {
            base.OnNavigatedTo(parameters);
        }
    }
}
