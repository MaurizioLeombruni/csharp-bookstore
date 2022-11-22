// Esercizio: Stampare le informazioni di un libro su Amazon.
string bookTitle = "Fahreneit 451";
string bookAuthor = "Ray Bradbury";
string bookISBN = "978-0-7432-4722-1";

int bookPages = 256;
float bookWeight = 0.784f;
float bookWidth = 12.6f;
float bookHeight = 28.7f;
float bookDepth = 1.8f;

float bookStars = 4.6f;
int bookReviews = 68;

bool isOnKindle = true;
bool isWithCover = true;

//Stampiamo le informazioni.

Console.WriteLine("--- Il libro di oggi: " + bookTitle + ", di " + bookAuthor);
Console.WriteLine("ISBN: " + bookISBN);
Console.WriteLine("Numero di pagine: " + bookPages);
Console.WriteLine("Peso del libro: " + bookWeight + " kg");
Console.WriteLine("Dimensioni del libro: " + bookWidth + "cm x " + bookHeight + "cm x " + bookDepth + "cm");
Console.WriteLine("Informazioni di Amazon:");
Console.WriteLine("Numero di recensioni: " + bookReviews);
Console.WriteLine("Votazione: " + bookStars + "/5");

//Il controllo sulla booleana è inutile visto che bastava scrivere sì o no direttamente, ma le variabili le ho fatte e le uso.

if (isOnKindle)
{
    Console.WriteLine("Disponibile sul Kindle: Sì");
} else
{
    Console.WriteLine("Disponibile sul Kindle: No");
}

if (isWithCover)
{
    Console.WriteLine("Copertina flessibile: Sì");
}
else
{
    Console.WriteLine("Copertina flessibile: No");
}



Console.WriteLine("Amazon non mi si caricava quindi mi sono inventato un po' di roba. Leggetevi Fahreneit 451. Peace!");
