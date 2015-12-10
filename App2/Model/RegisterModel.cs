using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectApp1;

namespace App2.Model
{
    public class RegisterModel
    {
        public string _firstName { get; set; }
        public string _lastName { get; set; }
        public string _email { get; set; }
        public string _password { get; set; }
        public string _addres { get; set; }

        public string _creditCardNumber { get; set; }
        public string _city { get; set; }
        public string _zipCode { get; set; }
        public string _expiryMonth { get; set; }
        public string _expiryYear { get; set; }


        public RegisterModel()
        {
            _firstName = "";
            _lastName = "";
            _email = "";
            _password = "";
            _addres = "";
            _creditCardNumber = "";
            _city = "";
            _zipCode = "";
            _expiryMonth = "";
            _expiryYear = "";

        }


        public RegisterModel(string firstName, string lastName, string email, string password, string addres, string creditCardNumber, string city, string zipCode,string expiryMonth,string expiryYear)
        {

            _firstName = firstName;
            _lastName = lastName;
            _email = email;
            _password = password;
            _addres = addres;
            _creditCardNumber = creditCardNumber;
            _city = city;
            _zipCode = zipCode;
            _expiryMonth = expiryMonth;
            _expiryYear = expiryYear;


        }
      
    }
}
