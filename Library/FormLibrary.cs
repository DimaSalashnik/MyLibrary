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
        public Library(){
            Form Library = new Form();
            InitializeComponent();}

        //элементы управления
        private void buttonCreateNewBook_Click(object sender, EventArgs e){
            if (!panelCreateNewBook.Visible){ 
                panelCreateNewBook.Visible = true;
                panelShowChoosedBook.Visible = false;}
            else panelShowChoosedBook.Visible = false;}
        private void buttonClear1Author_Click(object sender, EventArgs e) => textBox1Author.Text = "";
        private void buttonClear2Author_Click(object sender, EventArgs e) => textBox2Author.Text = "";
        private void buttonClear3Author_Click(object sender, EventArgs e) => textBox3Author.Text = "";

        //блок кода который отвечает за формат книги
        private void comboBoxChooseFormat_SelectedIndexChanged(object sender, EventArgs e){
            Format format = new Format();
            labelFormarMM.Text = format.FindFormatMM(trackBarChooseFormat.Value.ToString(),
                comboBoxChooseFormat.Text.ToString());}
        private void trackBarChooseFormat_ValueChanged(object sender, EventArgs e){
            Format format = new Format();
            labelFormarMM.Text = format.FindFormatMM(trackBarChooseFormat.Value.ToString(),
                comboBoxChooseFormat.Text.ToString());}


        //очистка книги или библиотеки
        private void buttonClearBook_Click(object sender, EventArgs e) => ClearPanelCreatBook();
        private void buttonClearLibrary_Click(object sender, EventArgs e) => ClearArrayBooks();
        public void ClearPanelCreatBook(){
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
            clearPanelFullDescriptionChoosedBook();}
        public void ClearArrayBooks(){
            ClearPanelCreatBook();
            if (quantytiCounterBooks >= 1 && quantytiCounterBooks <= 8)
                for(byte i = 0; i < quantytiCounterBooks; i++){
                book[i].NameBook = "";
                book[i].Pages = "";
                book[i].Publisher = "";
                book[i].Format = "";
                book[i].Authtor1 = "";
                book[i].Authtor2 = "";
                book[i].Authtor3 = "";
                book[i].Date = "";
                book[i].Description = "";
                buttonNameBook[i] = null;
                if (pictureCover[i] != null){
                    pictureCover[i].Dispose();
                    pictureCover[i] = null;}
                }
            panelCreateNewBook.Visible = true;
            ArrayFill();
            UpdateSavedBooks();
            quantytiCounterBooks = 0;}
        private void PanelClearSavedBooks(){
            for (byte i = 0; i < quantytiCounterBooks; i++){
                cover[i].Image = null;
                buttonNameBook[i].Text = "";
        }   }

        //панель с полной информацией о книге
        private void buttonsDisplayFullDescriptionChoosedBook(object sender, EventArgs e){
            panelCreateNewBook.Visible = false;
            panelShowChoosedBook.Visible = true;
            Button ChoosedBook = (Button)sender;
            int chb = Convert.ToInt32(ChoosedBook.Tag) - 1;
            try{
                if (book[chb].NameBook != null || book[chb].NameBook != ""){
                    labelDescriptionChoosedBook.Visible = true;
                    labelPagesST.Visible = true;
                    labelNameChoosedBook.Text = book[chb].NameBook;
                    if (cover[chb].Image != null)
                        pictureBoxCoverChoosedBook.Image = cover[chb].Image;
                    labelPuplisherChoosedBook.Text = book[chb].Publisher;
                    label1AuthorChoosedBook.Text = book[chb].Authtor1;
                    label2AuthorChoosedBook.Text = book[chb].Authtor2;
                    label3AuthorChoosedBook.Text = book[chb].Authtor3;
                    label1AuthorChoosedBook.Text = book[chb].Authtor1;
                    labelDateChoosedBook.Text = book[chb].Date;
                    if (book[chb].Format != ""){
                        labelFormatChoosedBook.Visible = true;
                        labelFormatChoosedBook.Text = book[chb].Format;}
                    else labelFormatChoosedBook.Visible = false;
                    richTextBoxDescriptionChoosedBook.Visible = true;
                    richTextBoxDescriptionChoosedBook.Text = book[chb].Description;
            }   }
            catch (Exception r) { MessageBox.Show(r.Message); }
        }   
        private void clearPanelFullDescriptionChoosedBook(){
            panelCreateNewBook.Visible = true;
            panelShowChoosedBook.Visible = false;
            label1AuthorChoosedBook.Text = "";
            label2AuthorChoosedBook.Text = "";
            label3AuthorChoosedBook.Text = "";
            labelFormatChoosedBook.Text = "";
            labelPagesChoosedBook.Text = "";
            labelDateChoosedBook.Text = "";
            labelNameChoosedBook.Text = "";
            labelPuplisherChoosedBook.Text = "";
            labelTypeFormatChoosedBook.Text = "";
        }

        //Обложка книги
        private byte quantytiCounterBooks = 0;
        ComponentResourceManager resources = new ComponentResourceManager(typeof(Library));
        private void buttonUploadCover_Click(object sender, EventArgs e){
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
        private void buttonSaveBook_Click(object sender, EventArgs e) {
            if (0 <= quantytiCounterBooks && quantytiCounterBooks < book.Length) {
                try{
                    if (textBoxNameBook.Text != null || textBoxNameBook.Text != ""){
                        book[quantytiCounterBooks] = new SavedBook(textBoxNameBook.Text, textBoxYear.Text,
                        textBoxPages.Text, textBoxPublisher.Text, labelFormarMM.Text, richTextBoxDescription.Text,
                        textBox1Author.Text, textBox2Author.Text, textBox3Author.Text); quantytiCounterBooks++;
                        if (pictureBoxBookCover.Image != null) cover[quantytiCounterBooks] = new PictureCoverBook(pictureBoxBookCover.Image);
                        else cover[quantytiCounterBooks] = new PictureCoverBook((Image)resources.GetObject("pictureBoxBookCover.Image"));
                }   }
                catch (Exception) { MessageBox.Show("Книга имеет неверный формат"); }
            }
            else MessageBox.Show("Место в библиотеке закончилось");
            UpdateSavedBooks();
        }

        //Отображение формы и заполнение массивов
        private void Library_Shown(object sender, EventArgs e) => ArrayFill();
        private void ArrayFill(){
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
            pictureCover[7] = pictureBoxBook8;}

        //обновление панели с книгами
        private void buttonUpdateSavedBooks_Click(object sender, EventArgs e) => UpdateSavedBooks();
        private void UpdateSavedBooks(){
            for (byte q = 0; q < quantytiCounterBooks; q++){
                if (book[q].NameBook != null || book[q].NameBook != "")
                    buttonNameBook[q].Text = book[q].NameBook;
                if(cover[q] != null) pictureCover[q].Image = cover[q].Image;
}   }   }   }