/*Ex2
Scrieti un program care va calcula media aritmetica a trei numere citite de la
tastatura*/

// Citirea a trei numere de la tastatura
Console.WriteLine("Introduceti primul numar:");
int numar1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Introduceti al doilea numar:");
int numar2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Introduceti al treilea numar:");
int numar3 = Convert.ToInt32(Console.ReadLine());

// Calculul mediei aritmetice ( nr1+nr2+nr3 /3 )
int suma = numar1 + numar2 + numar3;
int media = suma / 3;

// Afisarea rezultatului
Console.WriteLine($"Media aritmetica a numerelor este: {media}");

// Asteapta ca utilizatorul sa apese o tasta pentru a inchide fereastra consolei
Console.ReadKey();