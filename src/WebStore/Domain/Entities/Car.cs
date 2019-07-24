using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using WebStore.Domain.Base;
using WebStore.Domain.Interfaces;

namespace WebStore.Domain.Entities
{
    public class Car : GenericEntity<ICar>, ICar
    {
        [Required]
        [MaxLength(4)]
        [MinLength(4)]
        public string Year { get; set; }
        public string Maker { get; set; }
        public string Model { get; set; }
    }
}
