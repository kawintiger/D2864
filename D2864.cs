using System;
using System.Collections.Generic;
namespace งาน
{
    class Program
    {
        static void Main(string[] args)
        {
            User jame = new User("jame watson", "jame@gmail.com");
            Tshirt red = new Tshirt("L", "red", "lizard", 500);
            Tshirt black1 = new Tshirt("M", "black", "fox", 750);
            Tshirt black2 = new Tshirt("S", "black", "pig", 625);
            Address Addressjame = new Address("Thanon Phutthamonthon", "Nakon Prathom", "10180");

            jame.Sent();
            jame.shirt(red);
            jame.shirt(black1);
            jame.shirt(black2);
            red.opTshirt();
            black1.opTshirt();
            black2.opTshirt();
            jame.AddRess(Addressjame);
            Addressjame.opAddress();
            Console.WriteLine("total cost : {0} bath", red.Price + black1.Price + black2.Price);
            Console.ReadLine();
        }

    }
    class User
    {
        public string Name, Email;
        public List<Tshirt> ShirstOrder;
        public List<Address> Location;
        public User(string Vname, string Vemail)
        {
            Name = Vname;
            Email = Vemail;
            ShirstOrder = new List<Tshirt>();
            Location = new List<Address>();
        }
        public void shirt(Tshirt tshirt)
        {
            ShirstOrder.Add(tshirt);
        }
        public void AddRess(Address AddresS)
        {
            Location.Add(AddresS);
        }
        public void Sent()
        {
            Console.WriteLine("Username : {0}", this.Name);
            Console.WriteLine("Email : {0}", this.Email);
        }
    }
    class Tshirt
    {
        public string Color, Size, Image;
        public float Price;

        public Tshirt(string Vcolor, string Vsize, string Vimage, float Vpriec)
        {
            Color = Vcolor;
            Size = Vsize;
            Image = Vimage;
            Price = Vpriec;
        }
        public void opTshirt()
        {
            Console.WriteLine("Size : {0}", this.Size);
            Console.WriteLine("Color : {0}", this.Color);
            Console.WriteLine("Image : {0}", this.Image);
            Console.WriteLine("Priec : {0}", this.Price);
        }

    }
    class Address
    {
        public string Street, City, Zipcode;

        public Address(string Vstreet, string Vcity, string Vzipcode)
        {
            Street = Vstreet;
            City = Vcity;
            Zipcode = Vzipcode;

        }
        public void opAddress()
        {
            Console.WriteLine("131/75 street : {0},city : {1},zipcode : {2}", this.Street, this.City, this.Zipcode);
        }

    }
    class ShoppingCart
    {
        public List<Tshirt> tshirt;
        public List<Address> addresses;
    }


}