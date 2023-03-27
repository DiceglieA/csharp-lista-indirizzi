using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_lista_indirizzi
{
    public record class Address
    {
        public Address(string name, string surname, string street, string city, string province, string zip)
        {
            this.name = name;
            this.surname = surname;
            this.street = street;
            this.city = city;
            this.province = province;
            this.zip = zip;
        }

        public string name { get; init; }
        public string surname { get; init; }
        public string street { get; init; }
        public string city { get; init; }
        public string province { get; init; }
        public string zip { get; init; }
    }
}