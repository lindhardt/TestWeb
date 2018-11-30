using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestWeb.Models
{
    public class Album
    {
        public int AlbumId { get; set; }
        public string Title { get; set; }

        public virtual ICollection<MusicTrack> MusicTracks { get; set; }
    }
}