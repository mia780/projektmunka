using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalandJatek
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Üdvözöllek a szöveges kalandjátékban!\nA történet most kezdődik...");
            Console.WriteLine("Egy segédboszorkány útnak indul, mert le akar vizsgázni, hogy főboszi lehessen ne csak segédboszi.\nÖnálló életet szeretne élni.\n");
        egy:
            Console.WriteLine("\nHófehérke és a 7 törpében milyen koporsót készítettek a törpék? ( fakoporsó | üvegkoporsó )");
            Console.Write("Segédboszorkány: ");
            string valasztasJobbBal = Console.ReadLine();
            switch (valasztasJobbBal)
            {
                case "üvegkoporsó": Console.WriteLine("Gratulálok eltaláltad. Pattanj fel a seprűdre. A következő megálló Csipkerózsika."); break;
                case "fakoporsó": goto veg;
                default: Console.WriteLine("Nincs ilyen választási lehetőség. Próbáld újra."); goto egy;
            }
        ketto:
            Console.WriteLine("\nTúlrepültél.\nA Csongor és Tündét ki írta? ( Vörösmarty Mihály | Csukás István )");
            Console.Write("Segédboszorkány: ");
            valasztasJobbBal = Console.ReadLine();
            switch (valasztasJobbBal)
            {
                case "Vörösmarty Mihály": Console.WriteLine("Gratulálok eltaláltad."); break;
                case "Csukás István": goto tanulas;
                default: Console.WriteLine("Nincs ilyen választási lehetőség. Próbáld újra."); goto ketto;
            }
        harom:
            Console.WriteLine("\nMeddig aludt Csipkerózsika? ( 1 évig | 100 évig ) ");
            Console.Write("Segédboszorkány: ");
            valasztasJobbBal = Console.ReadLine();
            switch (valasztasJobbBal)
            {
                case "100 évig": Console.WriteLine("Gratulálok eltaláltad. Pattanj fel a seprűdre! A következő megálló Hamupipőke."); break;
                case "1 évig": goto veg;
                default: Console.WriteLine("Nincs ilyen választási lehetőség. Próbáld újra."); goto harom;
            }
        negy:
            Console.WriteLine("\nSajnos eltörött a seprűd. Meg kell, hogy javíttasd.\nFranz Kafka – Az átváltozás c. novellájában mi lett Gregor Samsa? ( csótány | féreg ) ");
            Console.Write("Segédboszorkány: ");
            valasztasJobbBal = Console.ReadLine();
            switch (valasztasJobbBal)
            {
                case "féreg": Console.WriteLine("Gratulálok eltaláltad."); break;
                case "csótány": goto tort;
                default: Console.WriteLine("Nincs ilyen választási lehetőség. Próbáld újra."); goto negy;
            }
        ot:
            Console.WriteLine("\nHamupipőke mostohaanyjának a macskáját hogy hívják? ( Miau | Lucifer ) ");
            Console.Write("Segédboszorkány: ");
            valasztasJobbBal = Console.ReadLine();
            switch (valasztasJobbBal)
            {
                case "Lucifer": Console.WriteLine("Gratulálok eltaláltad. Pattanj fel a seprűdre! A következő megálló Aranyhaj."); break;
                case "Miau": goto veg;
                default: Console.WriteLine("Nincs ilyen választási lehetőség. Próbáld újra."); goto ot;
            }
        hat:
            Console.WriteLine("\nNagy sietségedben indulás előtt beverted a fejedet.\nEzt kérdezik tőled: Petőfi Sándor: Reszket a bokor, mert című alkotása milyen műfajú? (dal | óda)");
            Console.Write("Segédboszorkány: ");
            valasztasJobbBal = Console.ReadLine();
            switch (valasztasJobbBal)
            {
                case "dal": Console.WriteLine("Gratulálok eltaláltad. Látogassuk meg Aranyhajat."); break;
                case "óda": goto korhaz;
                default: Console.WriteLine("Nincs ilyen választási lehetőség. Próbáld újra."); goto hat;
            }
        het:
            Console.WriteLine("\nAranyhaj szőke haja után milyen színű haja lett? (barna | fekete) ");
            Console.Write("Segédboszorkány: ");
            valasztasJobbBal = Console.ReadLine();
            switch (valasztasJobbBal)
            {
                case "barna": Console.WriteLine("Gratulálok eltaláltad. Szárnyalhatunk Holle anyóhoz."); break;
                case "fekete": goto veg;
                default: Console.WriteLine("Nincs ilyen választási lehetőség. Próbáld újra."); goto het;
            }
        nyolc:
            Console.WriteLine("\nKözben hangosan hallgattad a megzenésített verset: „ Még nyílnak a völgyben a kerti virágok, Még zöldel a nyárfa az ablak előtt\nKi írta? (Arany János | Petőfi Sándor)");
            Console.Write("Segédboszorkány: ");
            valasztasJobbBal = Console.ReadLine();
            switch (valasztasJobbBal)
            {
                case "Petőfi Sándor": Console.WriteLine("Gratulálok eltaláltad."); break;
                case "Arany János": goto elfelejt;
                default: Console.WriteLine("Nincs ilyen választási lehetőség. Próbáld újra."); goto nyolc;
            }
        kilenc:
            Console.WriteLine("\nVégre Holle anyóhoz érkeztél. Mivel jutalmazta Holle anyó az első lányt?  ( szurokkal | arannyal) ");
            Console.Write("Segédboszorkány: ");
            valasztasJobbBal = Console.ReadLine();
            switch (valasztasJobbBal)
            {
                case "arannyal": Console.WriteLine("Gratulálok eltaláltad. Látogassuk meg Piroska és a farkast."); break;
                case "szurokkal": goto veg;
                default: Console.WriteLine("Nincs ilyen választási lehetőség. Próbáld újra."); goto kilenc;
            }
        tiz:
            Console.WriteLine("\nSikeresen ideértél.\nPiroska és a farkasból Mennyiféle verziót ismerünk legalább? ( 10 | 35 ) ");
            Console.Write("Segédboszorkány: ");
            valasztasJobbBal = Console.ReadLine();
            switch (valasztasJobbBal)
            {
                case "35": Console.WriteLine("Gratulálok eltaláltad. Látogassuk meg Bibi Blocksberget."); break;
                case "10": goto veg;
                default: Console.WriteLine("Nincs ilyen választási lehetőség. Próbáld újra."); goto tiz;
            }
        tizenegy:
            Console.WriteLine("\nNagy viharba keveredtél.\nMegszállsz az öreg halász és a nagyravágyó feleségénél. Milyen állat váltja valóra a kérésüket? ( ponty | béka ) ");
            Console.Write("Segédboszorkány: ");
            valasztasJobbBal = Console.ReadLine();
            switch (valasztasJobbBal)
            {
                case "ponty": Console.WriteLine("Gratulálok eltaláltad. Folytassuk az utunkat Bibi Blocksberghez."); break;
                case "béka": goto beteg;
                default: Console.WriteLine("Nincs ilyen választási lehetőség. Próbáld újra."); goto tizenegy;
            }
        tizenketto:
            Console.WriteLine("\nMeghívott mulatozni Bánk bán.\nKi zenésítette meg a művet? ( Egressy Béni | Erkel Ferenc ) ");
            Console.Write("Segédboszorkány: ");
            valasztasJobbBal = Console.ReadLine();
            switch (valasztasJobbBal) {
            
                case "Erkel Ferenc": Console.WriteLine("Gratulálok eltaláltad. Folytasd az utat Bibi Blocksberghez!"); break;
                case "Egressy Béni": goto opera;
                default: Console.WriteLine("Nincs ilyen választási lehetőség. Próbáld újra."); goto tizenketto;
            }
        tizenharom:
            Console.WriteLine("\nA főboszorkány (Bibi Blocksberg) elfelejtette seprűjének a nevét.\nTőled kérdezi: Mi a seprűm neve? ( Mákospite | Almáspite ) ");
            Console.Write("Segédboszorkány: ");
            valasztasJobbBal = Console.ReadLine();
            switch (valasztasJobbBal)
            {
                case "Almáspite": Console.WriteLine("Jó pontot szereztél a főboszinál. Teljesítetted a vizsgát. Főboszi lettél."); break;
                case "Mákospite": goto veg;
                default: Console.WriteLine("Nincs ilyen választási lehetőség. Próbáld újra."); goto tizenharom;
            }

        Environment.Exit(0);

        veg:
            Console.WriteLine("Menj vissza a boszisuliba tanulni. Kezdd újra a játékot!");
            Environment.Exit(0);

        korhaz:
            Console.WriteLine("Sajnos agyrázkódást szenvedtél. Kezdd újra a játékot!");
            Environment.Exit(0);
        tanulas:
            Console.WriteLine("Tanulj meg repülni. Kezdd újra a játékot!");
            Environment.Exit(0);
        tort:
            Console.WriteLine("Javítsd meg a seprűdet. Kezdd újra a játékot!");
            Environment.Exit(0);
        elfelejt:
            Console.WriteLine("Nem tudtad megjegyezni hogy ki írta. Menj vissza a boszisuliba tanulni. Kezdd újra a játékot!");
            Environment.Exit(0);
        beteg:
            Console.WriteLine("Megáztál és lázas lettél. Gyógyszert kell szedned, kezdd újra a játékot!");
            Environment.Exit(0);
        opera:
            Console.WriteLine("Operába mentél. Kezdd újra a játékot!");
            Environment.Exit(0);
        
    }

        
    }
}
