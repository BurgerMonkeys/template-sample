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
        public ObservableCollection<HighLight> HighLights { get; private set; }

        public MainViewModel(INavigationService navigationService):
            base(navigationService)
        {
            HighLights = new ObservableCollection<HighLight>();
            Talks = new ObservableCollection<Talk>();
        }

        public override void OnNavigatedTo(INavigationParameters parameters)
        {
            base.OnNavigatedTo(parameters);
            LoadHighLights();
            LoadTalks();
        }

        private void LoadHighLights()
        {
            if (HighLights.Any())
                return;

            HighLights.Add(new HighLight
            {
                ImageUrl = "https://burgermonkeys.com/wp-content/uploads/2020/06/ios-14-widgets.jpg",
                Title = "HighLight 1"
            });
            HighLights.Add(new HighLight
            {
                ImageUrl = "https://burgermonkeys.com/wp-content/uploads/2020/06/code-snippets.png",
                Title = "HighLight 2"
            });
        }

        private void LoadTalks()
        {
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
