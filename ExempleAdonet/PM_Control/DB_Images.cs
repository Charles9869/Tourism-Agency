using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhotoManagerClient;

namespace DB_Images_Utilities
{

    ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    // Classe de gestion d'image via le serveur DBPhotosWebServices
    // Incluez cette classe dans votre projet,
    // vous devrez aussi inclure les même DLLs que ceux de votre TP3
    // Auteur: Nicolas Chourot
    ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    public class DB_Images
    {
        public string UserName { set; private get; }
        public string Password { set; private get; }
        // Usager dédiés au stockage des photos de la BD
        private User User;
        // Photo de l'usager dédiés au stockage des photos de la BD
        private List<Photo> DB_Photos;
        public DB_Images(string userName, string password)
        {
            UserName = userName;
            Password = password;
            User = Log_DB_Admin();
            DB_Photos = GetUserPhoto();
        }

        private User Log_DB_Admin()
        {
            // return DBPhotosWebServices.Login("DB_Admin", "420-KA5");
            return DBPhotosWebServices.Login(UserName, Password);
        }
        // Charger les photos de l'usager
        private List<Photo> GetUserPhoto()
        {
            PhotoFilter photoFilter = new PhotoFilter(User.Id);
            return photoFilter.GetPhotos();
        }

        // Utile seulement pour la démo
        public List<string> GetImageGUIDList()
        {
            List<string> GUIDs = new List<string>();
            foreach (Photo photo in DB_Photos)
            {
                GUIDs.Add(photo.ImageGUID);
            }
            return GUIDs;
        }

        // Stocker une nouvelle image
        // Retourne le GUID de l'image créée
        public string Add(Image image)
        {
            Photo photo = new Photo { Title = "DB_Image", Shared = true, OwnerId = User.Id };
            photo.SetImage(image);
            photo = DBPhotosWebServices.CreatePhoto(photo);
            DB_Photos.Add(photo);
            return photo.ImageGUID;
        }

        // Retourne l'image correspondant au GUID 
        public Image Find(string GUID)
        {
            foreach (Photo photo in DB_Photos)
            {
                if (photo.ImageGUID == GUID)
                    return photo.GetOriginalImage();
            }
            return null;
        }

        // Efface l'image correspondant au GUID
        public void Delete(string GUID)
        {
            foreach (Photo photo in DB_Photos)
            {
                if (photo.ImageGUID == GUID)
                {
                    DB_Photos.Remove(photo);
                    DBPhotosWebServices.DeletePhoto(photo);
                    break;
                }
            }
        }
    }
}
