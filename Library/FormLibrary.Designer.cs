namespace Library
{
    partial class Library
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.PictureBox pictureWindowICO;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Library));
            System.Windows.Forms.Label labelWindowsTextICO;
            System.Windows.Forms.Label labelName;
            System.Windows.Forms.Label labelYear;
            System.Windows.Forms.Label labelDayMounthYear;
            System.Windows.Forms.Label labelPublisher;
            System.Windows.Forms.Label labelPagesMain;
            System.Windows.Forms.Label labelPages;
            System.Windows.Forms.Label label1Author;
            System.Windows.Forms.Label labelFormat;
            System.Windows.Forms.Label labelDescription;
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelMoveWindow = new System.Windows.Forms.Label();
            this.panelCreateNewBook = new System.Windows.Forms.Panel();
            this.buttonSaveCoverBook = new System.Windows.Forms.Button();
            this.buttonClearBook = new System.Windows.Forms.Button();
            this.buttonDeleteCoverBook = new System.Windows.Forms.Button();
            this.buttonUploadCover = new System.Windows.Forms.Button();
            this.pictureBoxBookCover = new System.Windows.Forms.PictureBox();
            this.buttonSaveBook = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxChooseFormat = new System.Windows.Forms.ComboBox();
            this.buttonDelete3Author = new System.Windows.Forms.Button();
            this.richTextBoxDescription = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3Author = new System.Windows.Forms.TextBox();
            this.labelFormarMM = new System.Windows.Forms.Label();
            this.labelFormat6 = new System.Windows.Forms.Label();
            this.labelFormat5 = new System.Windows.Forms.Label();
            this.label3Author = new System.Windows.Forms.Label();
            this.labelFormat4 = new System.Windows.Forms.Label();
            this.labelFormat3 = new System.Windows.Forms.Label();
            this.trackBarChooseFormat = new System.Windows.Forms.TrackBar();
            this.textBox1Author = new System.Windows.Forms.TextBox();
            this.buttonDelete2Author = new System.Windows.Forms.Button();
            this.textBoxPublisher = new System.Windows.Forms.TextBox();
            this.textBox2Author = new System.Windows.Forms.TextBox();
            this.label2Author = new System.Windows.Forms.Label();
            this.textBoxPages = new System.Windows.Forms.TextBox();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.textBoxNameBook = new System.Windows.Forms.TextBox();
            this.buttonCreateNewBook = new System.Windows.Forms.Button();
            this.buttonSavedBooks = new System.Windows.Forms.Button();
            this.openFileDialogUploadCoverBook = new System.Windows.Forms.OpenFileDialog();
            pictureWindowICO = new System.Windows.Forms.PictureBox();
            labelWindowsTextICO = new System.Windows.Forms.Label();
            labelName = new System.Windows.Forms.Label();
            labelYear = new System.Windows.Forms.Label();
            labelDayMounthYear = new System.Windows.Forms.Label();
            labelPublisher = new System.Windows.Forms.Label();
            labelPagesMain = new System.Windows.Forms.Label();
            labelPages = new System.Windows.Forms.Label();
            label1Author = new System.Windows.Forms.Label();
            labelFormat = new System.Windows.Forms.Label();
            labelDescription = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(pictureWindowICO)).BeginInit();
            this.panelCreateNewBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBookCover)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarChooseFormat)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureWindowICO
            // 
            pictureWindowICO.BackColor = System.Drawing.Color.White;
            pictureWindowICO.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureWindowICO.BackgroundImage")));
            pictureWindowICO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            pictureWindowICO.ErrorImage = null;
            pictureWindowICO.InitialImage = null;
            pictureWindowICO.Location = new System.Drawing.Point(1, 1);
            pictureWindowICO.Name = "pictureWindowICO";
            pictureWindowICO.Size = new System.Drawing.Size(35, 27);
            pictureWindowICO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureWindowICO.TabIndex = 101;
            pictureWindowICO.TabStop = false;
            // 
            // labelWindowsTextICO
            // 
            labelWindowsTextICO.BackColor = System.Drawing.Color.White;
            labelWindowsTextICO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            labelWindowsTextICO.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            labelWindowsTextICO.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            labelWindowsTextICO.Location = new System.Drawing.Point(35, 2);
            labelWindowsTextICO.Name = "labelWindowsTextICO";
            labelWindowsTextICO.Size = new System.Drawing.Size(64, 26);
            labelWindowsTextICO.TabIndex = 102;
            labelWindowsTextICO.Text = "Library";
            labelWindowsTextICO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            labelWindowsTextICO.UseMnemonic = false;
            // 
            // labelName
            // 
            labelName.CausesValidation = false;
            labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            labelName.ForeColor = System.Drawing.Color.Black;
            labelName.Location = new System.Drawing.Point(168, 5);
            labelName.Name = "labelName";
            labelName.Size = new System.Drawing.Size(77, 20);
            labelName.TabIndex = 2;
            labelName.Text = "Название ";
            labelName.UseMnemonic = false;
            // 
            // labelYear
            // 
            labelYear.CausesValidation = false;
            labelYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            labelYear.ForeColor = System.Drawing.SystemColors.Desktop;
            labelYear.Location = new System.Drawing.Point(168, 33);
            labelYear.Name = "labelYear";
            labelYear.Size = new System.Drawing.Size(99, 20);
            labelYear.TabIndex = 1002;
            labelYear.Text = "Дата выпуска";
            labelYear.UseMnemonic = false;
            // 
            // labelDayMounthYear
            // 
            labelDayMounthYear.CausesValidation = false;
            labelDayMounthYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            labelDayMounthYear.ForeColor = System.Drawing.SystemColors.Desktop;
            labelDayMounthYear.Location = new System.Drawing.Point(379, 35);
            labelDayMounthYear.Name = "labelDayMounthYear";
            labelDayMounthYear.Size = new System.Drawing.Size(83, 15);
            labelDayMounthYear.TabIndex = 1004;
            labelDayMounthYear.Text = "day/мonth/year";
            labelDayMounthYear.UseMnemonic = false;
            // 
            // labelPublisher
            // 
            labelPublisher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            labelPublisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            labelPublisher.Location = new System.Drawing.Point(168, 89);
            labelPublisher.Name = "labelPublisher";
            labelPublisher.Size = new System.Drawing.Size(77, 18);
            labelPublisher.TabIndex = 1005;
            labelPublisher.Text = "Издатель";
            labelPublisher.UseMnemonic = false;
            // 
            // labelPagesMain
            // 
            labelPagesMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            labelPagesMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            labelPagesMain.Location = new System.Drawing.Point(169, 61);
            labelPagesMain.Name = "labelPagesMain";
            labelPagesMain.Size = new System.Drawing.Size(196, 18);
            labelPagesMain.TabIndex = 1006;
            labelPagesMain.Text = "Количество страниц в книге";
            labelPagesMain.UseMnemonic = false;
            // 
            // labelPages
            // 
            labelPages.BackColor = System.Drawing.Color.White;
            labelPages.CausesValidation = false;
            labelPages.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            labelPages.ForeColor = System.Drawing.Color.Black;
            labelPages.Location = new System.Drawing.Point(443, 65);
            labelPages.Name = "labelPages";
            labelPages.Size = new System.Drawing.Size(23, 15);
            labelPages.TabIndex = 1008;
            labelPages.Text = "ст.";
            labelPages.UseMnemonic = false;
            // 
            // label1Author
            // 
            label1Author.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            label1Author.Location = new System.Drawing.Point(169, 162);
            label1Author.Name = "label1Author";
            label1Author.Size = new System.Drawing.Size(83, 18);
            label1Author.TabIndex = 1010;
            label1Author.Text = "1-ый автор";
            label1Author.UseMnemonic = false;
            // 
            // labelFormat
            // 
            labelFormat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            labelFormat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            labelFormat.Location = new System.Drawing.Point(168, 122);
            labelFormat.Name = "labelFormat";
            labelFormat.Size = new System.Drawing.Size(63, 18);
            labelFormat.TabIndex = 1019;
            labelFormat.Text = "Формат";
            labelFormat.UseMnemonic = false;
            // 
            // labelDescription
            // 
            labelDescription.AutoSize = true;
            labelDescription.BackColor = System.Drawing.Color.WhiteSmoke;
            labelDescription.CausesValidation = false;
            labelDescription.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            labelDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            labelDescription.Location = new System.Drawing.Point(168, 245);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new System.Drawing.Size(113, 16);
            labelDescription.TabIndex = 106;
            labelDescription.Text = "Описание книги";
            labelDescription.UseMnemonic = false;
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.White;
            this.buttonExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExit.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonExit.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.buttonExit.Location = new System.Drawing.Point(1211, 2);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(51, 26);
            this.buttonExit.TabIndex = 0;
            this.buttonExit.TabStop = false;
            this.buttonExit.Text = "X";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // labelMoveWindow
            // 
            this.labelMoveWindow.BackColor = System.Drawing.Color.White;
            this.labelMoveWindow.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.labelMoveWindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelMoveWindow.Location = new System.Drawing.Point(97, 2);
            this.labelMoveWindow.Name = "labelMoveWindow";
            this.labelMoveWindow.Size = new System.Drawing.Size(1117, 26);
            this.labelMoveWindow.TabIndex = 100;
            this.labelMoveWindow.UseMnemonic = false;
            this.labelMoveWindow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelMoveWindow_MouseDown);
            this.labelMoveWindow.MouseMove += new System.Windows.Forms.MouseEventHandler(this.labelMoveWindow_MouseMove);
            this.labelMoveWindow.MouseUp += new System.Windows.Forms.MouseEventHandler(this.labelMoveWindow_MouseUp);
            // 
            // panelCreateNewBook
            // 
            this.panelCreateNewBook.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelCreateNewBook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelCreateNewBook.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCreateNewBook.Controls.Add(this.buttonSaveCoverBook);
            this.panelCreateNewBook.Controls.Add(this.buttonClearBook);
            this.panelCreateNewBook.Controls.Add(this.buttonDeleteCoverBook);
            this.panelCreateNewBook.Controls.Add(this.buttonUploadCover);
            this.panelCreateNewBook.Controls.Add(this.pictureBoxBookCover);
            this.panelCreateNewBook.Controls.Add(this.buttonSaveBook);
            this.panelCreateNewBook.Controls.Add(this.button1);
            this.panelCreateNewBook.Controls.Add(labelDescription);
            this.panelCreateNewBook.Controls.Add(this.comboBoxChooseFormat);
            this.panelCreateNewBook.Controls.Add(this.buttonDelete3Author);
            this.panelCreateNewBook.Controls.Add(this.richTextBoxDescription);
            this.panelCreateNewBook.Controls.Add(this.label5);
            this.panelCreateNewBook.Controls.Add(this.textBox3Author);
            this.panelCreateNewBook.Controls.Add(this.labelFormarMM);
            this.panelCreateNewBook.Controls.Add(this.labelFormat6);
            this.panelCreateNewBook.Controls.Add(this.labelFormat5);
            this.panelCreateNewBook.Controls.Add(this.label3Author);
            this.panelCreateNewBook.Controls.Add(this.labelFormat4);
            this.panelCreateNewBook.Controls.Add(this.labelFormat3);
            this.panelCreateNewBook.Controls.Add(labelFormat);
            this.panelCreateNewBook.Controls.Add(label1Author);
            this.panelCreateNewBook.Controls.Add(this.trackBarChooseFormat);
            this.panelCreateNewBook.Controls.Add(this.textBox1Author);
            this.panelCreateNewBook.Controls.Add(this.buttonDelete2Author);
            this.panelCreateNewBook.Controls.Add(this.textBoxPublisher);
            this.panelCreateNewBook.Controls.Add(labelPages);
            this.panelCreateNewBook.Controls.Add(this.textBox2Author);
            this.panelCreateNewBook.Controls.Add(labelPagesMain);
            this.panelCreateNewBook.Controls.Add(this.label2Author);
            this.panelCreateNewBook.Controls.Add(labelPublisher);
            this.panelCreateNewBook.Controls.Add(this.textBoxPages);
            this.panelCreateNewBook.Controls.Add(labelDayMounthYear);
            this.panelCreateNewBook.Controls.Add(this.textBoxYear);
            this.panelCreateNewBook.Controls.Add(labelYear);
            this.panelCreateNewBook.Controls.Add(labelName);
            this.panelCreateNewBook.Controls.Add(this.textBoxNameBook);
            this.panelCreateNewBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panelCreateNewBook.Location = new System.Drawing.Point(12, 63);
            this.panelCreateNewBook.Name = "panelCreateNewBook";
            this.panelCreateNewBook.Size = new System.Drawing.Size(480, 425);
            this.panelCreateNewBook.TabIndex = 103;
            this.panelCreateNewBook.Visible = false;
            // 
            // buttonSaveCoverBook
            // 
            this.buttonSaveCoverBook.BackColor = System.Drawing.Color.White;
            this.buttonSaveCoverBook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonSaveCoverBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSaveCoverBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveCoverBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSaveCoverBook.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonSaveCoverBook.Location = new System.Drawing.Point(17, 239);
            this.buttonSaveCoverBook.Name = "buttonSaveCoverBook";
            this.buttonSaveCoverBook.Size = new System.Drawing.Size(120, 25);
            this.buttonSaveCoverBook.TabIndex = 1032;
            this.buttonSaveCoverBook.TabStop = false;
            this.buttonSaveCoverBook.Text = "Сохранить обложку";
            this.buttonSaveCoverBook.UseMnemonic = false;
            this.buttonSaveCoverBook.UseVisualStyleBackColor = false;
            this.buttonSaveCoverBook.Click += new System.EventHandler(this.buttonSaveCoverBook_Click);
            // 
            // buttonClearBook
            // 
            this.buttonClearBook.BackColor = System.Drawing.Color.White;
            this.buttonClearBook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonClearBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClearBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClearBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClearBook.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonClearBook.Location = new System.Drawing.Point(17, 301);
            this.buttonClearBook.Name = "buttonClearBook";
            this.buttonClearBook.Size = new System.Drawing.Size(120, 25);
            this.buttonClearBook.TabIndex = 1031;
            this.buttonClearBook.TabStop = false;
            this.buttonClearBook.Text = "Очистить книгу";
            this.buttonClearBook.UseMnemonic = false;
            this.buttonClearBook.UseVisualStyleBackColor = false;
            this.buttonClearBook.Click += new System.EventHandler(this.buttonClearBook_Click);
            // 
            // buttonDeleteCoverBook
            // 
            this.buttonDeleteCoverBook.BackColor = System.Drawing.Color.White;
            this.buttonDeleteCoverBook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonDeleteCoverBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDeleteCoverBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteCoverBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDeleteCoverBook.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonDeleteCoverBook.Location = new System.Drawing.Point(17, 270);
            this.buttonDeleteCoverBook.Name = "buttonDeleteCoverBook";
            this.buttonDeleteCoverBook.Size = new System.Drawing.Size(120, 25);
            this.buttonDeleteCoverBook.TabIndex = 1030;
            this.buttonDeleteCoverBook.TabStop = false;
            this.buttonDeleteCoverBook.Text = "Удалить обложку";
            this.buttonDeleteCoverBook.UseMnemonic = false;
            this.buttonDeleteCoverBook.UseVisualStyleBackColor = false;
            this.buttonDeleteCoverBook.Click += new System.EventHandler(this.buttonClearCoverBook_Click);
            // 
            // buttonUploadCover
            // 
            this.buttonUploadCover.BackColor = System.Drawing.Color.White;
            this.buttonUploadCover.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonUploadCover.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonUploadCover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUploadCover.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonUploadCover.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonUploadCover.Location = new System.Drawing.Point(17, 208);
            this.buttonUploadCover.Name = "buttonUploadCover";
            this.buttonUploadCover.Size = new System.Drawing.Size(120, 25);
            this.buttonUploadCover.TabIndex = 1029;
            this.buttonUploadCover.TabStop = false;
            this.buttonUploadCover.Text = "Загрузить обложку";
            this.buttonUploadCover.UseMnemonic = false;
            this.buttonUploadCover.UseVisualStyleBackColor = false;
            this.buttonUploadCover.Click += new System.EventHandler(this.buttonUploadCover_Click);
            // 
            // pictureBoxBookCover
            // 
            this.pictureBoxBookCover.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxBookCover.ErrorImage")));
            this.pictureBoxBookCover.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBookCover.Image")));
            this.pictureBoxBookCover.InitialImage = null;
            this.pictureBoxBookCover.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxBookCover.Name = "pictureBoxBookCover";
            this.pictureBoxBookCover.Size = new System.Drawing.Size(160, 200);
            this.pictureBoxBookCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBookCover.TabIndex = 1028;
            this.pictureBoxBookCover.TabStop = false;
            // 
            // buttonSaveBook
            // 
            this.buttonSaveBook.BackColor = System.Drawing.Color.White;
            this.buttonSaveBook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonSaveBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSaveBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSaveBook.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonSaveBook.Location = new System.Drawing.Point(165, 378);
            this.buttonSaveBook.Name = "buttonSaveBook";
            this.buttonSaveBook.Size = new System.Drawing.Size(150, 30);
            this.buttonSaveBook.TabIndex = 1027;
            this.buttonSaveBook.TabStop = false;
            this.buttonSaveBook.Text = "Сохранить";
            this.buttonSaveBook.UseMnemonic = false;
            this.buttonSaveBook.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button1.Location = new System.Drawing.Point(443, 159);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(20, 22);
            this.button1.TabIndex = 1026;
            this.button1.TabStop = false;
            this.button1.Text = "Х";
            this.button1.UseMnemonic = false;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // comboBoxChooseFormat
            // 
            this.comboBoxChooseFormat.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboBoxChooseFormat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxChooseFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxChooseFormat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxChooseFormat.FormattingEnabled = true;
            this.comboBoxChooseFormat.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.comboBoxChooseFormat.Location = new System.Drawing.Point(232, 119);
            this.comboBoxChooseFormat.Name = "comboBoxChooseFormat";
            this.comboBoxChooseFormat.Size = new System.Drawing.Size(35, 24);
            this.comboBoxChooseFormat.TabIndex = 105;
            this.comboBoxChooseFormat.TabStop = false;
            this.comboBoxChooseFormat.SelectedIndexChanged += new System.EventHandler(this.comboBoxChooseFormat_SelectedIndexChanged);
            // 
            // buttonDelete3Author
            // 
            this.buttonDelete3Author.BackColor = System.Drawing.Color.White;
            this.buttonDelete3Author.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonDelete3Author.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDelete3Author.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete3Author.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDelete3Author.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonDelete3Author.Location = new System.Drawing.Point(443, 220);
            this.buttonDelete3Author.Name = "buttonDelete3Author";
            this.buttonDelete3Author.Size = new System.Drawing.Size(20, 22);
            this.buttonDelete3Author.TabIndex = 1018;
            this.buttonDelete3Author.TabStop = false;
            this.buttonDelete3Author.Text = "Х";
            this.buttonDelete3Author.UseMnemonic = false;
            this.buttonDelete3Author.UseVisualStyleBackColor = false;
            this.buttonDelete3Author.Click += new System.EventHandler(this.buttonDelete3Author_Click);
            // 
            // richTextBoxDescription
            // 
            this.richTextBoxDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBoxDescription.Location = new System.Drawing.Point(171, 264);
            this.richTextBoxDescription.MaxLength = 500;
            this.richTextBoxDescription.Name = "richTextBoxDescription";
            this.richTextBoxDescription.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBoxDescription.Size = new System.Drawing.Size(292, 99);
            this.richTextBoxDescription.TabIndex = 105;
            this.richTextBoxDescription.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(426, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 16);
            this.label5.TabIndex = 1025;
            this.label5.Text = "мм";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox3Author
            // 
            this.textBox3Author.BackColor = System.Drawing.Color.White;
            this.textBox3Author.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3Author.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox3Author.ForeColor = System.Drawing.Color.Black;
            this.textBox3Author.Location = new System.Drawing.Point(252, 220);
            this.textBox3Author.MaxLength = 60;
            this.textBox3Author.Name = "textBox3Author";
            this.textBox3Author.Size = new System.Drawing.Size(185, 22);
            this.textBox3Author.TabIndex = 1017;
            this.textBox3Author.TabStop = false;
            this.textBox3Author.WordWrap = false;
            // 
            // labelFormarMM
            // 
            this.labelFormarMM.Location = new System.Drawing.Point(402, 119);
            this.labelFormarMM.Name = "labelFormarMM";
            this.labelFormarMM.Size = new System.Drawing.Size(69, 22);
            this.labelFormarMM.TabIndex = 1024;
            this.labelFormarMM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelFormarMM.UseMnemonic = false;
            // 
            // labelFormat6
            // 
            this.labelFormat6.AutoSize = true;
            this.labelFormat6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFormat6.Location = new System.Drawing.Point(380, 143);
            this.labelFormat6.Name = "labelFormat6";
            this.labelFormat6.Size = new System.Drawing.Size(13, 13);
            this.labelFormat6.TabIndex = 1023;
            this.labelFormat6.Text = "6";
            // 
            // labelFormat5
            // 
            this.labelFormat5.AutoSize = true;
            this.labelFormat5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFormat5.Location = new System.Drawing.Point(346, 144);
            this.labelFormat5.Name = "labelFormat5";
            this.labelFormat5.Size = new System.Drawing.Size(13, 13);
            this.labelFormat5.TabIndex = 1022;
            this.labelFormat5.Text = "5";
            // 
            // label3Author
            // 
            this.label3Author.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3Author.Location = new System.Drawing.Point(169, 222);
            this.label3Author.Name = "label3Author";
            this.label3Author.Size = new System.Drawing.Size(77, 18);
            this.label3Author.TabIndex = 1016;
            this.label3Author.Text = "3-ий автор";
            this.label3Author.UseMnemonic = false;
            // 
            // labelFormat4
            // 
            this.labelFormat4.AutoSize = true;
            this.labelFormat4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFormat4.Location = new System.Drawing.Point(313, 143);
            this.labelFormat4.Name = "labelFormat4";
            this.labelFormat4.Size = new System.Drawing.Size(13, 13);
            this.labelFormat4.TabIndex = 1021;
            this.labelFormat4.Text = "4";
            // 
            // labelFormat3
            // 
            this.labelFormat3.AutoSize = true;
            this.labelFormat3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFormat3.Location = new System.Drawing.Point(280, 143);
            this.labelFormat3.Name = "labelFormat3";
            this.labelFormat3.Size = new System.Drawing.Size(13, 13);
            this.labelFormat3.TabIndex = 1020;
            this.labelFormat3.Text = "3";
            // 
            // trackBarChooseFormat
            // 
            this.trackBarChooseFormat.AutoSize = false;
            this.trackBarChooseFormat.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.trackBarChooseFormat.LargeChange = 1;
            this.trackBarChooseFormat.Location = new System.Drawing.Point(273, 115);
            this.trackBarChooseFormat.Maximum = 6;
            this.trackBarChooseFormat.Minimum = 3;
            this.trackBarChooseFormat.Name = "trackBarChooseFormat";
            this.trackBarChooseFormat.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.trackBarChooseFormat.Size = new System.Drawing.Size(125, 25);
            this.trackBarChooseFormat.TabIndex = 1050;
            this.trackBarChooseFormat.TabStop = false;
            this.trackBarChooseFormat.Value = 5;
            this.trackBarChooseFormat.Scroll += new System.EventHandler(this.trackBarChooseFormat_Scroll);
            this.trackBarChooseFormat.ValueChanged += new System.EventHandler(this.trackBarChooseFormat_ValueChanged);
            // 
            // textBox1Author
            // 
            this.textBox1Author.BackColor = System.Drawing.Color.White;
            this.textBox1Author.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1Author.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1Author.ForeColor = System.Drawing.Color.Black;
            this.textBox1Author.Location = new System.Drawing.Point(252, 160);
            this.textBox1Author.MaxLength = 60;
            this.textBox1Author.Name = "textBox1Author";
            this.textBox1Author.Size = new System.Drawing.Size(185, 22);
            this.textBox1Author.TabIndex = 1011;
            this.textBox1Author.TabStop = false;
            this.textBox1Author.WordWrap = false;
            // 
            // buttonDelete2Author
            // 
            this.buttonDelete2Author.BackColor = System.Drawing.Color.White;
            this.buttonDelete2Author.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonDelete2Author.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDelete2Author.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete2Author.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDelete2Author.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonDelete2Author.Location = new System.Drawing.Point(443, 189);
            this.buttonDelete2Author.Name = "buttonDelete2Author";
            this.buttonDelete2Author.Size = new System.Drawing.Size(20, 22);
            this.buttonDelete2Author.TabIndex = 1014;
            this.buttonDelete2Author.TabStop = false;
            this.buttonDelete2Author.Text = "Х";
            this.buttonDelete2Author.UseMnemonic = false;
            this.buttonDelete2Author.UseVisualStyleBackColor = false;
            this.buttonDelete2Author.Click += new System.EventHandler(this.buttonDelete2Author_Click);
            // 
            // textBoxPublisher
            // 
            this.textBoxPublisher.BackColor = System.Drawing.Color.White;
            this.textBoxPublisher.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPublisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPublisher.ForeColor = System.Drawing.Color.Black;
            this.textBoxPublisher.Location = new System.Drawing.Point(256, 87);
            this.textBoxPublisher.MaxLength = 60;
            this.textBoxPublisher.Name = "textBoxPublisher";
            this.textBoxPublisher.Size = new System.Drawing.Size(211, 22);
            this.textBoxPublisher.TabIndex = 1009;
            this.textBoxPublisher.TabStop = false;
            this.textBoxPublisher.WordWrap = false;
            // 
            // textBox2Author
            // 
            this.textBox2Author.BackColor = System.Drawing.Color.White;
            this.textBox2Author.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2Author.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2Author.ForeColor = System.Drawing.Color.Black;
            this.textBox2Author.Location = new System.Drawing.Point(252, 190);
            this.textBox2Author.MaxLength = 60;
            this.textBox2Author.Name = "textBox2Author";
            this.textBox2Author.Size = new System.Drawing.Size(185, 22);
            this.textBox2Author.TabIndex = 1013;
            this.textBox2Author.TabStop = false;
            this.textBox2Author.WordWrap = false;
            // 
            // label2Author
            // 
            this.label2Author.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2Author.Location = new System.Drawing.Point(170, 192);
            this.label2Author.Name = "label2Author";
            this.label2Author.Size = new System.Drawing.Size(77, 18);
            this.label2Author.TabIndex = 1012;
            this.label2Author.Text = "2-ой автор";
            this.label2Author.UseMnemonic = false;
            // 
            // textBoxPages
            // 
            this.textBoxPages.BackColor = System.Drawing.Color.White;
            this.textBoxPages.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPages.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPages.ForeColor = System.Drawing.Color.Black;
            this.textBoxPages.Location = new System.Drawing.Point(371, 59);
            this.textBoxPages.MaxLength = 6;
            this.textBoxPages.Name = "textBoxPages";
            this.textBoxPages.Size = new System.Drawing.Size(96, 22);
            this.textBoxPages.TabIndex = 1007;
            this.textBoxPages.TabStop = false;
            this.textBoxPages.WordWrap = false;
            // 
            // textBoxYear
            // 
            this.textBoxYear.BackColor = System.Drawing.Color.White;
            this.textBoxYear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxYear.ForeColor = System.Drawing.Color.Black;
            this.textBoxYear.Location = new System.Drawing.Point(273, 31);
            this.textBoxYear.MaxLength = 10;
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(100, 22);
            this.textBoxYear.TabIndex = 1003;
            this.textBoxYear.TabStop = false;
            this.textBoxYear.WordWrap = false;
            // 
            // textBoxNameBook
            // 
            this.textBoxNameBook.BackColor = System.Drawing.Color.White;
            this.textBoxNameBook.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxNameBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxNameBook.ForeColor = System.Drawing.Color.Black;
            this.textBoxNameBook.Location = new System.Drawing.Point(256, 3);
            this.textBoxNameBook.MaxLength = 50;
            this.textBoxNameBook.Name = "textBoxNameBook";
            this.textBoxNameBook.Size = new System.Drawing.Size(211, 22);
            this.textBoxNameBook.TabIndex = 0;
            this.textBoxNameBook.TabStop = false;
            this.textBoxNameBook.WordWrap = false;
            // 
            // buttonCreateNewBook
            // 
            this.buttonCreateNewBook.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonCreateNewBook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonCreateNewBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCreateNewBook.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.buttonCreateNewBook.FlatAppearance.BorderSize = 0;
            this.buttonCreateNewBook.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.buttonCreateNewBook.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonCreateNewBook.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCreateNewBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCreateNewBook.ForeColor = System.Drawing.Color.Black;
            this.buttonCreateNewBook.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonCreateNewBook.Location = new System.Drawing.Point(12, 34);
            this.buttonCreateNewBook.Name = "buttonCreateNewBook";
            this.buttonCreateNewBook.Size = new System.Drawing.Size(120, 26);
            this.buttonCreateNewBook.TabIndex = 104;
            this.buttonCreateNewBook.TabStop = false;
            this.buttonCreateNewBook.Text = "Добавить книгу";
            this.buttonCreateNewBook.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonCreateNewBook.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonCreateNewBook.UseMnemonic = false;
            this.buttonCreateNewBook.UseVisualStyleBackColor = false;
            this.buttonCreateNewBook.Click += new System.EventHandler(this.buttonCreateNewBook_Click);
            // 
            // buttonSavedBooks
            // 
            this.buttonSavedBooks.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonSavedBooks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonSavedBooks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSavedBooks.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.buttonSavedBooks.FlatAppearance.BorderSize = 0;
            this.buttonSavedBooks.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.buttonSavedBooks.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonSavedBooks.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSavedBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSavedBooks.ForeColor = System.Drawing.Color.Black;
            this.buttonSavedBooks.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonSavedBooks.Location = new System.Drawing.Point(138, 34);
            this.buttonSavedBooks.Name = "buttonSavedBooks";
            this.buttonSavedBooks.Size = new System.Drawing.Size(146, 26);
            this.buttonSavedBooks.TabIndex = 106;
            this.buttonSavedBooks.TabStop = false;
            this.buttonSavedBooks.Text = "Сохраненные книги";
            this.buttonSavedBooks.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonSavedBooks.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonSavedBooks.UseMnemonic = false;
            this.buttonSavedBooks.UseVisualStyleBackColor = false;
            // 
            // openFileDialogUploadCoverBook
            // 
            this.openFileDialogUploadCoverBook.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialogUploadCoverBook_FileOk);
            // 
            // Library
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.buttonSavedBooks);
            this.Controls.Add(this.buttonCreateNewBook);
            this.Controls.Add(this.panelCreateNewBook);
            this.Controls.Add(labelWindowsTextICO);
            this.Controls.Add(pictureWindowICO);
            this.Controls.Add(this.labelMoveWindow);
            this.Controls.Add(this.buttonExit);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Library";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Library";
            ((System.ComponentModel.ISupportInitialize)(pictureWindowICO)).EndInit();
            this.panelCreateNewBook.ResumeLayout(false);
            this.panelCreateNewBook.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBookCover)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarChooseFormat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelMoveWindow;
        private System.Windows.Forms.Panel panelCreateNewBook;
        private System.Windows.Forms.Button buttonCreateNewBook;
        public System.Windows.Forms.TextBox textBoxNameBook;
        public System.Windows.Forms.TextBox textBoxYear;
        public System.Windows.Forms.TextBox textBoxPages;
        public System.Windows.Forms.TextBox textBoxPublisher;
        public System.Windows.Forms.TextBox textBox1Author;
        public System.Windows.Forms.TextBox textBox2Author;
        public System.Windows.Forms.Label label2Author;
        private System.Windows.Forms.Button buttonDelete2Author;
        private System.Windows.Forms.Button buttonDelete3Author;
        public System.Windows.Forms.TextBox textBox3Author;
        public System.Windows.Forms.Label label3Author;
        private System.Windows.Forms.TrackBar trackBarChooseFormat;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label labelFormarMM;
        private System.Windows.Forms.ComboBox comboBoxChooseFormat;
        public System.Windows.Forms.Label labelFormat6;
        public System.Windows.Forms.Label labelFormat5;
        public System.Windows.Forms.Label labelFormat4;
        public System.Windows.Forms.Label labelFormat3;
        public System.Windows.Forms.RichTextBox richTextBoxDescription;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonSaveBook;
        private System.Windows.Forms.Button buttonSavedBooks;
        private System.Windows.Forms.Button buttonUploadCover;
        private System.Windows.Forms.PictureBox pictureBoxBookCover;
        private System.Windows.Forms.Button buttonDeleteCoverBook;
        private System.Windows.Forms.OpenFileDialog openFileDialogUploadCoverBook;
        private System.Windows.Forms.Button buttonClearBook;
        private System.Windows.Forms.Button buttonSaveCoverBook;
    }
}

