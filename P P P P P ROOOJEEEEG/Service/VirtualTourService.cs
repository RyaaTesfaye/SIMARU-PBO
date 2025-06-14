using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RUSUNAWAAA.Models;
using RusunawaApp.Data;

namespace RUSUNAWAAA.Service
{
    public class VirtualTourService
    {
        public List<MediaVirtual> GetAllMedia()
        {
            using (var context = new ApplicationDbContext())
            {
                
                return context.MediaVirtuals.ToList();
            }
        }
        public bool AddMedia(MediaVirtual media)
        {
            if (media == null) return false;

            using (var context = new ApplicationDbContext())
            {
                context.MediaVirtuals.Add(media);
                context.SaveChanges();
                return true;
            }
        }
        public bool UpdateMedia(MediaVirtual media)
        {
            if (media == null) return false;

            using (var context = new ApplicationDbContext())
            {
               
                var existingMedia = context.MediaVirtuals.Find(media.Id_Media);
                if (existingMedia != null)
                {
                    
                    existingMedia.NamaFile = media.NamaFile;
                    existingMedia.PathMedia = media.PathMedia;
                    existingMedia.Keterangan = media.Keterangan;

                    context.SaveChanges();
                    return true;
                }
                return false; 
            }
        }
        public MediaVirtual GetTourTerbaru()
        {
            using (var context = new ApplicationDbContext())
            {
                return context.MediaVirtuals
                              .OrderByDescending(m => m.Id_Media)
                              .FirstOrDefault();
            }
        }
        public bool DeleteMultipleMedia(List<int> mediaIds)
        {
            if (mediaIds == null || !mediaIds.Any()) return false;

            using (var context = new ApplicationDbContext())
            {
                var mediaToDelete = context.MediaVirtuals
                    .Where(m => mediaIds.Contains(m.Id_Media))
                    .ToList();

                if (mediaToDelete.Any())
                {
                    context.MediaVirtuals.RemoveRange(mediaToDelete);
                    context.SaveChanges();
                    return true;
                }
                return false;
            }
        }
    }
}
