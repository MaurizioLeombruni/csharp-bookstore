// Esercizio: Stampare le informazioni di un libro su Amazon. PARTE BONUS: Prendiamo l'input dall'utente.
Console.WriteLine("Inserisci il nome del libro:");
string bookTitle = Console.ReadLine();

Console.WriteLine("Inserisci l'autore del libro:");
string bookAuthor = Console.ReadLine();

Console.WriteLine("Inserisci il codice ISBN del libro:");
string bookISBN = Console.ReadLine();

Console.WriteLine("Inserisci il numero di pagine del libro:");
int bookPages = int.Parse(Console.ReadLine());

Console.WriteLine("Inserisci il peso del libro:");
float bookWeight = float.Parse(Console.ReadLine());

Console.WriteLine("Inserisci la larghezza del libro:");
float bookWidth = float.Parse(Console.ReadLine());

Console.WriteLine("Inserisci l'altezza del libro:");
float bookHeight = float.Parse(Console.ReadLine());

Console.WriteLine("Inserisci la profondità del libro:");
float bookDepth = float.Parse(Console.ReadLine());

Console.WriteLine("Inserisci la votazione in stelle (max. 5) del libro:");
float bookStars = float.Parse(Console.ReadLine());

Console.WriteLine("Inserisci il numero di recensioni del libro");
int bookReviews = int.Parse(Console.ReadLine());

Console.WriteLine("Il libro è disponibile sul Kindle? y/n");
string isOnKindle = Console.ReadLine();

Console.WriteLine("Il libro è disponibile con la copertina flessibile? y/n");
string isWithCover = Console.ReadLine();

//Stampiamo le informazioni.

Console.WriteLine("--- Il libro di oggi: " + bookTitle + ", di " + bookAuthor);
Console.WriteLine("ISBN: " + bookISBN);
Console.WriteLine("Numero di pagine: " + bookPages);
Console.WriteLine("Peso del libro: " + bookWeight + " kg");
Console.WriteLine("Dimensioni del libro: " + bookWidth + "cm x " + bookHeight + "cm x " + bookDepth + "cm");
Console.WriteLine("Informazioni di Amazon:");
Console.WriteLine("Numero di recensioni: " + bookReviews);
Console.WriteLine("Votazione: " + bookStars + "/5");

if (isOnKindle.ToLower() == "y" || isOnKindle.ToLower() == "yes" || isOnKindle.ToLower() == "si")
{
    Console.WriteLine("Disponibile sul Kindle: Sì");
}
else
{
    Console.WriteLine("Disponibile sul Kindle: No");
}

if (isWithCover.ToLower() == "y" || isWithCover.ToLower() == "yes" || isWithCover.ToLower() == "si")
{
    Console.WriteLine("Copertina flessibile: Sì");
}
else
{
    Console.WriteLine("Copertina flessibile: No");
}



Console.WriteLine("Amazon non mi si caricava quindi mi sono inventato un po' di roba. Leggetevi Fahreneit 451. Peace!");