using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace ContactWebApi.Models
{
    public class Contact
    {
        private Guid _id;
        private string _firstName;
        private string _lastName;
        private string _email;
        private long _phoneNumber;
        private bool _status;
        XDocument xmlDoc;

        public Guid Id
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

        public List<Contact> GetContacts()
        {
            List<Contact> list = new List<Contact>();

            xmlDoc = XDocument.Load("C:/Users/D770773/Desktop/ContactData.xml");   //add xml document  
            var bind = xmlDoc.Descendants("contact").Select(p => new
            {
                Id = p.Element("id").Value,
                FirstName = p.Element("first_name").Value,
                LastName = p.Element("last_name").Value,
                Email = p.Element("email").Value,
                PhoneNumber = p.Element("phone_number").Value,
                Status = p.Element("status").Value
            });

            foreach (var item in bind)
            {
                list.Add(new Contact() { Id = new Guid(item.Id), FirstName = item.FirstName, LastName = item.LastName, Email = item.Email, PhoneNumber = Convert.ToInt64(item.PhoneNumber), Status = Convert.ToBoolean(item.Status) });
            }
            return list;// bind;
        }

        public void AddContact(Contact con)
        {
            xmlDoc = XDocument.Load("C:/Users/D770773/Desktop/ContactData.xml");   //add xml document  
            XElement contact = new XElement("Contact",
                    new XElement("id", Guid.NewGuid()),
                    new XElement("first_name", con.FirstName),
                    new XElement("last_name", con.LastName),
                    new XElement("email", con.Email),
                    new XElement("phone_number", con.PhoneNumber),
                    new XElement("status", con.Status));
            xmlDoc.Root.Add(contact);
            xmlDoc.Save("C:/Users/D770773/Desktop/ContactData.xml");
        }

        public void UpdateContact(Contact con)
        {
            xmlDoc = XDocument.Load("C:/Users/D770773/Desktop/ContactData.xml");
            XElement contact = xmlDoc.Descendants("Contact").FirstOrDefault(p => p.Element("id").Value == con.Id.ToString());
            if (contact != null)
            {
                contact.Element("first_name").Value = con.FirstName;
                contact.Element("last_name").Value = con.LastName;
                contact.Element("email").Value = con.Email;
                contact.Element("phone_number").Value = con.PhoneNumber.ToString();
                contact.Element("status").Value = con.Status.ToString();
                xmlDoc.Root.ReplaceWith(contact);
                xmlDoc.Save("C:/Users/D770773/Desktop/ContactData.xml");
            }
        }

        public void DeleteContact(Guid id)
        {
            xmlDoc = XDocument.Load("C:/Users/D770773/Desktop/ContactData.xml");   //add xml document  
            XElement contact = xmlDoc.Descendants("Contact").FirstOrDefault(p => p.Element("id").Value == id.ToString());
            if (contact != null)
            {
                contact.Remove();
                xmlDoc.Save("C:/Users/D770773/Desktop/ContactData.xml");
            }
        }
    }
}