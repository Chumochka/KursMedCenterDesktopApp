using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedCenter.Models
{
    public partial class Role
    {
        public Role()
        {
            this.Worker = new HashSet<Worker>();
        }

        public int id_role { get; set; }
        public string name { get; set; }
        public ICollection<Worker> Worker { get; set; }
    }
}
