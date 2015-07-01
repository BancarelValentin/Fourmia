using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;
using System.Collections.ObjectModel;
using Fourmia.Metier;
using PersistanceXML;


namespace Fourmia
{
    public partial class AntList : PhoneApplicationPage
    {
        public AntList()
        {
            InitializeComponent();
        }

        public ObservableCollection<Ant> Ants
        {
            get
            {
                return mAnts;
            }
            set
            {
                mAnts = value;
            }
        }

        private ManagerVM managerVM = App.Current.Resources["managerVM"] as ManagerVM;

        private ObservableCollection<Ant> mAnts = new ObservableCollection<Ant>();

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            String displayType = NavigationContext.QueryString["display"];

            switch (displayType)
            {
                case "all": Ants.Clear();
                    foreach (Ant ant in managerVM.getAntList())
                    {
                        Ants.Add(ant);
                    }
                    break;
                case "fav": //mAnts = get favs for current user
                    break;
                default: Ants = new ObservableCollection<Ant>(managerVM.getAntList());
                    break;
            }

        }

        private void HubTile_TapOnAnt(object sender, System.Windows.Input.GestureEventArgs e)
        {
            //Récupération de la fourmi selectionnées
            Ant selectedAnt = (sender as HubTile).DataContext  as Ant;
            if (selectedAnt != null)
            {
                //Accès au détail de la fourmi en fournissant son ID
                NavigationService.Navigate(new Uri(string.Format("/AntDetails.xaml?id={0}", selectedAnt.Id), UriKind.Relative));
            }
        }

    }
}