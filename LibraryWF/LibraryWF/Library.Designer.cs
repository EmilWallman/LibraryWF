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
            this.gBoxManageBook = new System.Windows.Forms.GroupBox();
            this.listViewListBooks = new System.Windows.Forms.ListView();
            this.btnListAllBooks = new System.Windows.Forms.Button();
            this.btnManageBooks = new System.Windows.Forms.Button();
            this.btnEditBooks = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.listViewSearch = new System.Windows.Forms.ListView();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.btnDeleteBook = new System.Windows.Forms.Button();
            this.comboBoxDelete = new System.Windows.Forms.ComboBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lTitle = new System.Windows.Forms.Label();
            this.lAuthor = new System.Windows.Forms.Label();
            this.lGenre = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.lAlreadyLended = new System.Windows.Forms.Label();
            this.lBookQue = new System.Windows.Forms.Label();
            this.gBoxEditBook.SuspendLayout();
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
            this.gBoxEditBook.Controls.Add(this.lGenre);
            this.gBoxEditBook.Controls.Add(this.lAuthor);
            this.gBoxEditBook.Controls.Add(this.lTitle);
            this.gBoxEditBook.Controls.Add(this.comboBox1);
            this.gBoxEditBook.Controls.Add(this.textBox3);
            this.gBoxEditBook.Controls.Add(this.textBox2);
            this.gBoxEditBook.Controls.Add(this.btnSubmit);
            this.gBoxEditBook.Controls.Add(this.comboBoxDelete);
            this.gBoxEditBook.Controls.Add(this.btnDeleteBook);
            this.gBoxEditBook.Controls.Add(this.btnAddBook);
            this.gBoxEditBook.Location = new System.Drawing.Point(282, 238);
            this.gBoxEditBook.Name = "gBoxEditBook";
            this.gBoxEditBook.Size = new System.Drawing.Size(284, 194);
            this.gBoxEditBook.TabIndex = 1;
            this.gBoxEditBook.TabStop = false;
            this.gBoxEditBook.Text = "Edit Books";
            // 
            // gBoxManageBook
            // 
            this.gBoxManageBook.Controls.Add(this.lBookQue);
            this.gBoxManageBook.Controls.Add(this.lAlreadyLended);
            this.gBoxManageBook.Controls.Add(this.comboBox2);
            this.gBoxManageBook.Controls.Add(this.button4);
            this.gBoxManageBook.Controls.Add(this.button2);
            this.gBoxManageBook.Controls.Add(this.button1);
            this.gBoxManageBook.Location = new System.Drawing.Point(282, 24);
            this.gBoxManageBook.Name = "gBoxManageBook";
            this.gBoxManageBook.Size = new System.Drawing.Size(284, 181);
            this.gBoxManageBook.TabIndex = 2;
            this.gBoxManageBook.TabStop = false;
            this.gBoxManageBook.Text = "Manage Books";
            // 
            // listViewListBooks
            // 
            this.listViewListBooks.HideSelection = false;
            this.listViewListBooks.Location = new System.Drawing.Point(572, 12);
            this.listViewListBooks.Name = "listViewListBooks";
            this.listViewListBooks.Size = new System.Drawing.Size(231, 433);
            this.listViewListBooks.TabIndex = 4;
            this.listViewListBooks.UseCompatibleStateImageBehavior = false;
            // 
            // btnListAllBooks
            // 
            this.btnListAllBooks.Location = new System.Drawing.Point(38, 110);
            this.btnListAllBooks.Name = "btnListAllBooks";
            this.btnListAllBooks.Size = new System.Drawing.Size(100, 23);
            this.btnListAllBooks.TabIndex = 5;
            this.btnListAllBooks.Text = "List all Books";
            this.btnListAllBooks.UseVisualStyleBackColor = true;
            // 
            // btnManageBooks
            // 
            this.btnManageBooks.Location = new System.Drawing.Point(38, 81);
            this.btnManageBooks.Name = "btnManageBooks";
            this.btnManageBooks.Size = new System.Drawing.Size(100, 23);
            this.btnManageBooks.TabIndex = 6;
            this.btnManageBooks.Text = "ManageBooks";
            this.btnManageBooks.UseVisualStyleBackColor = true;
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
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(38, 211);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 8;
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
            this.btnSearch.Location = new System.Drawing.Point(158, 207);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(38, 409);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(38, 380);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 12;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // listViewSearch
            // 
            this.listViewSearch.HideSelection = false;
            this.listViewSearch.Location = new System.Drawing.Point(38, 238);
            this.listViewSearch.Name = "listViewSearch";
            this.listViewSearch.Size = new System.Drawing.Size(195, 97);
            this.listViewSearch.TabIndex = 13;
            this.listViewSearch.UseCompatibleStateImageBehavior = false;
            // 
            // btnAddBook
            // 
            this.btnAddBook.Location = new System.Drawing.Point(7, 20);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(75, 23);
            this.btnAddBook.TabIndex = 0;
            this.btnAddBook.Text = "Add Book";
            this.btnAddBook.UseVisualStyleBackColor = true;
            // 
            // btnDeleteBook
            // 
            this.btnDeleteBook.Location = new System.Drawing.Point(7, 48);
            this.btnDeleteBook.Name = "btnDeleteBook";
            this.btnDeleteBook.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteBook.TabIndex = 1;
            this.btnDeleteBook.Text = "Delete Book";
            this.btnDeleteBook.UseVisualStyleBackColor = true;
            // 
            // comboBoxDelete
            // 
            this.comboBoxDelete.FormattingEnabled = true;
            this.comboBoxDelete.Location = new System.Drawing.Point(104, 22);
            this.comboBoxDelete.Name = "comboBoxDelete";
            this.comboBoxDelete.Size = new System.Drawing.Size(157, 21);
            this.comboBoxDelete.TabIndex = 2;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(7, 74);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(60, 103);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(118, 20);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(60, 129);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(118, 20);
            this.textBox3.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(57, 158);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // lTitle
            // 
            this.lTitle.AutoSize = true;
            this.lTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTitle.Location = new System.Drawing.Point(6, 106);
            this.lTitle.Name = "lTitle";
            this.lTitle.Size = new System.Drawing.Size(36, 13);
            this.lTitle.TabIndex = 7;
            this.lTitle.Text = "Title:";
            // 
            // lAuthor
            // 
            this.lAuthor.AutoSize = true;
            this.lAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lAuthor.Location = new System.Drawing.Point(6, 132);
            this.lAuthor.Name = "lAuthor";
            this.lAuthor.Size = new System.Drawing.Size(48, 13);
            this.lAuthor.TabIndex = 8;
            this.lAuthor.Text = "Author:";
            // 
            // lGenre
            // 
            this.lGenre.AutoSize = true;
            this.lGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lGenre.Location = new System.Drawing.Point(6, 158);
            this.lGenre.Name = "lGenre";
            this.lGenre.Size = new System.Drawing.Size(45, 13);
            this.lGenre.TabIndex = 9;
            this.lGenre.Text = "Genre:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(7, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(7, 50);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(186, 116);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(104, 19);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(157, 21);
            this.comboBox2.TabIndex = 4;
            // 
            // lAlreadyLended
            // 
            this.lAlreadyLended.AutoSize = true;
            this.lAlreadyLended.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lAlreadyLended.Location = new System.Drawing.Point(19, 91);
            this.lAlreadyLended.Name = "lAlreadyLended";
            this.lAlreadyLended.Size = new System.Drawing.Size(148, 13);
            this.lAlreadyLended.TabIndex = 5;
            this.lAlreadyLended.Text = "The book is not avalible!";
            // 
            // lBookQue
            // 
            this.lBookQue.AutoSize = true;
            this.lBookQue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBookQue.Location = new System.Drawing.Point(6, 104);
            this.lBookQue.Name = "lBookQue";
            this.lBookQue.Size = new System.Drawing.Size(181, 13);
            this.lBookQue.TabIndex = 6;
            this.lBookQue.Text = "Would you like to get in queue";
            // 
            // Library
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 457);
            this.Controls.Add(this.listViewSearch);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ListView listViewSearch;
        private System.Windows.Forms.Label lGenre;
        private System.Windows.Forms.Label lAuthor;
        private System.Windows.Forms.Label lTitle;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ComboBox comboBoxDelete;
        private System.Windows.Forms.Label lBookQue;
        private System.Windows.Forms.Label lAlreadyLended;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}