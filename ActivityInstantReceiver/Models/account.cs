﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ActivityInstantReceiver.Models
{
    public class account
    {
        public int Id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public int authority { get; set; }
    }
}