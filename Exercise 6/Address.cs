using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_6
{
    internal class Address
    {
        int index, house, apartment;
        string country, city, street;
        public int Index {
            get
            {
                return index;
            }
            set
            {
                index = value;
            }
        }
        public string Country {
            get
            {
                return country;
            }
            set
            {
                country = value;
            }
        }
        public string City {
            get
            {
                return city;
            }
            set
            {
                city = value;
            }
        }
        public string Street {
            get
            {
                return street;
            }
            set
            {
                street = value;
            }
        }
        public int House {
            get
            {
                return house;
            }
            set
            {
                house = value;
            }
        }
        public int Apartmant {
            get
            {
                return apartment;
            }
            set
            {
                apartment = value;
            }
        }
        public Address(int index, string country, string city , string street, int house, int apartment)
        {
            Index = index;
            House = house;
            Apartmant = apartment;
            Country = country;
            City = city;
            Street = street;
      
           
          
           
        
            

        }

        public void Show()
        {
            Console.WriteLine($"Index : {Index} Country : {Country} City : {City} Street : {Street} House : {House} Apartmant : {Apartmant}");
        }
    }
}
