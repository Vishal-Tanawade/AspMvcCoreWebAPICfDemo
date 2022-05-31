using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
namespace AspMvcCoreWebAPICfDemo.Models
{
    public class Product
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductCode { get; set; }
        [Required(ErrorMessage ="Product Name Should not be blank")]
        public string ProductName { get; set; }
        [Required(ErrorMessage ="Product price should not be blank")]
        public decimal ProductPrice { get; set; }
    }
}
