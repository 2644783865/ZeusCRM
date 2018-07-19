using System;
using System.Collections.Generic;
using System.Text;
using Provera.ZEUSCRM.Core.Entity;

namespace Provera.ZEUSCRM.Entity.Concrete
{
    public class Contact : IEntity
    {

        public Guid ContactID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneOffice { get; set; }
        public string PhoneMobile { get; set; }
        public string Title { get; set; }
        public string Department { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string Assistant { get; set; }
        public string AssistantPhone { get; set; }
        public bool DoNotCall { get; set; }
        public bool DoNotSendEmail { get; set; }
        public string Address { get; set; }
        public string AdressCity { get; set; }
        public string AddressDistrict { get; set; }
        public string AddressCountry { get; set; }
        public string AddressPostalCode { get; set; }
        public string Description { get; set; }

        //Lead Source navigation property si eklenecek.
    }
}
