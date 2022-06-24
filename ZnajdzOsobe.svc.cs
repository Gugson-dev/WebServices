using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WebApplication5.Controllers;
using System.Collections;

namespace WebApplication5
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class ZnajdzOsobe : IZnajdzOsobe
    {
        public string WgNazwiska(string nazwisko)
        {
            List<DaneOsobowe> osoby = new List<DaneOsobowe>();
            osoby.Add(new DaneOsobowe() { imie = "Daniel",  nazwisko = "Szypniewski", adres = "Pilotów" });
            osoby.Add(new DaneOsobowe() { imie = "Jarek", nazwisko = "Kaczyński", adres = "Warszawa" });
            osoby.Add(new DaneOsobowe() { imie = "Arek", nazwisko = "Duda", adres = "Warszawa" });
            osoby.Add(new DaneOsobowe() { imie = "Czarek", nazwisko = "Warek", adres = "Kraków" });
            osoby.Add(new DaneOsobowe() { imie = "Darek", nazwisko = "Koparek", adres = "Poznań" });
            try
            {
                DaneOsobowe wynik = osoby.Find(x => x.nazwisko.Contains(nazwisko));
                if (wynik == null) return "Nie odnaleziono nikogo z takim nazwiskiem";
                else return string.Format("{0} {1} {2}", wynik.imie, wynik.nazwisko, wynik.adres);
            }
            catch (ArgumentNullException)
            {
                return "Wpisanie nazwiska jest wymagane";
            }
        }
    }
}
