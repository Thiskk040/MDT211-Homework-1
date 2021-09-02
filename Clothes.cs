using System;
namespace _44
{
    class Clothes
    {
       
        public string v1;
        public string v2;
        public string v3;
        public  float v4;

       

        public Clothes(string v1, string v2, string v3, float v4)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
            this.v4 = v4;
        }

        public void Combine()
        {
            Console.WriteLine("T-shirt size : {0} ",this.v1);
            Console.WriteLine("T-shirt Color : {0}", this.v2);
            Console.WriteLine("T-shirt image : {0}", this.v3);
            Console.WriteLine("T-shirt price : {0} BATH", this.v4);
        }

       
    }
}
