using System;
using System.Collections.Generic;
namespace _44
{
     class User
    {   public string name;
        public string Email;
        public List<Clothes> shoppingcart;



        public User(string Valuename,string ValueEmail)
        {
            name = Valuename;
            Email = ValueEmail;
            shoppingcart = new List<Clothes>();

        }
        public void customer()
        {
            Console.WriteLine("Customer Name: {0}", this.name);
            Console.WriteLine("Email: {0}", this.Email);
        }
        public void cart(Adress location)
        {
           Adress adress = location;
        }
        public void list (Clothes clothes)
        {
            shoppingcart.Add(clothes);
        }
        public void calculator()
        {
            int total = 1;
            float prize = 0;

            foreach (Clothes clothes in shoppingcart)
            {
                prize += clothes.v4;
                total++;
                if(total == shoppingcart.Capacity )
                {
                    Console.WriteLine("Cost = {0} BATH", prize);
                }
            }

        }
        
    }
}
