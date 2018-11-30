using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace TestWeb.Models
{
    public class MusicStoreContext : DbContext
    {
        public DbSet<MusicTrack> musicTracks { get; set; }

        public DbSet<Album> Albums { get; set; }
    }
}