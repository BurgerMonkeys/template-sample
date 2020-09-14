using System;
using System.Collections.ObjectModel;
using System.Linq;
using Prism.Navigation;
using TemplateSample.Models;

namespace TemplateSample.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        public ObservableCollection<Talk> Talks { get; private set; }

        public MainViewModel(INavigationService navigationService):
            base(navigationService)
        {
            Talks = new ObservableCollection<Talk>();
        }

        public override void OnNavigatedTo(INavigationParameters parameters)
        {
            base.OnNavigatedTo(parameters);

            if (Talks.Any())
                return;

            for (int i = 1; i <= 20; i++)
            {
                Talks.Add(new Talk
                {
                    Title = $"Talk title {i}",
                    Speaker = $"Speaker {i}",
                    Date = DateTime.Now.AddDays(i)
                });
            }
        }
    }
}
