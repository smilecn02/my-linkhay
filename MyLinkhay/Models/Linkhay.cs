﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyLinkhay.Models
{
    public class Linkhay
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}