﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PMS.Models
{
    public class Doctor : User
    {
       public string Specialization { get; set; }
    }
}