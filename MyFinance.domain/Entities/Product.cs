using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFinance.domain.Entities
{
    public enum Embalage { plastique,verre,papier}
    public class Product
    {
        [Display(Name = "Production Date")]
        [DataType(DataType.Date)]
        public DateTime DateProd { get; set; }
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }
        [Required(ErrorMessage = "Input is Required")]
        [StringLength(25, ErrorMessage = "String Length is 25")]
        [MaxLength(50, ErrorMessage = "Max Length is 50")]
        public string Name { get; set; }
        [DataType(DataType.Currency)]
        public double Price { get; set; }
        public int ProductID { get; set; }
        [Range(0, int.MaxValue)]
        public int Quantity { get; set; }
        public Embalage Emballage { get; set; }

        public int? CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }

        public virtual ICollection<Provider> Providers { get; set; }
        public virtual ICollection<Factures> Factures { get; set; }

        public string ImageName { get; set; }
    }
}