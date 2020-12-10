using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFinance.domain.Entities
{
    public class Factures
    {
        [Key,Column(Order =0)]
        public int ClientFk { get; set; }
        [Key, Column(Order = 1)]
        public int ProductFK { get; set; }
        public float Prix { get; set; }
        [Key, Column(Order = 2)]
        public DateTime DateAchat { get; set; }
        [ForeignKey("ClientFk")]
        public virtual Client Client { get; set; }
        [ForeignKey("ProductFK")]
        public virtual Product Product { get; set; }
        
        
        
    }
}
