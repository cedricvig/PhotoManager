using PhotoManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ExifLib;
using System.Globalization;

namespace PhotoManager.Services
{
    public class ExifService
    {
        public static Photos GetExifMetadata(string[] files)
        {
            Photos photos = new Photos();

            foreach (string file in files)
            {
                FileInfo fi = new FileInfo(file);
                Photo p = new Photo()
                {
                    DirectoryName = fi.DirectoryName,
                    FileName = fi.Name,
                    UniqueID = fi.GetHashCode()                    
                };


                JpegInfo ji = ExifReader.ReadJpeg(fi.OpenRead());
                DateTime res;
                if (DateTime.TryParseExact(ji.DateTimeOriginal, "yyyy:MM:dd HH:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None, out res))
                {
                    p.DateTimeOriginal = res;
                }
                else
                {
                    p.DateTimeOriginal = fi.CreationTime;
                }
                
                p.Make = ji.Make;
                p.Model = ji.Model;
                p.Orientation = ji.Orientation.ToString();
                p.Lagitude = ji.GpsLatitude[2];
                p.Longitude = ji.GpsLongitude[2];
                
                photos.Add(p);
            }



            return photos;
        }
        /// <summary>
        /// Rename photos with <DateTimeOriginal> <description> with :
        ///- DateTimeOriginal in format yyyy-MM-dd hh:mm
        /// </summary>
        /// <param name="newPhotosExif"></param>
        public static void RebuildFolderAndFiles(Photos newPhotosExif, string rootFolder)
        {
            foreach (Photo p in newPhotosExif)
            {
                // new folder
                p.NewDirectoryName = rootFolder + @"\" + p.DateTimeOriginal.Year + @"\" + p.DateTimeOriginal.Month.ToString("00");

                // new filename
                p.NewFileName = p.DateTimeOriginal.ToString("yyyyMMdd-HHmm") + "_" + getFileName(p);
            }
        }

        /// <summary>
        /// Rename file
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        private static string getFileName(Photo photo)
        {
            string newFileName = null;

            if (photo.FileName.StartsWith("DSCN"))
            {
                newFileName = photo.FileName.Replace("DSCN", "NIKON_");
            }
            else if (photo.FileName.StartsWith("IMG_"))
            {
                newFileName = photo.FileName.Replace("IMG", "CANON");
            }
            else if (photo.FileName.StartsWith("WP_"))
            {
                newFileName = "LUMIA_" + photo.UniqueID + photo.FileName.Substring(photo.FileName.Length - 4, 4);
            }
            else if (photo.FileName.StartsWith("P610"))
            {
                newFileName = "NIKON_" + photo.FileName.Substring(15, 7);
            }
            else if (photo.FileName.StartsWith(photo.DateTimeOriginal.ToString("yyyy-MM-dd")))
            {
                newFileName = photo.Make + "_" + photo.FileName.Substring(11, photo.FileName.Length - 11);
            }
            else
            {
                newFileName = photo.FileName;
            }

            return newFileName;
        }
    }
}
