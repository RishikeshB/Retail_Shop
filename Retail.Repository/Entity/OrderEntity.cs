using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retail.Repository.Entity
{
    public class OrderEntity
    {
        [Key]
        [Required]
        public Guid OrderId { get; set; }
        public Guid ProductId { get; set; }
        [ForeignKey(nameof(ProductId))]
        public ProductEntity? Product { get; set; }
        public int Qty { get; set; }
       
       
    }
}
