using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoZuSchnell;

    public class Auto
    {
    public string Marke { get; set; }
    public string Kennzeichen { get; set; }
    public int Geschwindigkeit { get; set; }
    public Auto(string marke, string kennzeichen, int geschwindigkeit)
    {
        Marke = marke;
        Kennzeichen = kennzeichen;
        Geschwindigkeit = geschwindigkeit;
    }
    public override string ToString()
    {
        return $"Marke: {Marke}, Kennzeichen: {Kennzeichen}, Geschwindigkeit: {Geschwindigkeit}";
    }
}
