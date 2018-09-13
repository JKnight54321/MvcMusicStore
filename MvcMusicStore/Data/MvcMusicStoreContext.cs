using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MvcMusicStore.Models
{
    public class MvcMusicStoreContext : DbContext
    {
        public MvcMusicStoreContext (DbContextOptions<MvcMusicStoreContext> options)
            : base(options)
        {
        }

        public DbSet<MvcMusicStore.Models.Song> Song { get; set; }
    }
}
