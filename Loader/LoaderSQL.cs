using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;

namespace Fourmia.Loader
{
    class LoaderSQL : Loader
    {
        public override DataControler Load()
        {
            base.Load();
            DataControler dataControler;

            return null;
        }

        public override void Save()
        {
            base.Save();

            DataContext dc = new DataContext("(localdb)\v11.0");
            Table<DataControler> tableDC = dc.GetTable<DataControler>();
        }
    }
}
