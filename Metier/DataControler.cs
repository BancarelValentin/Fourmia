using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fourmia.Metier;
using System.Runtime.Serialization;
using System.Data.Linq.Mapping;

namespace Fourmia.Metier
{
    [DataContract]
    //[Serializable]
    [Table]
    public class DataControler
    {
        public const int FORMAT_NONE = 0;
        public const int FORMAT_XML = 1;
        public const int FORMAT_BINARY = 2;
        public const int FORMAT_SQL = 3;

        [DataMember]
        [Column]
        public List<Ant> antsList
        {
            get;
            set;
        }

        private IDataLoader loader
        {
            get;
            set;
        }

        public DataControler(IDataLoader loader)
        {
            antsList = new List<Ant>();
            this.loader = loader;

            addTestAnts();
        }

        public void Load()
        {
            this.antsList = loader.Load();
        }

        public void Save()
        {
            loader.Save();
        }

        public List<Ant> getAllAnts()
        {
            return antsList;
        }

        /// <summary>
        /// Retourne la fourmi dont l'ID est passé en paramètre
        /// </summary>
        /// <param name="size"></param>
        /// <returns></returns>
        public Ant getAntWhereIDIsEqualTo(string id)
        {
            //On utilise .Single() car on est sur d'obtenir un élément (étant donné que l'id utilisé pour la recheche vient de la vue),
            //et on sait égamlement qu'il ne peut y avoir deux élémnets retournés.
            Ant wanted = this.antsList.Single(ant => ant.Id.Equals(id));
            Console.WriteLine(wanted.Description);
            return wanted;
        }

        /// <summary>
        /// Retourne les fourmis ayant une taille supérieure
        /// ou égale à "size"
        /// </summary>
        /// <param name="size"></param>
        /// <returns></returns>
        public List<Ant> getAntsWithSizeSuperiorOrEqualTo(int size)
        {
            return antsList.Where(ant => ant.Size >= size).ToList();
        }

        /// <summary>
        /// Retourne les fourmis ayant une taille inférieure
        /// ou égale à "size"
        /// </summary>
        /// <param name="size"></param>
        /// <returns></returns>
        public List<Ant> getAntsWithSizeInferiorOrEqualTo(int size)
        {
            return antsList.Where(ant => ant.Size <= size).ToList();
        }

        /// <summary>
        /// Retourne les fourmis dont le nom contient les lettres
        /// passées en paramètre
        /// </summary>
        /// <param name="letters"></param>
        /// <returns></returns>
        public List<Ant> getAntsWhereNameContains(string letters)
        {
            return antsList.Where(ant => ant.Name.Contains(letters) == true).ToList();
        }

        /// <summary>
        /// Retourne les fourmis dont la description contient
        /// les lettre passées en paramètre
        /// </summary>
        /// <param name="letters"></param>
        /// <returns></returns>
        public List<Ant> getAntsWhereDescriptionContains(string letters)
        {
            return antsList.Where(ant => ant.Description.Contains(letters) == true).ToList();
        }

        /// <summary>
        /// Retourne les fourmis qui possèdent l'image passée
        /// en paramètre
        /// </summary>
        /// <param name="image"></param>
        /// <returns></returns>
        public List<Ant> getAntsWhereImagesContains(Image image)
        {
            return antsList.Where(ant => ant.ListImages.Contains(image) == true).ToList();
        }

        /// <summary>
        /// Retourne les lieux
        /// </summary>
        /// <param name="place"></param>
        /// <returns></returns>
        public List<Ant> getAntsWherePlacesContains(Place place)
        {
            return antsList.Where(ant => ant.ListPlaces.Contains(place) == true).ToList();
        }

        /// <summary>
        /// Retourne les fourmis qui ont le commentaire
        /// passé en paramètre (logiquement il n'y en a qu'une !)
        /// </summary>
        /// <param name="comment"></param>
        /// <returns></returns>
        public List<Ant> getAntsWhereCommentsContains(Comment comment)
        {
            return antsList.Where(ant => ant.ListComments.Contains(comment) == true).ToList();
        }

        /// <summary>
        /// Retourne une fourmi aléatoire
        /// </summary>
        /// <returns></returns>
        public Ant getRandomAnt()
        {
            Random rnd = new Random();
            return antsList[rnd.Next(antsList.Count)];
        }


        public void addTestAnts()
        {
            antsList.Add(new Ant("coucouc", 230, "Petite description", new Image("Fourmi 1", "Images/fourmi1.jpg"), "10"));
            antsList.Add(new Ant("PetitNom2", 230, "Petite description", new Image("Fourmi 2", "Images/fourmi2.jpg"), "20"));
            antsList.Add(new Ant("PetitNom3", 230, "Petite description", new Image("Fourmi 3", "Images/fourmi3.jpg"), "30"));
        }
    }
}
