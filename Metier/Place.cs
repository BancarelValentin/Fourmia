﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Data;
using System.Data.Linq.Mapping;

namespace Fourmia.Metier
{
    [DataContract]
   // [Serializable]
    [Table]
    public class Place
    {
        [DataMember]
        [Column(IsPrimaryKey = true)]
        public int Id { get; set; }
    }
}
