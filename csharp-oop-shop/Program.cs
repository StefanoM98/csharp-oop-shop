using csharp_oop_shop;

Products tastiera = new Products("Tastiera Logitech", 100, 22);

Console.WriteLine("Il prodotto che hai scelto è: " + tastiera.Name);
Console.WriteLine("Numero seriale: " + tastiera.SerialNumber);
Console.WriteLine("Codice univoco: " + tastiera.GetFullName());
Console.WriteLine("Descrizione: " + tastiera.Description);
Console.WriteLine("Prezzo con iva: " + tastiera.PriceVat);
Console.WriteLine("Prezzo originale senza iva: " + tastiera.Price);






