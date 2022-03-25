using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse
{
    public class Warehouses
    {
        public string WarehouseName { get; set; }
        public string Product  { get; set; }
        public string Measurement { get; set; }
        public double Residue { get; set; }

        public Warehouses (string Name, string Product1, string Measurement1, double Residue1)
        {
            WarehouseName = Name;
            Product = Product1;
            Measurement = Measurement1;
            Residue = Residue1;
        }
    }
}
