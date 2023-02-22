using System.ComponentModel.DataAnnotations;
namespace Retail.Repository.Entity
{
    public class ProductsEntity
    {
        [Key]
        public Guid Identity { get; set; }
        public string Name { get; set; }
        public int Qty { get; set; }
        public int Price { get; set; }
        public int Rating { get; set; }
      
    }
}
