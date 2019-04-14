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

        private void buttonCreateNewBook_Click(object sender, EventArgs e)
        {
            if (!panelCreateNewBook.Visible) { 
            if (panelSavedBooks.Visible){
                panelCreateNewBook.Visible = true;
                panelSavedBooks.Visible = false;}
            else panelCreateNewBook.Visible = true;}
            else panelCreateNewBook.Visible = false;
            //хитрое заполнение массива кнопками :)
            if (!ArrayIsFull)
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
        }
        private void buttonClearBook_Click(object sender, EventArgs e)
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
        }
        private void buttonCreate2Author_Click(object sender, EventArgs e)
        {
            label2Author.Visible = true;
            textBox2Author.Visible = true;
            buttonClear2Author.Visible = true;
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
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void buttonSavedBooks_Click(object sender, EventArgs e)
        {
            if (!panelSavedBooks.Visible){
                if (panelCreateNewBook.Visible){
                    panelCreateNewBook.Visible = false;
                    panelSavedBooks.Visible = true;}}
            else panelSavedBooks.Visible = true;

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
        bool ArrayIsFull = false;
        private void buttonSaveBook_Click(object sender, EventArgs e)
        {
            if (0 <= quantytiCounterBooks && quantytiCounterBooks <= 7){
                book[quantytiCounterBooks] = new SavedBook(textBoxNameBook.Text, textBoxYear.Text,
                    textBoxPages.Text, textBoxPublisher.Text, labelFormarMM.Text, richTextBoxDescription.Text,
                    textBox1Author.Text, textBox2Author.Text, textBox3Author.Text);
                if (pictureBoxBookCover.Image != null)
                    cover[quantytiCounterBooks] = new PictureCoverBook(pictureBoxBookCover.Image);
                quantytiCounterBooks++;
            }  else return;
        }
        private void buttonUpdateSavedBooks_Click(object sender, EventArgs e)
        {
            UpdateSavedBooks();
        }
        
        public void UpdateSavedBooks()
        {
            for (byte q = 0; q <= 7; q++){
                if (buttonNameBook[q].Text == ""){
                    if (book[q] != null){
                        buttonNameBook[q].Text = book[q].NameBook;
                        pictureCover[q].Image = cover[q].Image;}}

            }
        }
    }
}