using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class FindFormatMM
    {
        public string FindFormat(string comboBoxChooseFormat, string trackBarChooseFormat)
        {
            string f = "";
            if (comboBoxChooseFormat == "A")
            {
                if (trackBarChooseFormat == "3")
                    f = a3;
                if (trackBarChooseFormat == "4")
                    f = a4;
                if (trackBarChooseFormat == "5")
                    f = a5;
                if (trackBarChooseFormat == "6")
                    f = a6;
            }
            if (comboBoxChooseFormat == "B")
            {
                if (trackBarChooseFormat == "3")
                    f = b3;
                if (trackBarChooseFormat == "4")
                    f = b4;
                if (trackBarChooseFormat == "5")
                    f = b5;
                if (trackBarChooseFormat == "6")
                    f = b6;
            }
            if (comboBoxChooseFormat == "C")
            {
                if (trackBarChooseFormat == "3")
                    f = c3;
                if (trackBarChooseFormat == "4")
                    f = c4;
                if (trackBarChooseFormat == "5")
                    f = c5;
                if (trackBarChooseFormat == "6")
                    f = c6;
            }
            return f;
        }

        public string a3 = "297 x 420";
        public string a4 = "210 x 297";
        public string a5 = "148 x 210";
        public string a6 = "105 x 148";
        public string b3 = "353 x 500";
        public string b4 = "250 x 353";
        public string b5 = "176 x 250";
        public string b6 = "125 x 176";
        public string c3 = "324 x 458";
        public string c4 = "229 x 324";
        public string c5 = "162 x 229";
        public string c6 = "114 x 162";
    }
}
