using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Data.Linq.Mapping;
using System.ComponentModel;

namespace Fourmia.Metier
{
    [DataContract]
   // [Serializable]
    [Table]
    public class Ant : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;
        private void PropChanged(string propName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
            }
        }


        [DataMember]
        [Column(IsPrimaryKey = true)]
        public string Id { get; set; }

        [DataMember]
        [Column]
        public string Name
        {
            get
            {
                return this.mName;
            }
            set
            {
                mName = value;
                PropChanged("Name");
            }
        }
        private string mName;

        [DataMember]
        [Column]
        public int Size {
            get
            {
                return this.mSize;
            }
            set
            {
                mSize = value;
                PropChanged("Size");
            }
        }
        private int mSize;

        [DataMember]
        [Column]
        public string Description
        {
            get
            {
                return this.mDescription;
            }
            set
            {
                mDescription = value;
                PropChanged("Description");
            }
        }
        private string mDescription;

        [DataMember(EmitDefaultValue = false)]
        public List<Image> ListImages
        {
            get
            {
                return this.mListImages;
            }
            set
            {
                mListImages = value;
                PropChanged("ListImages");
            }
        }
        public List<Image> mListImages;

        /// <summary>
        /// Représente la liste de commentaires associés a cette fourmi.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public List<Comment> ListComments
        {
            get
            {
                return this.mListComments;
            }
            set
            {
                mListComments = value;
                PropChanged("ListComments");
            }
        }
        public List<Comment> mListComments;

        /// <summary>
        /// Représente la liste de lieu où la fourmi peut être trouvée.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public List<Place> ListPlaces
        {
            get
            {
                return this.mListPlaces;
            }
            set
            {
                mListPlaces = value;
                PropChanged("ListPlaces");
            }
        }
        public List<Place> mListPlaces;

        public string ThumbnailPath
        {
            get
            {
                return ListImages[0].ImagePath;
            }
        }

        public Ant(string name, int size, string description)
        {
            this.Id = Guid.NewGuid().ToString();
            this.Name = name;
            this.Size = size;
            this.Description = description;
            this.ListComments = new List<Comment>();
            this.ListPlaces = new List<Place>();
        }

        public Ant()
        {
        }

        public Ant(string name, int size, string description, Image image)
        {
            this.Id = Guid.NewGuid().ToString();
            this.Name = name;
            this.Size = size;
            this.Description = description;
            this.ListComments = new List<Comment>();
            this.ListImages = new List<Image>();
            this.ListPlaces = new List<Place>();
            this.ListImages.Add(image);
        }

        //TEST
        public Ant(string name, int size, string description, Image image, string id)
        {
            this.Id = id;
            this.Name = name;
            this.Size = size;
            this.Description = description;
            this.ListComments = new List<Comment>();
            this.ListImages = new List<Image>();
            this.ListPlaces = new List<Place>();
            this.ListImages.Add(image);
        }
        //TEST

        public void AddImage(Image imageAAjouter)
        {
            ListImages.Add(imageAAjouter);
        }

        public void DeleteImage(Image imageASupprimer)
        {
            ListImages.Remove(imageASupprimer);
        }

        public void AddComment(Comment commentToAdd)
        {
            ListComments.Add(commentToAdd);
        }

        public void UpdateComment(Comment commentToUpdate, Comment newComment)
        {
            ListComments[ListComments.IndexOf(commentToUpdate)] = newComment;
        }

        public void DeleteComment(Comment commentToDelete)
        {
            ListComments.Remove(commentToDelete);
        }

        public void AddPlace(Place placeToAdd)
        {
            ListPlaces.Add(placeToAdd);
        }

        public void DeletePlace(Place placeToDelete)
        {
            ListPlaces.Remove(placeToDelete);
        }
    }
}
