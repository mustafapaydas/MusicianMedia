using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;
using Core.Entities.Concretes;
using Entities.Concretes;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concretes.EntityFramework
{
    public class MusicContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=(localdb)\mssqllocaldb;initial catalog=MusicianMedia;integrated security=true");
        }

        public DbSet<Musician> Musicians { get; set; }
        public DbSet<Instrument> Instruments { get; set; }
        public DbSet<Song> Songs { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
        public DbSet<Shop> Shops { get; set; }
        public DbSet<Image> Images { get; set; }
       // public DbSet<MusicKind> Kinds { get; set; }
        public DbSet<Singer> Singers { get; set; }
    }
}
