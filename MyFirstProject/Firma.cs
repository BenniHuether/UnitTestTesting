using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    public class Firma
    {
        public Firma(string name, string straße, int hausnummer, Ortschaft sitz)
        {
            this.FirmenName = name;
            this.straße = straße;
            this.hausnummer = hausnummer;
            this.ort = sitz;
        }
        public string FirmenName { get; private set; }

        string straße;
        int hausnummer;
        Ortschaft ort;

        public override string ToString()
        {
            string ortsteilTemp = "";

            if (!string.IsNullOrEmpty(ort.Ortsteil))
                ortsteilTemp = string.Format("({0})", ort.Ortsteil);

            string result = string.Format("{0}, \r\n{1} {2}, \r\n{3} {4}{5}",
                FirmenName, straße, hausnummer, ort.Postleitzahl, ort.Ortsname, ortsteilTemp);

            return result;
        }
    }
}
