using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedCenter.Models
{
    public partial class Diary_Entrie
    {
        public int id_appointment { get; set; }
        public DateTime date { get; set; }
        public string desctiption { get; set; }
        public virtual Appointment appointment { get; set; }
    }
}
