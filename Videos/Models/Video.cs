﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Videos.Models
{
    public class Video
    {
        public virtual int ID { get; set; }
        public virtual string Title { get; set; }
        public virtual int Length { get; set; }
    }
}