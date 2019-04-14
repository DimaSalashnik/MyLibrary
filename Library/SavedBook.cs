using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    class SavedBook : ISavedBook
    {
        //поля для хранения
        public string name;
        public string date;
        public string pages;
        public string publisher;
        public string format;
        public string description;
        public string author1;
        public string author2;
        public string author3;
        //инкапсуляция полей
        public string NameBook { get => name; set => name = value; }
        public string Date { get => date; set => date = value; }
        public string Pages { get => pages; set => pages = value; }
        public string Publisher { get => publisher; set => publisher = value; }
        public string Format { get => format; set => format = value; }
        public string Description { get => description; set => description = value; }
        public string Authtor1 { get => author1; set => author1 = value; }
        public string Authtor2 { get => author2; set => author2 = value; }
        public string Authtor3 { get => author3; set => author3 = value; }

        public SavedBook(string textBoxNameBook, string textBoxYear, string textBoxPages,
                 string textBoxPublisher, string labelFormarMM, string richTextBoxDescription,
                    string textBox1Author, string textBox2Author, string textBox3Author)
        {
            //форматирование текста
            //FormatString(textBoxNameBook.ToString());
            //FormatString(richTextBoxDescription.ToString());
            //FormatString(textBoxPublisher.ToString());
            //FormatString(textBoxYear.ToString());
            //FormatString(textBox1Author.ToString());
            //FormatString(textBox2Author.ToString());
            //FormatString(textBox3Author.ToString());
            //сохранение книги
            NameBook = textBoxNameBook;
            Pages = textBoxPages;
            Date = textBoxYear;
            Publisher = textBoxPublisher;
            Format = labelFormarMM;
            Description = richTextBoxDescription;
            author1 = textBox1Author;
            author2 = textBox2Author;
            author3 = textBox3Author;
        }

        //форматирования строки 
        public string FormatString(string word)
        {
            if (word != "")
            {
                //удаление пробелов 
                word.Trim();
                //замена случайных точек
                if (!word.Contains("..."))
                    while (!word.Contains(".."))
                        word.Replace("..", ".");
                else while (!word.Contains("...."))
                        word.Replace("....", "...");
                while (!word.Contains(" ."))
                    word.Replace(" .", ".");
                //замена случайных запятых
                while (!word.Contains(",,"))
                    word.Replace(",,", ",");
                while (!word.Contains(" ,"))
                    word.Replace(" ,", ",");
                //замена случайных восклицательных знаков
                if (!word.Contains("!!!"))
                    while (word.Contains("!!"))
                        word.Replace("!!", "!");
                else while (word.Contains("!!!!"))
                        word.Replace("!!!!", "!!!");
                while (!word.Contains(" !"))
                    word.Replace(" !", "!");
                //замена случайных восклицательных знаков
                if (!word.Contains("???"))
                    while (word.Contains("??"))
                        word.Replace("??", "?");
                else while (word.Contains("????"))
                        word.Replace("????", "???");
                while (!word.Contains(" ?"))
                    word.Replace(" ?", "?");
                //замена случайных тире
                while (!word.Contains("--"))
                    word.Replace("--", "-");
                //удаление лишник пробелов
                while (!word.Contains("  "))
                    word.Replace("  ", " ");
                while (!word.Contains(".  "))
                    word.Replace(".  ", ". ");
            }
            else if (word.Contains("/"))
            {
                //удаление случайных слешей
                while (!word.Contains("//"))
                    word.Replace("//", "/");
            }
            return word;
        }
    }
}
