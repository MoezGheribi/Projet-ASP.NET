using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFinance.domain.Entities
{
    public class Client
    {
        [Key]
        public int Cin { get; set; }
        public DateTime dateNaissance { get; set; }
        public string Mail { get; set; }
        public string Nom { get; set; }
        public string prenom { get; set; }

        public virtual ICollection<Factures> Factures { get; set; }
    }
}
