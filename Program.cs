
// kullanıcıdan bir sayı al ve o sayının ortalamasını kullanıcıya döndür.

Console.Write("Lütfen bir sayı giriniz : ");
int sayi = int.Parse(Console.ReadLine());
int sayac = 0;
int toplam = 0;

while (sayac <= sayi)
{
    toplam += sayac;
    sayac++;
}

Console.WriteLine("Sayıların ortalaması : " + toplam / sayi);

// a'dan z'ye kadar olan tüm harfleri konsola yazdır.,

char character = 'a';

while (character <= 'z')
{
    Console.Write(character);
    character++;
}

//foreach

string[] diller = { "C#", "Java", "JavaScript", "Phyton" };

foreach (var dil in diller)
{
    Console.WriteLine(dil);
}
