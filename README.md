# ContactWebApi
Contact Web API 

To store contact data, xml file is used.
Kindly create ContactData.xml at path C:\TestContact\
Example: C:\TestContact\ContactData.xml

To test API postman app is used
1)	To add contact in xml with data in json format as
https://localhost:44342/api/Add
{
    "Id":"FFC1D2A0-F1C2-48A9-9B47-31D0CBE7D508",
    "FirstName":Sachin",
    "LastName":"Tendulkar",
    "Email":"sachin.tendulkar@gmail.com",
    "PhoneNumber":"1122334455",
    "Status":"true"
}

2)	To get all contacts from xml
https://localhost:44342/api/Get

To get specific contact by id from xml
https://localhost:44342/api/Get/6b81add1-86da-4dea-89aa-b188c64516a7

3) To update contact in xml with data in json format as
https://localhost:44342/api/Update
{
    "Id":"FFC1D2A0-F1C2-48A9-9B47-31D0CBE7D508",
    "FirstName":Sachin",
    "LastName":"Tendulkar",
    "Email":"sachin.tendulkar@gmail.com",
    "PhoneNumber":"1122334455",
    "Status":"true"
}

4) To delete any contact by id from xml
https://localhost:44342/api/Delete/6b81add1-86da-4dea-89aa-b188c64516a7
 

