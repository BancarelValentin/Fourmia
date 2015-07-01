using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
//using System.Threading.Tasks;

namespace Fourmia.Metier
{
    [DataContract]
   // [Serializable]
    [Table]
    class PlaceRadius : Place
    {
        [DataMember]
        [Column]
        public float latitude { set; get; }

        [DataMember]
        [Column]
        public float longitude { set; get; }

        [DataMember]
        [Column]
        public float width { set; get; }

        [DataMember]
        [Column]
        public float height { set; get; }

    }
}
