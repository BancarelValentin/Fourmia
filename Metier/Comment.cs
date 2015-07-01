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
   // [Serializable]
    [Table]
    public class Comment
    {
        [DataMember]
        [Column(IsPrimaryKey = true)]
        public int Id { get; set; }

        [DataMember]
        [Column]
        public string Text { get; set; }

        /// <summary>
        /// Représente la fourmi à laquelle ce commentaire est associé.
        /// </summary>
        [DataMember]
        [Column]
        public Ant Ant { get; set; }

        /// <summary>
        /// Représente l'utilisateur auquel ce commentaire est associé.
        /// </summary>
        [DataMember]
        [Column]
        public User Author { get; set; }
    }
}
