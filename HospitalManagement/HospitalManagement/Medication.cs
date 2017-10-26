using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagement
{
    public class Medication
    {
        public string IDcode { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal WholeSalePrice { get; set; }

        public Medication(string id, string medicationname, decimal customerprice, decimal wholesale)
        {
            this.IDcode = id;
            this.Name = medicationname;
            this.Price = customerprice;
            this.WholeSalePrice = wholesale;
        }

        public override string ToString()
        {
            return $"[{IDcode}] {Name}"; 
        }

        public string ToShortString()
        {
            return $"{Name}";
        }
    }
}
