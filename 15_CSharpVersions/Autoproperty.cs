using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_CSharpVersions
{
    class AutoPropEx
    {
        // Auto-implemented properties for trivial get and set
        public double TotalPurchases { get; set; }
        public string Name { get; set; }
        public int CustomerId { get; set; }

        // Constructor
        public AutoPropEx(double purchases, string name, int id)
        {
            TotalPurchases = purchases;
            Name = name;
            CustomerId = id;
        }

        // Methods
        public string GetContactInfo() { return "ContactInfo"; }
        public string GetTransactionHistory() { return "History"; }

        // .. Additional methods, events, etc.
    }

}
