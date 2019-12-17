using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoManager.Models
{
    public class Photo
    {
        /// <summary>
        /// Cache File infos:
        //	- DirectoryName
        //	- FileName
        //Read exif infos :
        //	- DateTimeOriginal
        //	- Orientation
        //	- Marque appareil
        //	- Modèle appareil
        //	- longitude
        //	- latitude
        //	- altitude
        /// </summary>
        public string DirectoryName { get; set; }
        public string FileName { get; set; }

        public string NewDirectoryName { get; set; }
        public string NewFileName { get; set; }
        public DateTime DateTimeOriginal { get; set; }
        public string Orientation { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public double Longitude { get; set; }
        public double Lagitude { get; set; }
        public int UniqueID { get; set; }

    }
}
