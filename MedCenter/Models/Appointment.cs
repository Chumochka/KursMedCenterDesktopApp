using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedCenter.Models
{
    public partial class Appointment
    {
        public Appointment()
        {
            this.Diary_Entrie = new HashSet<Diary_Entrie>();
        }

        public int id_appointment { get; set; }
        public int id_patient { get; set; }
        public int id_doctor { get; set; }
        public Nullable<DateTime> date { get; set; }
        public string date_wish { get; set; }
        public string cabinet { get; set; }

        public virtual string patient_fullname { get; set; }
        public virtual string doctor_fullname { get; set; }
        public virtual string specialization { get; set; }

        public virtual Patient Patient { get; set; }
        public virtual Worker Doctor { get; set; }
        public virtual ICollection<Diary_Entrie> Diary_Entrie { get; set; }
    }
}
