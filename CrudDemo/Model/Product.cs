using System.ComponentModel.DataAnnotations;

namespace CrudDemo.Model
{
    public class Product
    {
        [Key]  // Marks this property as the primary key
        public int Id { get; set; }  // Use properties (with getter and setter)

        public string Name { get; set; }  // Follow C# conventions (uppercase for properties)

        public string Description { get; set; }

        public int Price { get; set; }
    }
}
