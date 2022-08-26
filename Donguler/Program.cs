string kurs1 = "Yazılım Gelistirici Yetiştirme Kampı";
string kurs2 = "Programlamaya başlangıç için temel kurs";
string kurs3 = "Java";

string[] kurslar = new string[] { "Yazılım Gelistirici Yetiştirme Kampı",
    "Programlamaya başlangıç için temel kurs","Java","Python","C"};

for (int i = 0; i <kurslar.Length; i++)
{
    Console.WriteLine(kurslar[i]);
}

Console.WriteLine("sayfa sonu - footer");

foreach (string kurs in kurslar)
{
    Console.WriteLine(kurs);
}