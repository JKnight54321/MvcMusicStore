using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MvcMusicStore.Models
{
    public class Song
    {
        public int ID { get; set; }

        public string Title { get; set; }

        public string Genere { get; set; }

        public string Album { get; set; }

        public string Artist { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true )]
        public DateTime ReleaseDate { get; set; }
        
    }
}
