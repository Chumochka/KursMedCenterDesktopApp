using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedCenter.Models
{
    public partial class Gender
    {
        public Gender()
        {
            this.Worker = new HashSet<Worker>();
            this.Patient = new HashSet<Patient>();
        }
        public int id_gender { get; set; }
        public string name { get; set; }
        public virtual ICollection<Worker> Worker { get; set;}
        public virtual ICollection<Patient> Patient { get; set;}
    }
}
