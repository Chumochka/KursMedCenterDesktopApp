﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedCenter.Models
{
    public partial class Specialization
    {
        public Specialization()
        {
            this.Worker = new HashSet<Worker>();
        }

        public int id_specialization { get; set; }
        public string name { get; set; }

        public virtual ICollection<Worker> Worker { get; set; }
    }
}
