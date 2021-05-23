using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContactWebApi.Models
{
    public class Contact
    {
        private int _id;
        private string _firstName;
        private string _lastName;
        private string _email;
        private long _phoneNumber;
        private bool _status;

        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value;
            }
        }
        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            }
        }
        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                _email = value;
            }
        }
        public long PhoneNumber
        {
            get
            {
                return _phoneNumber;
            }
            set
            {
                _phoneNumber = value;
            }
        }
        public bool Status
        {
            get
            {
                return _status;
            }
            set
            {
                _status = value;
            }
        }
    }
}