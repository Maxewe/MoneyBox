using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace Alight.Mew.Sparschwein.Test
{
    public class moneyBox
    {
        public string Name { get; set; }
        public int OneCent { get; set; }
        public int TwoCent { get; set; }
        public int FiveCent { get; set; }
        public int TenCent { get; set; }
        public int TwentyCent { get; set; }
        public int FifftyCent { get; set; }
        public int OneEuro { get; set; }
        public int TwoEuro { get; set; }
        public int SumEuro { get; set; }
        public int SumCent {get; set;}

    }
}
