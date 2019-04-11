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

        //кнопка добавления книги
        private void buttonCreateNewBook_Click(object sender, EventArgs e)
        {
            if (!panelCreateNewBook.Visible)
                panelCreateNewBook.Visible = true;
            else panelCreateNewBook.Visible = false;

        }
        //кнопка очистки книги
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
        //кнопка добавления второго автора
        private void buttonCreate2Author_Click(object sender, EventArgs e)
        {
            label2Author.Visible = true;
            textBox2Author.Visible = true;
            buttonDelete2Author.Visible = true;
        }
        //кнопка удаления второго автора
        private void buttonDelete2Author_Click(object sender, EventArgs e)
        {
            textBox2Author.Text = "";
        }
        //кнопка удаления третьего автора
        private void buttonDelete3Author_Click(object sender, EventArgs e)
        {
            textBox3Author.Text = "";
        }
        //кнопка закрытия программы
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //кнопка загрузки обложки книги
        private Bitmap CoverBookImage;
        private void buttonUploadCover_Click(object sender, EventArgs e)
        {
            if (openFileDialogUploadCoverBook.ShowDialog().Equals(DialogResult.Cancel))
                return;
            else if (openFileDialogUploadCoverBook.ShowDialog().Equals(DialogResult.OK))
            {
                pictureBoxBookCover.ImageLocation = openFileDialogUploadCoverBook.FileName;
            }

        }
        //кнопка сохранения обложки
        private void buttonSaveCoverBook_Click(object sender, EventArgs e)
        {
            SaveFileDialog CoverBook = new SaveFileDialog();
            CoverBook.Title = $"Book{quantytiCounterBooks}";
        }
        //кнопка удаления обложки книги
        private void buttonClearCoverBook_Click(object sender, EventArgs e)
        {

        }
        //обработка события загрузки обложки
        private void openFileDialogUploadCoverBook_FileOk(object sender, CancelEventArgs e)
        {

        }
        //переменная для счечика книг
        private byte quantytiCounterBooks = 0;
        private byte[] num = new byte[6] {1, 2, 3, 4, 5, 6}; //массив книг
        //кнопка сохранения книги
        private void panelSavedBooks_Paint(object sender, PaintEventArgs e)
        {
            
        }

        //блок кода который отвечает за формат книги
        public void LabelFormat(string l3, string l4, string l5, string l6)
        {
            labelFormat3.Text = l3;
            labelFormat4.Text = l4;
            labelFormat5.Text = l5;
            labelFormat6.Text = l6;
        }
        private void trackBarChooseFormat_ValueChanged(object sender, EventArgs e)
        {
            //создание экземпляра класса
            Format find = new Format();
            find.EditLableFormat(labelFormat3.ToString(), labelFormat4.ToString(), 
                labelFormat5.ToString(), labelFormat6.ToString(), comboBoxChooseFormat.ToString());
            labelFormarMM.Text = find.FindFormatMM(comboBoxChooseFormat.SelectedIndex.ToString(), 
                comboBoxChooseFormat.ToString());
        }

        private void trackBarChooseFormat_Scroll(object sender, EventArgs e)
        {
            //создание экземпляра класса
            Format find = new Format();
            //вызов поиска формата 
            find.EditLableFormat(labelFormat3.ToString(), labelFormat4.ToString(),
                labelFormat5.ToString(), labelFormat6.ToString(), comboBoxChooseFormat.ToString());
            labelFormarMM.Text = find.FindFormatMM(comboBoxChooseFormat.SelectedIndex.ToString(),
                comboBoxChooseFormat.ToString());
        }

        private void comboBoxChooseFormat_SelectedIndexChanged(object sender, EventArgs e)
        {
            Format format = new Format();
            format.EditLableFormat(labelFormat3.ToString(), labelFormat4.ToString(), labelFormat5.ToString(),
                labelFormat6.ToString(), comboBoxChooseFormat.ToString());
            format.FindFormatMM();
        }
    }
}