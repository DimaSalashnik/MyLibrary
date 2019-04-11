using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    class SavedBook
    {
        //поля для хранения
        public string name;
        public string date;
        public ulong pages;
        public string publisher;
        public string format;
        public string description;
        public string author1;
        public string author2;
        public string author3;
        //инкапсуляция полей
        public string Name { get => name; set => name = value; }
        public string Date { get => date; set => date = value; }
        public ulong Pages { get => pages; set => pages = value; }
        public string Publisher { get => publisher; set => publisher = value; }
        public string Format { get => format; set => format = value; }
        public string Description { get => description; set => description = value; }
        public string Author1 { get => author1; set => author1 = value; }
        public string Author2 { get => author2; set => author2 = value; }
        public string Author3 { get => author3; set => author3 = value; }

        public SavedBook(TextBox textBoxNameBook, TextBox textBoxYear, TextBox textBoxPages,
                 TextBox textBoxPublisher, Label labelFormarMM, RichTextBox richTextBoxDescription,
                    TextBox textBox1Author, TextBox textBox2Author, TextBox textBox3Author)
        {
            //форматирование текста
            FormatString(textBoxNameBook.ToString());
            FormatString(richTextBoxDescription.ToString());
            FormatString(textBoxPublisher.ToString());
            FormatString(textBoxYear.ToString());
            FormatString(textBox1Author.ToString());
            FormatString(textBox2Author.ToString());
            FormatString(textBox3Author.ToString());
            //сохранение книги
            this.Name = textBoxNameBook.ToString();
            this.Pages = Convert.ToUInt16(textBoxPages);
            this.Date = textBoxYear.ToString();
            this.Publisher = textBoxPublisher.ToString();
            this.Format = labelFormarMM.ToString();
            this.Description = richTextBoxDescription.ToString();
            this.Author1 = textBox1Author.ToString();
            this.Author2 = textBox2Author.ToString();
            this.Author3 = textBox3Author.ToString();
        }
        //форматирования строки 
        public string FormatString(string word)
        {
            if (word != null)
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
