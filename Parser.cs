
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_lista_indirizzi
{
    public static class Parser
    {
        public static IEnumerable<Address> Read()
        {
            using var input = File.OpenText("..\\..\\..\\addresses.csv");

            var addresses = new List<Address>();

            input.ReadLine();


            while (true)
            {
                string? line = input.ReadLine();
                if (line is null) return addresses;

                var chunks = line.Split(',')!;
                if (chunks.Length == 6) continue;

                var name = chunks[0];
                var surname = chunks[1];
                var street = chunks[2];
                var city = chunks[3];
                var province = chunks[4];
                var zip = chunks[5];

                if (string.IsNullOrEmpty(name)) name = "nothing";

                if (string.IsNullOrEmpty(surname)) surname = "nothing";

                if (string.IsNullOrEmpty(street)) street = "nothing";

                if (string.IsNullOrEmpty(city)) city = "nothing";

                if (string.IsNullOrEmpty(province)) province = "nothing";

                if (string.IsNullOrEmpty(zip)) zip = "nothing";

                Address address = new Address(name, surname, street, city, province, zip);

                addresses.Add(address);

            }


        }

        public static void Write(IEnumerable<Address> addresses)
        {
            using var output = File.CreateText("address-list.txt");
            
            output.WriteLine("Address List: ");


            foreach(var address in addresses)
            {
                output.WriteLine();
                output.WriteLine("----address----");
                output.WriteLine($"Name: {address.name}");
                output.WriteLine($"Surname: {address.surname}");
                output.WriteLine($"Street: {address.street}");
                output.WriteLine($"City: {address.city}");
                output.WriteLine($"Province: {address.province}");
                output.WriteLine($"ZIP: {address.zip}");
                output.WriteLine("------------------");
            }
        }

    }
}

