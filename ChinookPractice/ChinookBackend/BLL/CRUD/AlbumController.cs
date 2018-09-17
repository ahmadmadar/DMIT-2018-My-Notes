using ChinookBackend.DAL;
using ChinookBackend.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Data.Entity;

namespace ChinookBackend.BLL.CRUD
{
    [DataObject]
    public class AlbumController
    {
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public List<Album> ListAllAlbums()
        {
            using (var context = new ChinookContext())
            {
                return context.Albums.Include(x => x.Artist).ToList();
            }
        }
    }
}
