using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedCenter.Models
{
    public partial class Patient
    {
        public Patient()
        {
            this.Appointment = new HashSet<Appointment>();
        }
        public int id_patient { get; set; }
        public string surname { get; set; }
        public string name { get; set; }
        public string patronymic { get; set; }
        public DateTime date { get; set; }
        public int id_gender { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public string login { get; set; }
        public string password { get; set; }
        public virtual string fullname
        {
            get
            {
                if(this.patronymic != null)
                    return this.surname + " " + this.name + " " + this.patronymic;
                else return this.surname + " " + this.name;
            }
        }
        public Gender Gender { get; set; }
        public ICollection<Appointment> Appointment { get; set;}
    }
}
