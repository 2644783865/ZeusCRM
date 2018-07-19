using System;
using System.Collections.Generic;
using System.Text;
using Provera.ZEUSCRM.Core.Entity;
using Provera.ZEUSCRM.Entity;

namespace Provera.ZEUSCRM.Entity.Concrete
{
    public class Account:IEntity

    {

        public Guid AccountID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string Ownership { get; set; }
        //industry
        //type 
        public int AnnualRevenue { get; set; }
        public string Address { get; set; }
        public string AddressDistrict { get; set; }
        public string AdressCity { get; set; }
        public string AddressCountry { get; set; }
        public string AddressPostalCode { get; set; }
        public string Description { get; set; }

    }
}
