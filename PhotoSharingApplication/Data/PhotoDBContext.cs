using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using PhotoSharingApplication.Models;

namespace PhotoSharingApplication.Data
{
    public class PhotoDBContext : DbContext
    {
        public PhotoDBContext() : base("KeyPhotoDB") { }

        public DbSet<Photo> photos { get;set; }

        public DbSet<Comment> comments { get;set; }  
    }
}