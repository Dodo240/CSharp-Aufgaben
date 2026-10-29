Console.WriteLine("Wie viele Tage hat der Monat, für den Sie die Sekunden berechnen wollen?: ");
long zahl1 = Convert.ToInt32(Console.ReadLine());
if (zahl1 > 31)
    Console.WriteLine("Nicht gültig");
else if(zahl1 < 28)
    Console.WriteLine("Nicht gültig");
else
    Console.WriteLine("Der Monat hat so viele Sekunden: " + (zahl1 * 86400));
