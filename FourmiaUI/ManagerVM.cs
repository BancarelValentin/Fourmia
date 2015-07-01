using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Fourmia.Metier;
using System.Collections.Generic;

namespace Fourmia
{
    public class ManagerVM
    {
        private DataControler dataControler;

        public ManagerVM(DataControler dataControler)
        {
           this. dataControler = dataControler;
        }

        public Ant getAntWithID(string id)
        {
            return dataControler.getAntWhereIDIsEqualTo(id);
        }

        public Ant getRandomAnt()
        {
            return dataControler.getRandomAnt();
        }

        public List<Ant> getAntList()
        {
            return dataControler.getAllAnts();
        }
    }
}
