using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Customers.Models
{
    public class UserModel
    {
        public UserModel(string name, string emailAdress, string phoneNumber, string imgAddress, string bioAdress, string bioshort)
        {
            Name = name;
            EmailAdress = emailAdress;
            PhoneNumber = phoneNumber;
            ImgAddress = imgAddress;
            BioAdress = bioAdress;
            BioShort = bioshort;
        }

        public string Name { get; set; }
        public string EmailAdress { get; set; }
        public string PhoneNumber { get; set; }
        public string ImgAddress { get; set; }
        public string BioAdress { get; set; }
        public string BioShort { get; set; }
    }
}