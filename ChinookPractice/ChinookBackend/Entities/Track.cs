using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChinookBackend.Entities
{
    [Table("Table")]
    public class Track
    {
        [Key]
        public int TrackId { get; set; }
        public string Name { get; set; }
        public int AlbumId { get; set; }
        public int MediaTypeId { get; set; }
        public int GenreId { get; set; }
        public string Composer { get; set; }
        public int Milliseconds { get; set; }
        public int Bytes { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
