using ChinookBackend.DAL;
using ChinookBackend.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChinookBackend.BLL.CRUD
{
    [DataObject]
    public class ArtistController
    {
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public List<Artist> ListAllArtists()
        {
            using (var context = new ChinookContext())
            {
                return context
                    .Artists
                    .Include(nameof(Artist.Albums))
                    .ToList();
            }
        }
    }
}
