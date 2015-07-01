using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;

namespace Fourmia.Metier
{
    public class User
    {
        public int Id { get; set; }
        public string Nickname { get; set; }
        public string Mail { get; set; }
        public string Picture { get; set; }

        /// <summary>
        /// Description de l'utilisateur.
        /// </summary>
        public string Bio { get; set; }
        public DateTime BirthDate { get; set; }

        /// <summary>
        /// Représente la liste de commentaires postés par l'utilisateur.
        /// </summary>
        public List<Comment> ListComments { get; set; }

        /// <summary>
        /// Représente la liste de toutes les fourmis marquées en tant que favoris par l'utilisateur
        /// </summary>
        public List<Ant> Favorites { get; set; }

        /// <summary>
        /// Représente la liste de toutes les fourmis marquées en tant que déja vues par l'utilisateur
        /// </summary>
        public List<Ant> Seen { get; set; }

        public User()
        {
            Favorites = new List<Ant>();
            ListComments = new List<Comment>();
            Seen = new List<Ant>();
        }

        /// <summary>
        /// Ajoute une fourmi aux favoris de l'utilisateur
        /// </summary>
        /// <param name="ant"></param>
        public void AddAntToFavorites(Ant ant)
        {
            Favorites.Add(ant);
        }

        /// <summary>
        /// Supprime une fourmi des favoris de l'utilisateur
        /// </summary>
        /// <param name="ant"></param>
        public void DeleteAntFromFavorites(Ant ant)
        {
            Favorites.Remove(ant);
        }

        /// <summary>
        /// Anote une fourmi comme "vue" par l'utilisateur
        /// </summary>
        /// <param name="ant"></param>
        public void AddAntToSeen(Ant ant)
        {
            Seen.Add(ant);
        }

        /// <summary>
        /// Enlève l'annotation "vue" d'une fourmi
        /// </summary>
        /// <param name="ant"></param>
        public void DeleteAntFromSeen(Ant ant)
        {
            Seen.Remove(ant);
        }

    }
}
