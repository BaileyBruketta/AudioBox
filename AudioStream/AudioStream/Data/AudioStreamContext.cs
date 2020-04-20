using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AudioStream.Models;


namespace AudioStream.Data
{
    public class AudioStreamContext : DbContext
    {
        public AudioStreamContext (DbContextOptions<AudioStreamContext> options)
            : base(options)
        {

        }

        public DbSet<Song> Song { get; set; }

        public DbSet<AudioStream.Models.User> User { get; set; }
    }
}
