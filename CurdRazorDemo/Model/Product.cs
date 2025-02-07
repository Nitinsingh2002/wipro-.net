using System.ComponentModel.DataAnnotations;

namespace CurdRazorDemo.Model
{
    public class Product
    {
        [Key]
        public int proId {  get; set; }
        public string proName { get; set; }

        public string proDescription { get; set; }
            
    }
}
