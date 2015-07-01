using System;
using System.Windows.Controls;
using Microsoft.Phone.Controls;
using Fourmia.Metier;
using PersistanceXML;

namespace Fourmia
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructeur
        public MainPage()
        {
            InitializeComponent();
            App.Current.Resources.Add("managerVM", new ManagerVM(new DataControler(new LoaderXML())));
            //App.Current.Resources["managerVM"] = new ManagerVM(new DataControler(new LoaderXML()));
        }

        private void HubTile_TapOnAllAnts(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/AntList.xaml?display=all", UriKind.Relative));
        }

        private void HubTile_TapOnFav(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/AntList.xaml?display=fav", UriKind.Relative));
        }

        private void HubTile_TapOnProfile(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Profil.xaml", UriKind.Relative));
        }

        private void HubTile_TapOnSearch(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Search.xaml", UriKind.Relative));
        }

        private void HubTile_TapOnMap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Map.xaml", UriKind.Relative));
        }

        private void HubTile_TapOnRandom(object sender, System.Windows.Input.GestureEventArgs e)
        {
            ManagerVM managerVM = App.Current.Resources["managerVM"] as ManagerVM;
            string randomID = managerVM.getRandomAnt().Id;
            NavigationService.Navigate(new Uri(string.Format("/AntDetails.xaml?id={0}", randomID), UriKind.Relative));
        }
    }
}