using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChinookBackend.Entities
{
    [Table("PlaylistTrack")]
    public class PlaylistTrack
    {
        [Key]
        public int PlaylistId { get; set; }
        public int TrackId { get; set; }
    }
}
