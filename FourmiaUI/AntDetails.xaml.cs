using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;
using Fourmia.Metier;
using PersistanceXML;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace Fourmia
{
    public partial class AntDetails : PhoneApplicationPage, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void PropChanged(string propName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
            }
        }

        public Ant CurrentAnt {
            get
            {
                return this.mCurrentAnt;
            }
            set
            {
                mCurrentAnt = value;
                PropChanged("CurrentAnt");
            }
        }

        private Ant mCurrentAnt;

        public ObservableCollection<Comment> Comments
        {
            get
            {
                return mComments;
            }
            set
            {
                mComments = value;
            }
        }

        private ObservableCollection<Comment> mComments = new ObservableCollection<Comment>();

        public AntDetails()
        {
            this.CurrentAnt = new Ant();
            InitializeComponent();
        }

        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            string antID = this.NavigationContext.QueryString["id"];
            ManagerVM managerVM = App.Current.Resources["managerVM"] as ManagerVM;
            Ant myAnt = managerVM.getAntWithID(antID);
            this.CurrentAnt = myAnt;

            //DataContext = this.CurrentAnt;
            ListToolKitAnt.ItemsSource = this.Comments;

            foreach (Comment c in this.CurrentAnt.ListComments)
            {
                mComments.Add(c);
            }

        }
    }


}