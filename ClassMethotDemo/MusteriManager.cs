using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethotDemo
{
    internal class MusteriManager
    {
        List<Musteri> musteriList = new List<Musteri>();
        

        internal void MusteriEkleme(Musteri musteri)
        {
               musteriList.Add(musteri);
               
        }
        internal void Yazdirma()
        {
            // Console.WriteLine(musteri.Name , musteri.Id ,musteri.Price , musteri.Description );
            foreach (var musteri in musteriList)
            {
                Console.WriteLine(musteri.Name +" "+ musteri.Id + " " + musteri.Description + ": " + musteri.Price);
            }
        }
        
        internal void MusteriSilme(Musteri musteri)
        {
            musteriList.Remove(musteri);
        }
        
    }
}
