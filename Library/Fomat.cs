using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Format
    {
        //метод который заменяет label-ы в классе Library
        public void EditLableFormat(string l3, string l4, string l5, string l6, string type)
        {
            //создание экземпляра класса
            Library library = new Library();
            string num = "";
            //вызов метода и присваивание формата в переменную
            string format = type;
            //приклеивание формата к lable-ам
            if (l3 == "3") { num = "3"; l3 = type + num; }
            if (l4 == "4") { num = "4"; l4 = type + num; }
            if (l5 == "5") { num = "5"; l5 = type + num; }
            if (l6 == "6") { num = "6"; l6 = type + num; }
            //отправка параметров в класс Library
            library.LabelFormat(l3, l4, l5, l6);
        }
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
