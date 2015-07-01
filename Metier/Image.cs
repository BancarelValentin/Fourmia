using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Data.Linq.Mapping;

namespace Fourmia.Metier
{
    [DataContract]
    //[Serializable]
    [Table]
    public class Image
    {
        [DataMember]
        [Column(IsPrimaryKey = true)]
        public int Id { get; set; }

        public string ImagePath { get; set; }

        public string Name { get; set; }

        public Image(string name, string path)
        {
            this.Name = name;
            this.ImagePath = path;
        }
    }
}
