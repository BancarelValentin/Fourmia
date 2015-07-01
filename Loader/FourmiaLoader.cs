using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;

namespace Fourmia.Loader
{
    class FourmiaLoader
    {
        public const int FORMAT_NONE = 0;
        public const int FORMAT_XML = 1;
        public const int FORMAT_BINARY = 2;
        public const int FORMAT_SQL = 3;

        public Loader loader { get; set; }

        public DataControler Load() { return null; }
        public void Save() { }

        public FourmiaLoader(int format)
        {
            switch (format)
            {
                case FORMAT_XML:
                    loader = new LoaderXML();
                    DataControler.getInstance(FORMAT_XML);
                    break;
                case FORMAT_BINARY:
                    loader = new LoaderBin();
                    DataControler.getInstance(FORMAT_BINARY);
                    break;
                case FORMAT_SQL:
                    //loader = new LoaderSQL();
                    DataControler.getInstance(FORMAT_SQL);
                    break;
                default:
                    loader = new LoaderXML();
                    break;
            }
        }
    }
}
