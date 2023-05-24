namespace LibraryWF
{
    partial class Library
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lLibrary = new System.Windows.Forms.Label();
            this.gBoxEditBook = new System.Windows.Forms.GroupBox();
            this.tBoxGenre = new System.Windows.Forms.TextBox();
            this.btnAddGenre = new System.Windows.Forms.Button();
            this.groupBoxAddBook = new System.Windows.Forms.GroupBox();
            this.tBoxAuthor = new System.Windows.Forms.TextBox();
            this.lGenre = new System.Windows.Forms.Label();
            this.tBoxTitle = new System.Windows.Forms.TextBox();
            this.lAuthor = new System.Windows.Forms.Label();
            this.comboBoxGenre = new System.Windows.Forms.ComboBox();
            this.lTitle = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.comboBoxDelete = new System.Windows.Forms.ComboBox();
            this.btnDeleteBook = new System.Windows.Forms.Button();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.gBoxManageBook = new System.Windows.Forms.GroupBox();
            this.lManageBookLabel = new System.Windows.Forms.Label();
            this.lLendOk = new System.Windows.Forms.Label();
            this.btnSelect = new System.Windows.Forms.Button();
            this.comboBoxBooks = new System.Windows.Forms.ComboBox();
            this.btnReturnBook = new System.Windows.Forms.Button();
            this.btnLendBook = new System.Windows.Forms.Button();
            this.listViewListBooks = new System.Windows.Forms.ListView();
            this.Title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Author = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Genre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnListAllBooks = new System.Windows.Forms.Button();
            this.btnManageBooks = new System.Windows.Forms.Button();
            this.btnEditBooks = new System.Windows.Forms.Button();
            this.tBoxSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.gBoxEditBook.SuspendLayout();
            this.groupBoxAddBook.SuspendLayout();
            this.gBoxManageBook.SuspendLayout();
            this.SuspendLayout();
            // 
            // lLibrary
            // 
            this.lLibrary.AutoSize = true;
            this.lLibrary.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lLibrary.Location = new System.Drawing.Point(29, 24);
            this.lLibrary.Name = "lLibrary";
            this.lLibrary.Size = new System.Drawing.Size(174, 54);
            this.lLibrary.TabIndex = 0;
            this.lLibrary.Text = "Library";
            // 
            // gBoxEditBook
            // 
            this.gBoxEditBook.Controls.Add(this.tBoxGenre);
            this.gBoxEditBook.Controls.Add(this.btnAddGenre);
            this.gBoxEditBook.Controls.Add(this.groupBoxAddBook);
            this.gBoxEditBook.Controls.Add(this.btnSubmit);
            this.gBoxEditBook.Controls.Add(this.comboBoxDelete);
            this.gBoxEditBook.Controls.Add(this.btnDeleteBook);
            this.gBoxEditBook.Controls.Add(this.btnAddBook);
            this.gBoxEditBook.Location = new System.Drawing.Point(282, 238);
            this.gBoxEditBook.Name = "gBoxEditBook";
            this.gBoxEditBook.Size = new System.Drawing.Size(264, 240);
            this.gBoxEditBook.TabIndex = 1;
            this.gBoxEditBook.TabStop = false;
            this.gBoxEditBook.Text = "Edit Books";
            this.gBoxEditBook.Visible = false;
            // 
            // tBoxGenre
            // 
            this.tBoxGenre.Location = new System.Drawing.Point(88, 53);
            this.tBoxGenre.Name = "tBoxGenre";
            this.tBoxGenre.Size = new System.Drawing.Size(157, 20);
            this.tBoxGenre.TabIndex = 14;
            this.tBoxGenre.Visible = false;
            // 
            // btnAddGenre
            // 
            this.btnAddGenre.Location = new System.Drawing.Point(6, 77);
            this.btnAddGenre.Name = "btnAddGenre";
            this.btnAddGenre.Size = new System.Drawing.Size(75, 23);
            this.btnAddGenre.TabIndex = 13;
            this.btnAddGenre.Text = "Add Genre";
            this.btnAddGenre.UseVisualStyleBackColor = true;
            this.btnAddGenre.Click += new System.EventHandler(this.btnAddGenre_Click);
            // 
            // groupBoxAddBook
            // 
            this.groupBoxAddBook.Controls.Add(this.tBoxAuthor);
            this.groupBoxAddBook.Controls.Add(this.lGenre);
            this.groupBoxAddBook.Controls.Add(this.tBoxTitle);
            this.groupBoxAddBook.Controls.Add(this.lAuthor);
            this.groupBoxAddBook.Controls.Add(this.comboBoxGenre);
            this.groupBoxAddBook.Controls.Add(this.lTitle);
            this.groupBoxAddBook.Location = new System.Drawing.Point(9, 132);
            this.groupBoxAddBook.Name = "groupBoxAddBook";
            this.groupBoxAddBook.Size = new System.Drawing.Size(200, 100);
            this.groupBoxAddBook.TabIndex = 10;
            this.groupBoxAddBook.TabStop = false;
            this.groupBoxAddBook.Visible = false;
            // 
            // tBoxAuthor
            // 
            this.tBoxAuthor.Location = new System.Drawing.Point(56, 39);
            this.tBoxAuthor.Name = "tBoxAuthor";
            this.tBoxAuthor.Size = new System.Drawing.Size(118, 20);
            this.tBoxAuthor.TabIndex = 5;
            // 
            // lGenre
            // 
            this.lGenre.AutoSize = true;
            this.lGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lGenre.Location = new System.Drawing.Point(2, 68);
            this.lGenre.Name = "lGenre";
            this.lGenre.Size = new System.Drawing.Size(45, 13);
            this.lGenre.TabIndex = 9;
            this.lGenre.Text = "Genre:";
            // 
            // tBoxTitle
            // 
            this.tBoxTitle.Location = new System.Drawing.Point(56, 13);
            this.tBoxTitle.Name = "tBoxTitle";
            this.tBoxTitle.Size = new System.Drawing.Size(118, 20);
            this.tBoxTitle.TabIndex = 4;
            // 
            // lAuthor
            // 
            this.lAuthor.AutoSize = true;
            this.lAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lAuthor.Location = new System.Drawing.Point(2, 42);
            this.lAuthor.Name = "lAuthor";
            this.lAuthor.Size = new System.Drawing.Size(48, 13);
            this.lAuthor.TabIndex = 8;
            this.lAuthor.Text = "Author:";
            // 
            // comboBoxGenre
            // 
            this.comboBoxGenre.FormattingEnabled = true;
            this.comboBoxGenre.Location = new System.Drawing.Point(53, 68);
            this.comboBoxGenre.Name = "comboBoxGenre";
            this.comboBoxGenre.Size = new System.Drawing.Size(121, 21);
            this.comboBoxGenre.TabIndex = 6;
            // 
            // lTitle
            // 
            this.lTitle.AutoSize = true;
            this.lTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTitle.Location = new System.Drawing.Point(2, 16);
            this.lTitle.Name = "lTitle";
            this.lTitle.Size = new System.Drawing.Size(36, 13);
            this.lTitle.TabIndex = 7;
            this.lTitle.Text = "Title:";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(6, 106);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Visible = false;
            this.btnSubmit.Click += new System.EventHandler(this.EditBooks);
            // 
            // comboBoxDelete
            // 
            this.comboBoxDelete.FormattingEnabled = true;
            this.comboBoxDelete.Location = new System.Drawing.Point(88, 22);
            this.comboBoxDelete.Name = "comboBoxDelete";
            this.comboBoxDelete.Size = new System.Drawing.Size(157, 21);
            this.comboBoxDelete.TabIndex = 2;
            this.comboBoxDelete.Visible = false;
            // 
            // btnDeleteBook
            // 
            this.btnDeleteBook.Location = new System.Drawing.Point(7, 48);
            this.btnDeleteBook.Name = "btnDeleteBook";
            this.btnDeleteBook.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteBook.TabIndex = 1;
            this.btnDeleteBook.Text = "Delete Book";
            this.btnDeleteBook.UseVisualStyleBackColor = true;
            this.btnDeleteBook.Click += new System.EventHandler(this.btnDeleteBook_Click);
            // 
            // btnAddBook
            // 
            this.btnAddBook.Location = new System.Drawing.Point(7, 20);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(75, 23);
            this.btnAddBook.TabIndex = 0;
            this.btnAddBook.Text = "Add Book";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // gBoxManageBook
            // 
            this.gBoxManageBook.Controls.Add(this.lManageBookLabel);
            this.gBoxManageBook.Controls.Add(this.lLendOk);
            this.gBoxManageBook.Controls.Add(this.btnSelect);
            this.gBoxManageBook.Controls.Add(this.comboBoxBooks);
            this.gBoxManageBook.Controls.Add(this.btnReturnBook);
            this.gBoxManageBook.Controls.Add(this.btnLendBook);
            this.gBoxManageBook.Location = new System.Drawing.Point(282, 24);
            this.gBoxManageBook.Name = "gBoxManageBook";
            this.gBoxManageBook.Size = new System.Drawing.Size(264, 208);
            this.gBoxManageBook.TabIndex = 2;
            this.gBoxManageBook.TabStop = false;
            this.gBoxManageBook.Text = "Manage Books";
            this.gBoxManageBook.Visible = false;
            // 
            // lManageBookLabel
            // 
            this.lManageBookLabel.AutoSize = true;
            this.lManageBookLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lManageBookLabel.Location = new System.Drawing.Point(12, 146);
            this.lManageBookLabel.Name = "lManageBookLabel";
            this.lManageBookLabel.Size = new System.Drawing.Size(0, 13);
            this.lManageBookLabel.TabIndex = 11;
            this.lManageBookLabel.Visible = false;
            // 
            // lLendOk
            // 
            this.lLendOk.AutoSize = true;
            this.lLendOk.Location = new System.Drawing.Point(9, 168);
            this.lLendOk.Name = "lLendOk";
            this.lLendOk.Size = new System.Drawing.Size(0, 13);
            this.lLendOk.TabIndex = 10;
            this.lLendOk.Visible = false;
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(7, 116);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 8;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Visible = false;
            this.btnSelect.Click += new System.EventHandler(this.LendAndReturn);
            // 
            // comboBoxBooks
            // 
            this.comboBoxBooks.FormattingEnabled = true;
            this.comboBoxBooks.Location = new System.Drawing.Point(9, 86);
            this.comboBoxBooks.Name = "comboBoxBooks";
            this.comboBoxBooks.Size = new System.Drawing.Size(157, 21);
            this.comboBoxBooks.TabIndex = 4;
            this.comboBoxBooks.Visible = false;
            // 
            // btnReturnBook
            // 
            this.btnReturnBook.Location = new System.Drawing.Point(7, 50);
            this.btnReturnBook.Name = "btnReturnBook";
            this.btnReturnBook.Size = new System.Drawing.Size(75, 23);
            this.btnReturnBook.TabIndex = 1;
            this.btnReturnBook.Text = "Return Book";
            this.btnReturnBook.UseVisualStyleBackColor = true;
            this.btnReturnBook.Click += new System.EventHandler(this.btnReturnBook_Click);
            // 
            // btnLendBook
            // 
            this.btnLendBook.Location = new System.Drawing.Point(7, 20);
            this.btnLendBook.Name = "btnLendBook";
            this.btnLendBook.Size = new System.Drawing.Size(75, 23);
            this.btnLendBook.TabIndex = 0;
            this.btnLendBook.Text = "Lend Book";
            this.btnLendBook.UseVisualStyleBackColor = true;
            this.btnLendBook.Click += new System.EventHandler(this.btnLendBook_Click);
            // 
            // listViewListBooks
            // 
            this.listViewListBooks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Title,
            this.Author,
            this.Genre});
            this.listViewListBooks.HideSelection = false;
            this.listViewListBooks.Location = new System.Drawing.Point(552, 12);
            this.listViewListBooks.Name = "listViewListBooks";
            this.listViewListBooks.Size = new System.Drawing.Size(547, 433);
            this.listViewListBooks.TabIndex = 4;
            this.listViewListBooks.UseCompatibleStateImageBehavior = false;
            this.listViewListBooks.View = System.Windows.Forms.View.Details;
            this.listViewListBooks.Visible = false;
            // 
            // Title
            // 
            this.Title.Text = "Title";
            this.Title.Width = 200;
            // 
            // Author
            // 
            this.Author.Text = "Author";
            this.Author.Width = 150;
            // 
            // Genre
            // 
            this.Genre.Text = "Genre";
            this.Genre.Width = 150;
            // 
            // btnListAllBooks
            // 
            this.btnListAllBooks.Location = new System.Drawing.Point(38, 110);
            this.btnListAllBooks.Name = "btnListAllBooks";
            this.btnListAllBooks.Size = new System.Drawing.Size(100, 23);
            this.btnListAllBooks.TabIndex = 5;
            this.btnListAllBooks.Text = "List all Books";
            this.btnListAllBooks.UseVisualStyleBackColor = true;
            this.btnListAllBooks.Click += new System.EventHandler(this.btnListAllBooks_Click);
            // 
            // btnManageBooks
            // 
            this.btnManageBooks.Location = new System.Drawing.Point(38, 81);
            this.btnManageBooks.Name = "btnManageBooks";
            this.btnManageBooks.Size = new System.Drawing.Size(100, 23);
            this.btnManageBooks.TabIndex = 6;
            this.btnManageBooks.Text = "ManageBooks";
            this.btnManageBooks.UseVisualStyleBackColor = true;
            this.btnManageBooks.Click += new System.EventHandler(this.btnManageBooks_Click);
            // 
            // btnEditBooks
            // 
            this.btnEditBooks.Location = new System.Drawing.Point(38, 140);
            this.btnEditBooks.Name = "btnEditBooks";
            this.btnEditBooks.Size = new System.Drawing.Size(100, 23);
            this.btnEditBooks.TabIndex = 7;
            this.btnEditBooks.Text = "Edit Books";
            this.btnEditBooks.UseVisualStyleBackColor = true;
            this.btnEditBooks.Visible = false;
            this.btnEditBooks.Click += new System.EventHandler(this.btnEditBooks_Click);
            // 
            // tBoxSearch
            // 
            this.tBoxSearch.Location = new System.Drawing.Point(38, 211);
            this.tBoxSearch.Name = "tBoxSearch";
            this.tBoxSearch.Size = new System.Drawing.Size(100, 20);
            this.tBoxSearch.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Search Book:";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(47, 237);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(29, 502);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(29, 473);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 12;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Library
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 551);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tBoxSearch);
            this.Controls.Add(this.btnEditBooks);
            this.Controls.Add(this.btnManageBooks);
            this.Controls.Add(this.btnListAllBooks);
            this.Controls.Add(this.listViewListBooks);
            this.Controls.Add(this.gBoxManageBook);
            this.Controls.Add(this.gBoxEditBook);
            this.Controls.Add(this.lLibrary);
            this.Name = "Library";
            this.Text = "Library";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gBoxEditBook.ResumeLayout(false);
            this.gBoxEditBook.PerformLayout();
            this.groupBoxAddBook.ResumeLayout(false);
            this.groupBoxAddBook.PerformLayout();
            this.gBoxManageBook.ResumeLayout(false);
            this.gBoxManageBook.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lLibrary;
        private System.Windows.Forms.GroupBox gBoxEditBook;
        private System.Windows.Forms.GroupBox gBoxManageBook;
        private System.Windows.Forms.Button btnDeleteBook;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.ListView listViewListBooks;
        private System.Windows.Forms.Button btnListAllBooks;
        private System.Windows.Forms.Button btnManageBooks;
        private System.Windows.Forms.Button btnEditBooks;
        private System.Windows.Forms.TextBox tBoxSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lGenre;
        private System.Windows.Forms.Label lAuthor;
        private System.Windows.Forms.Label lTitle;
        private System.Windows.Forms.ComboBox comboBoxGenre;
        private System.Windows.Forms.TextBox tBoxAuthor;
        private System.Windows.Forms.TextBox tBoxTitle;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ComboBox comboBoxDelete;
        private System.Windows.Forms.ComboBox comboBoxBooks;
        private System.Windows.Forms.Button btnReturnBook;
        private System.Windows.Forms.Button btnLendBook;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.GroupBox groupBoxAddBook;
        private System.Windows.Forms.TextBox tBoxGenre;
        private System.Windows.Forms.Button btnAddGenre;
        private System.Windows.Forms.Label lLendOk;
        private System.Windows.Forms.Label lManageBookLabel;
        private System.Windows.Forms.ColumnHeader Title;
        private System.Windows.Forms.ColumnHeader Author;
        private System.Windows.Forms.ColumnHeader Genre;
    }
}