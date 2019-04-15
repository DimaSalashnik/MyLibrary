using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Format
    {
        //отправка размера формата
        public string FindFormatMM(string IndexSelected, string type)
        {
            string format = "";
            if (type == "A"){
                if (IndexSelected == "3") { format = a3; }
                if (IndexSelected == "4") { format = a4; }
                if (IndexSelected == "5") { format = a5; }
                if (IndexSelected == "6") { format = a6; }
            }
            if (type == "B"){
                if (IndexSelected == "3") { format = b3; }
                if (IndexSelected == "4") { format = b4; }
                if (IndexSelected == "5") { format = b5; }
                if (IndexSelected == "6") { format = b6; }
            }
            if (type == "C"){
                if (IndexSelected == "3") { format = c3; }
                if (IndexSelected == "4") { format = c4; }
                if (IndexSelected == "5") { format = c5; }
                if (IndexSelected == "6") { format = c6; }
            }
            return format;
        }

        //размеры формата A
        public string a3 = "297 x 420";
        public string a4 = "210 x 297";
        public string a5 = "148 x 210";
        public string a6 = "105 x 148";
        //размеры формата B
        public string b3 = "353 x 500";
        public string b4 = "250 x 353";
        public string b5 = "176 x 250";
        public string b6 = "125 x 176";
        //размеры формата C
        public string c3 = "324 x 458";
        public string c4 = "229 x 324";
        public string c5 = "162 x 229";
        public string c6 = "114 x 162";
    }
}
