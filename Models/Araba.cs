using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArabaApp.Models
{
    public class Araba
    {
        public yakitTipi yakit { get; set; }
        public string marka { get; set; }
        public string? model { get; set; }
        public int uretimYili { get; set; }
        public string? renk { get; set; }
        public int motorHacmi { get; set; }
    }

    public enum yakitTipi
    {
        Elektrik, Benzin, Motorin, Lpg, Hibrid
    }
}