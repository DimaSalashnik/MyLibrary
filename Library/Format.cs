using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Format
    {
        public string a3 = "297 x 420";
        public string a4 = "210 x 297";
        public string a5 = "148 x 210";
        public string a6 = "105 x 148";

        public string b3 = "353 x 500";
        public string b4 = "250 x 353";
        public string b5 = "176 x 250";
        public string b6 = "125 x 176";

        public string c3 = "125 x 176";
        public string c4 = "229 x 324";
        public string c5 = "162 x 229";
        public string c6 = "114 x 162";   

        public string A3 { get => a3; set => a3 = value; }
        public string A4 { get => a4; set => a4 = value; }
        public string A5 { get => a5; set => a5 = value; }
        public string A6 { get => a6; set => a6 = value; }
        public string B3 { get => b3; set => b3 = value; }
        public string B4 { get => b4; set => b4 = value; }
        public string B5 { get => b5; set => b5 = value; }
        public string B6 { get => b6; set => b6 = value; }
        public string C3 { get => c3; set => c3 = value; }
        public string C4 { get => c4; set => c4 = value; }
        public string C5 { get => c5; set => c5 = value; }
        public string C6 { get => c6; set => c6 = value; }

        //A3 = "297 x 420", A4 = "210 x 297", A5 = "148 x 210", A6 = "105 x 148";
        //B3 = "353 x 500", B4 = "250 x 353", B5 = "176 x 250", B6 = "125 x 176";
        //C3 = "324 x 458", C4 = "229 x 324", C5 = "162 x 229", C6 = "114 x 162";
    }
}
