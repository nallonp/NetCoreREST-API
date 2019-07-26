using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebStore.Domain.Base;

namespace WebStore.Domain.Entities
{
    [Table("Car")]
    public class Car : GenericEntity<Car>
    {
        [Required]
        [MaxLength(4)]
        [MinLength(4)]
        public string Year { get; set; }
        public string Maker { get; set; }
        public string Model { get; set; }
        public override string ToString()
        {
            return ($"Guid: {Guid} - Year: {Year} - Maker: {Maker} - Model: {Model}");
        }
    }
}
