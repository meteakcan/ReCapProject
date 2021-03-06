using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Car:IEntity
    {
        public int CarId { get; set; }
        public int BrandId { get; set; }
        public int ColorId { get; set; }
        public string Model { get; set; }
        public int ModelYear { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
    }
}
