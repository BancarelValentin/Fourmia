using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fourmia.Metier
{
    public interface IDataLoader
    {
        List<Ant> Load();
        void Save();
    }
}
