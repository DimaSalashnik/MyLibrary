using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class Library : Form
    {
        public Library()
        {
            Form Library = new Form();
            InitializeComponent();
        }

        //передвижение окна программы
        private int moveX, moveY;
        private bool WindowMove = false;
        private void labelMoveWindow_MouseMove(object sender, MouseEventArgs e)
        {
            if (WindowMove)
            {
                //передвижение
                this.Left += Cursor.Position.X - moveX;
                this.Top += Cursor.Position.Y - moveY;
                //присвоение положения курсора
                moveX = Cursor.Position.X;
                moveY = Cursor.Position.Y;
            }
        }
        private void labelMoveWindow_MouseDown(object sender, MouseEventArgs e)
        {
            //присвоение положения курсора
            moveX = Cursor.Position.X;
            moveY = Cursor.Position.Y;
            WindowMove = true;
        }
        private void labelMoveWindow_MouseUp(object sender, MouseEventArgs e)
        {
            //передвижение окна не активно
            WindowMove = false;
        }

        //элементы управления
        private void buttonCreateNewBook_Click(object sender, EventArgs e)
        {
            if (!panelCreateNewBook.Visible)
            { 
                panelCreateNewBook.Visible = true;
                panelShowChoosedBook.Visible = false;
            }
            else panelShowChoosedBook.Visible = false;
        }
        private void buttonClearBook_Click(object sender, EventArgs e)
        {
            ClearPanelCreatBook();
        }
        private void buttonClear1Author_Click(object sender, EventArgs e)
        {
            textBox1Author.Text = "";
        }
        private void buttonClear2Author_Click(object sender, EventArgs e)
        {
            textBox2Author.Text = "";
        }
        private void buttonClear3Author_Click(object sender, EventArgs e)
        {
            textBox3Author.Text = "";
        }
        private void buttonClearLibrary_Click(object sender, EventArgs e)
        {
            ClearPanelCreatBook();
            ClearArrayBooks();
        }
        public void ClearPanelCreatBook()
        {
            textBoxNameBook.Text = "";
            textBoxPublisher.Text = "";
            textBoxPages.Text = "";
            textBoxPublisher.Text = "";
            richTextBoxDescription.Text = "";
            textBoxYear.Text = "00/00/0000";
            textBox1Author.Text = "";
            textBox2Author.Text = "";
            textBox3Author.Text = "";
            comboBoxChooseFormat.Text = "";
            labelFormat3.Text = "3";
            labelFormat4.Text = "4";
            labelFormat5.Text = "5";
            labelFormat6.Text = "6";
            labelFormarMM.Text = "";
            pictureBoxBookCover.Image = (Image)resources.GetObject("pictureBoxBookCover.Image");
        }
        public void ClearArrayBooks()
        {
            ClearPanelCreatBook();
            //Array.Resize(ref book, 0);
            book = null;
            ArrayFill();
            UpdateSavedBooks();
            quantytiCounterBooks = 0;
        }

        //блок кода который отвечает за формат книги
        private void comboBoxChooseFormat_SelectedIndexChanged(object sender, EventArgs e)
        {
            Format format = new Format();
            labelFormarMM.Text = format.FindFormatMM(trackBarChooseFormat.Value.ToString(),
                comboBoxChooseFormat.Text.ToString());
        }
        private void trackBarChooseFormat_ValueChanged(object sender, EventArgs e)
        {
            Format format = new Format();
            labelFormarMM.Text = format.FindFormatMM(trackBarChooseFormat.Value.ToString(),
                comboBoxChooseFormat.Text.ToString());
        }

        //Обложка книги
        private byte quantytiCounterBooks = 0;
        ComponentResourceManager resources = new ComponentResourceManager(typeof(Library));
        private void buttonUploadCover_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (openFileDialogUploadCoverBook.ShowDialog().Equals(DialogResult.OK)) {
                pictureBoxBookCover.ImageLocation = openFileDialogUploadCoverBook.FileName;
            }
            else if (openFileDialogUploadCoverBook.Equals(DialogResult.Cancel))
                return;
        }
        private void buttonClearCoverBook_Click(object sender, EventArgs e) 
            => pictureBoxBookCover.Image = (Image)resources.GetObject("pictureBoxBookCover.Image");

        //сохранение книги
        SavedBook[] book = new SavedBook[8];
        PictureCoverBook[] cover = new PictureCoverBook[8];
        Button[] buttonNameBook = new Button[8];
        PictureBox[] pictureCover = new PictureBox[8]; 
        private void buttonSaveBook_Click(object sender, EventArgs e)
        {
            if (0 <= quantytiCounterBooks && quantytiCounterBooks < book.Length){
                book[quantytiCounterBooks] = new SavedBook(textBoxNameBook.Text, textBoxYear.Text,
                    textBoxPages.Text, textBoxPublisher.Text, labelFormarMM.Text, richTextBoxDescription.Text,
                    textBox1Author.Text, textBox2Author.Text, textBox3Author.Text);
                if (pictureBoxBookCover.Image != null)
                    cover[quantytiCounterBooks] = new PictureCoverBook(pictureBoxBookCover.Image);
                else cover[quantytiCounterBooks] = new PictureCoverBook((Image)resources.GetObject("pictureBoxBookCover.Image"));
                quantytiCounterBooks++;}
            else MessageBox.Show("Место в библиотеке закончилось");
            
            UpdateSavedBooks();
        }
        private void buttonUpdateSavedBooks_Click(object sender, EventArgs e)
        {
            UpdateSavedBooks();
        }
        private void Library_Shown(object sender, EventArgs e)
        {
            ArrayFill();
        }
        private void ArrayFill()
        {
            //заполнение массива с названиями книг
            buttonNameBook[0] = buttonNameBook1;
            buttonNameBook[1] = buttonNameBook2;
            buttonNameBook[2] = buttonNameBook3;
            buttonNameBook[3] = buttonNameBook4;
            buttonNameBook[4] = buttonNameBook5;
            buttonNameBook[5] = buttonNameBook6;
            buttonNameBook[6] = buttonNameBook7;
            buttonNameBook[7] = buttonNameBook8;
            //заполнение массива с обложками
            pictureCover[0] = pictureBoxBook1;
            pictureCover[1] = pictureBoxBook2;
            pictureCover[2] = pictureBoxBook3;
            pictureCover[3] = pictureBoxBook4;
            pictureCover[4] = pictureBoxBook5;
            pictureCover[5] = pictureBoxBook6;
            pictureCover[6] = pictureBoxBook7;
            pictureCover[7] = pictureBoxBook8;
        }

        private void UpdateSavedBooks(){
            for (byte q = 0; q < quantytiCounterBooks; q++){
                if (book[q].NameBook != null)
                    buttonNameBook[q].Text = book[q].NameBook;
                if(cover[q] != null)
                        pictureCover[q].Image = cover[q].Image;}}

        //отображение информации о книге при нажатии на неё
        private void buttonsDisplayFullDescriptionChoosedBook(object sender, EventArgs e)
        {
            panelCreateNewBook.Visible = false;
            panelShowChoosedBook.Visible = true;
            Button ChoosedBook = (Button)sender;
            byte chb = (byte)ChoosedBook.TabIndex;
            labelNameChoosedBook.Text = book[chb].NameBook;
            pictureBoxCoverChoosedBook.Image = cover[chb].Image;
            labelPuplisherChoosedBook.Text = book[chb].Publisher;
            label1AuthorChoosedBook.Text = book[chb].Authtor1;
            label2AuthorChoosedBook.Text = book[chb].Authtor2;
            label3AuthorChoosedBook.Text = book[chb].Authtor3;
            label1AuthorChoosedBook.Text = book[chb].Authtor1;
            labelFormatChoosedBook.Text = book[chb].Format;
            labelDateChoosedBook.Text = book[chb].Date;
            richTextBoxDescriptionChoosedBook.Text = book[chb].Description;
        }

        private void PanelClearSavedBooks()
        {
            for (byte i = 0; i < quantytiCounterBooks; i++)
            {
                cover[i].Image = null;
                buttonNameBook[i].Text = "";
            }
        }
    }
}