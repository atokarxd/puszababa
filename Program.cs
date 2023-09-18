using System; // azt jelenti, hogy használhatunk osztályokat a 'System' névtárból. Ez később meg lesz magyarázva

namespace HelloWorld // a kód rendszerezésére szolgál, és ez egy tároló osztályok és más namespace számára.
{                   // A kapcsos zárójelek {} egy kódblokk elejét és végét jelölik.
  class Program    // egy tároló adatok és metódusok számára, amely funkcionalitást biztosít a programnak. 
  {                 // Minden C#-ban futó kódsornak egy osztályon belül kell lennie. Példánkban az osztályt 'Program'-nak neveztük el.
    static void Main(string[] args) // Egy másik dolog, ami mindig megjelenik egy C# programban, az a 'Main' metódus. 
    {                                  //A zárójelben lévő {} kódok végrehajtásra kerülnek. Nem kell értened a Main előtti és utáni kulcsszavakat.
        // 1. feladat
        try { // "try,, függvény azért kell, ha esetleg a User nem számot írna be, automatikusan tovább lépjen a program, és ne hibát jelezzen ki
            Console.WriteLine("Add meg az osztandót: "); // User felé kommunikálás
            double a = Convert.ToDouble(Console.ReadLine()); // Adott adat begyűjtése (jelen esettben az osztandót, később ugyebár az osztót)
        
            Console.WriteLine("Add meg az osztót: ");
            double b = Convert.ToDouble(Console.ReadLine());

            if (b > 0) { // "if,, ami egy kritériumnak meg kell felelnie, viszont ha nem felel meg, jelezzük a User felé "else,, segítségével
                Console.WriteLine("Az osztandód: " + Convert.ToString(a)); // Azért kell a "Convert.ToString(a),, mert csak string-eket írhat ki a
                Console.WriteLine("Az osztód: " + Convert.ToString(b)); // "WriteLine,, metódus és a szám az nem felel meg stringnek, ezért alakítjuk át

                double hanyados = a / b;
                Console.WriteLine("Az hányadosuk: " + Convert.ToString(hanyados)); 
            } 
            else {
                Console.WriteLine("Az osztód nem nagyobb nullánál");
            }
        }
        catch { // "catch ami ha try-ban valami hiba van, Usernek jelez mi volt a hiba. Jelenleg az lehet csak a hiba, ha nem számot írunk be
            Console.WriteLine("String típusút írtál be!");
        }

        // 2. feladat
        try {
            Console.WriteLine("Add meg az 1. számot: ");
            int a = Convert.ToInt32(Console.ReadLine());
        
            Console.WriteLine("Add meg a 2. számot: ");
            int b = Convert.ToInt32(Console.ReadLine());

            if (a > 0) {
                Console.WriteLine("A két szám szorzata: " + Convert.ToString(a * b));
                Console.WriteLine("A két szám összege: " + Convert.ToString(a + b));
            } 
            else {
                Console.WriteLine("Az 1. szám nem felelt meg ennek a kritériumnak: a > 0");
            }
        }
        catch {
            Console.WriteLine("String típusút írtál be!");
        }

        // 3. feladat
        try {
            Console.WriteLine("Add meg az 1. számot: ");
            int a = Convert.ToInt32(Console.ReadLine());
        
            Console.WriteLine("Add meg a 2. számot: ");
            int b = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < 3; i++) { // amit beszéltünk a for-ról a normafán
                if (a + b > 0) {
                    Console.WriteLine("A két szám összege: " + Convert.ToString(a + b));
                } 
                else {
                    Console.WriteLine("Nem felelt meg ennek a kritériumnak: a + b > 0");
                }
            }
            for (int j = 0; j < 6; j++) { // nem használhatunk azonos változókat a for ciklusban 
                if (a * b > 0) {
                    Console.WriteLine("A két szám szorzata: " + Convert.ToString(a * b));
                }
                else {
                    Console.WriteLine("Nem felelt meg ennek a kritériumnak: a * b > 0");
                }
            }
        }
        catch {
            Console.WriteLine("String típusút írtál be!");
        }

    } 
  }
}
