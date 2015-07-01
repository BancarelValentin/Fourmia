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

namespace PersistanceBin
{
    public class LoaderBin : IDataLoader
    {
        List<Ant> IDataLoader.Load()
        {
            return null;
        }

        void IDataLoader.Save()
        {

        }
    }
}
