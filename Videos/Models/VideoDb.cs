﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Videos.Models
{
    public class VideoDb : DbContext
    {
        public DbSet<Video> Videos { get; set; }
    }
}