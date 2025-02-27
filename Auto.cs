using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoZuSchnell;

    public class Auto
    {
    public string Kennzeichen { get; set; }
    public int Geschwindigkeit { get; set; }
    public Auto(string kennzeichen, int geschwindigkeit)
    {
        Kennzeichen = kennzeichen;
        Geschwindigkeit = geschwindigkeit;
    }
    public override string ToString()
    {
        return $"Kennzeichen: {Kennzeichen}, Geschwindigkeit: {Geschwindigkeit}";
    }
}

