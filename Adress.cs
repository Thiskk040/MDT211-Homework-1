using System;
namespace _44
{
     class Adress
    {
        public string HomeNo;
        public string Street;
        public string City;
        public string Zipcode;
        public Adress(string ValueHomeNo,string ValueStreet,string ValueCity,string ValueZipcode)
        {
            HomeNo = ValueHomeNo;
            Street = ValueStreet;
            City = ValueCity;
            Zipcode = ValueZipcode;
        }
        public void Write()
        {
            Console.WriteLine("Adress:{0} {1} {2} {3}", this.HomeNo, this.Street, this.City,this.Zipcode);
            
        }
    }
}
