using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFinance.domain.Entities
{
    public class Provider
    {
        [Required]
        [NotMapped]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }

        public DateTime DateCreated { get; set; }
        [DataType(DataType.EmailAddress)]
        [Required]
        public string Email { get; set; }
        [Key]
        public int Id { get; set; }

        public bool IsApproved { get; set; }
        [DataType(DataType.Password)]
        [MinLength(8)]
        [Required]
        public string Password { get; set; }

        public string UserName { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
