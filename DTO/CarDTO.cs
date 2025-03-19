using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CarDTO
    {
        public int ID { get; set; }
        public string Model { get; set; }
        public string Brand { get; set; }
        public string Manufacturer { get; set; }
        public string FuelType { get; set; }
        public string AvailableFeatures { get; set; }
        public decimal RentPriceDay { get; set; }

    }
}
