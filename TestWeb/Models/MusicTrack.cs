using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestWeb.Models
{
    public class MusicTrack
    {
        public int MusicTrackId { get; set; }
        public string Artist { get; set; }
        public string Title { get; set; }
        public int Length { get; set; }
    }
}