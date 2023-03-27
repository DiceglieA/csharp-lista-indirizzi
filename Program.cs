using csharp_lista_indirizzi;

var addresses = Parser.Read();

Parser.Write(addresses);


foreach (var address in addresses)
{
    Console.WriteLine(address);
}