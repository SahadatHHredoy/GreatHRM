﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreatHRM.Entities
{
    public abstract class Entity
    {
        [Key]
        public int Id { get; set; }
        public byte? Status { get; set; }
    }
}
