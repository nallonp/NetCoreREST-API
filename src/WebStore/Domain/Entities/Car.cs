using System.ComponentModel.DataAnnotations;
using WebStore.Domain.Base;

namespace WebStore.Domain.Entities
{
    public class Car : GenericEntity<Car>
    {
        [Required]
        [MaxLength(4)]
        [MinLength(4)]
        public string Year { get; set; }
        public string Maker { get; set; }
        public string Model { get; set; }
    }
}
