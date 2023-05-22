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
            this.lAddOk = new System.Windows.Forms.Label();
            this.groupBoxAddBook = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lGenre = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lAuthor = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lTitle = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.comboBoxDelete = new System.Windows.Forms.ComboBox();
            this.btnDeleteBook = new System.Windows.Forms.Button();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.gBoxManageBook = new System.Windows.Forms.GroupBox();
            this.groupBoxNotAvalible = new System.Windows.Forms.GroupBox();
            this.lAlreadyLended = new System.Windows.Forms.Label();
            this.lBookQue = new System.Windows.Forms.Label();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnNo = new System.Windows.Forms.Button();
            this.comboBoxBooks = new System.Windows.Forms.ComboBox();
            this.btnYes = new System.Windows.Forms.Button();
            this.btnReturnBook = new System.Windows.Forms.Button();
            this.btnLendBook = new System.Windows.Forms.Button();
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
            this.lErrorAdd = new System.Windows.Forms.Label();
            this.btnAddGenre = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.gBoxEditBook.SuspendLayout();
            this.groupBoxAddBook.SuspendLayout();
            this.gBoxManageBook.SuspendLayout();
            this.groupBoxNotAvalible.SuspendLayout();
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
            this.gBoxEditBook.Controls.Add(this.textBox4);
            this.gBoxEditBook.Controls.Add(this.btnAddGenre);
            this.gBoxEditBook.Controls.Add(this.lAddOk);
            this.gBoxEditBook.Controls.Add(this.groupBoxAddBook);
            this.gBoxEditBook.Controls.Add(this.btnSubmit);
            this.gBoxEditBook.Controls.Add(this.comboBoxDelete);
            this.gBoxEditBook.Controls.Add(this.btnDeleteBook);
            this.gBoxEditBook.Controls.Add(this.btnAddBook);
            this.gBoxEditBook.Location = new System.Drawing.Point(282, 238);
            this.gBoxEditBook.Name = "gBoxEditBook";
            this.gBoxEditBook.Size = new System.Drawing.Size(389, 194);
            this.gBoxEditBook.TabIndex = 1;
            this.gBoxEditBook.TabStop = false;
            this.gBoxEditBook.Text = "Edit Books";
            this.gBoxEditBook.Visible = false;
            // 
            // lAddOk
            // 
            this.lAddOk.AutoSize = true;
            this.lAddOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lAddOk.Location = new System.Drawing.Point(7, 153);
            this.lAddOk.Name = "lAddOk";
            this.lAddOk.Size = new System.Drawing.Size(135, 13);
            this.lAddOk.TabIndex = 12;
            this.lAddOk.Text = "Book has been added!";
            this.lAddOk.Visible = false;
            this.lAddOk.Click += new System.EventHandler(this.lAddOk_Click);
            // 
            // groupBoxAddBook
            // 
            this.groupBoxAddBook.Controls.Add(this.textBox3);
            this.groupBoxAddBook.Controls.Add(this.lGenre);
            this.groupBoxAddBook.Controls.Add(this.textBox2);
            this.groupBoxAddBook.Controls.Add(this.lAuthor);
            this.groupBoxAddBook.Controls.Add(this.comboBox1);
            this.groupBoxAddBook.Controls.Add(this.lTitle);
            this.groupBoxAddBook.Location = new System.Drawing.Point(146, 77);
            this.groupBoxAddBook.Name = "groupBoxAddBook";
            this.groupBoxAddBook.Size = new System.Drawing.Size(200, 100);
            this.groupBoxAddBook.TabIndex = 10;
            this.groupBoxAddBook.TabStop = false;
            this.groupBoxAddBook.Visible = false;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(56, 39);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(118, 20);
            this.textBox3.TabIndex = 5;
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
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(56, 13);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(118, 20);
            this.textBox2.TabIndex = 4;
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
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(53, 68);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 6;
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
            // 
            // comboBoxDelete
            // 
            this.comboBoxDelete.FormattingEnabled = true;
            this.comboBoxDelete.Location = new System.Drawing.Point(146, 20);
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
            this.gBoxManageBook.Controls.Add(this.groupBoxNotAvalible);
            this.gBoxManageBook.Controls.Add(this.btnSelect);
            this.gBoxManageBook.Controls.Add(this.btnNo);
            this.gBoxManageBook.Controls.Add(this.comboBoxBooks);
            this.gBoxManageBook.Controls.Add(this.btnYes);
            this.gBoxManageBook.Controls.Add(this.btnReturnBook);
            this.gBoxManageBook.Controls.Add(this.btnLendBook);
            this.gBoxManageBook.Location = new System.Drawing.Point(282, 24);
            this.gBoxManageBook.Name = "gBoxManageBook";
            this.gBoxManageBook.Size = new System.Drawing.Size(389, 208);
            this.gBoxManageBook.TabIndex = 2;
            this.gBoxManageBook.TabStop = false;
            this.gBoxManageBook.Text = "Manage Books";
            this.gBoxManageBook.Visible = false;
            // 
            // groupBoxNotAvalible
            // 
            this.groupBoxNotAvalible.Controls.Add(this.lAlreadyLended);
            this.groupBoxNotAvalible.Controls.Add(this.lBookQue);
            this.groupBoxNotAvalible.Location = new System.Drawing.Point(0, 96);
            this.groupBoxNotAvalible.Name = "groupBoxNotAvalible";
            this.groupBoxNotAvalible.Size = new System.Drawing.Size(193, 60);
            this.groupBoxNotAvalible.TabIndex = 9;
            this.groupBoxNotAvalible.TabStop = false;
            this.groupBoxNotAvalible.Visible = false;
            // 
            // lAlreadyLended
            // 
            this.lAlreadyLended.AutoSize = true;
            this.lAlreadyLended.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lAlreadyLended.Location = new System.Drawing.Point(21, 17);
            this.lAlreadyLended.Name = "lAlreadyLended";
            this.lAlreadyLended.Size = new System.Drawing.Size(148, 13);
            this.lAlreadyLended.TabIndex = 5;
            this.lAlreadyLended.Text = "The book is not avalible!";
            // 
            // lBookQue
            // 
            this.lBookQue.AutoSize = true;
            this.lBookQue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBookQue.Location = new System.Drawing.Point(6, 33);
            this.lBookQue.Name = "lBookQue";
            this.lBookQue.Size = new System.Drawing.Size(181, 13);
            this.lBookQue.TabIndex = 6;
            this.lBookQue.Text = "Would you like to get in queue";
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(290, 20);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 8;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            // 
            // btnNo
            // 
            this.btnNo.Location = new System.Drawing.Point(199, 133);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(75, 23);
            this.btnNo.TabIndex = 7;
            this.btnNo.Text = "No";
            this.btnNo.UseVisualStyleBackColor = true;
            this.btnNo.Visible = false;
            // 
            // comboBoxBooks
            // 
            this.comboBoxBooks.FormattingEnabled = true;
            this.comboBoxBooks.Location = new System.Drawing.Point(127, 22);
            this.comboBoxBooks.Name = "comboBoxBooks";
            this.comboBoxBooks.Size = new System.Drawing.Size(157, 21);
            this.comboBoxBooks.TabIndex = 4;
            // 
            // btnYes
            // 
            this.btnYes.Location = new System.Drawing.Point(199, 103);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(75, 23);
            this.btnYes.TabIndex = 3;
            this.btnYes.Text = "Yes";
            this.btnYes.UseVisualStyleBackColor = true;
            this.btnYes.Visible = false;
            // 
            // btnReturnBook
            // 
            this.btnReturnBook.Location = new System.Drawing.Point(7, 50);
            this.btnReturnBook.Name = "btnReturnBook";
            this.btnReturnBook.Size = new System.Drawing.Size(75, 23);
            this.btnReturnBook.TabIndex = 1;
            this.btnReturnBook.Text = "Return Book";
            this.btnReturnBook.UseVisualStyleBackColor = true;
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
            this.listViewListBooks.HideSelection = false;
            this.listViewListBooks.Location = new System.Drawing.Point(677, 12);
            this.listViewListBooks.Name = "listViewListBooks";
            this.listViewListBooks.Size = new System.Drawing.Size(231, 433);
            this.listViewListBooks.TabIndex = 4;
            this.listViewListBooks.UseCompatibleStateImageBehavior = false;
            this.listViewListBooks.Visible = false;
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
            this.btnExit.Location = new System.Drawing.Point(29, 502);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(29, 473);
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
            // lErrorAdd
            // 
            this.lErrorAdd.AutoSize = true;
            this.lErrorAdd.BackColor = System.Drawing.Color.Red;
            this.lErrorAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lErrorAdd.Location = new System.Drawing.Point(12, 361);
            this.lErrorAdd.Name = "lErrorAdd";
            this.lErrorAdd.Size = new System.Drawing.Size(246, 13);
            this.lErrorAdd.TabIndex = 11;
            this.lErrorAdd.Text = "ERROR somerthing went wrong! Try again";
            this.lErrorAdd.Visible = false;
            // 
            // btnAddGenre
            // 
            this.btnAddGenre.Location = new System.Drawing.Point(6, 77);
            this.btnAddGenre.Name = "btnAddGenre";
            this.btnAddGenre.Size = new System.Drawing.Size(75, 23);
            this.btnAddGenre.TabIndex = 13;
            this.btnAddGenre.Text = "Add Genre";
            this.btnAddGenre.UseVisualStyleBackColor = true;
            this.btnAddGenre.Visible = false;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(146, 51);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(157, 20);
            this.textBox4.TabIndex = 14;
            // 
            // Library
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 551);
            this.Controls.Add(this.listViewSearch);
            this.Controls.Add(this.lErrorAdd);
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
            this.groupBoxAddBook.ResumeLayout(false);
            this.groupBoxAddBook.PerformLayout();
            this.gBoxManageBook.ResumeLayout(false);
            this.groupBoxNotAvalible.ResumeLayout(false);
            this.groupBoxNotAvalible.PerformLayout();
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
        private System.Windows.Forms.ComboBox comboBoxBooks;
        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.Button btnReturnBook;
        private System.Windows.Forms.Button btnLendBook;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnNo;
        private System.Windows.Forms.GroupBox groupBoxNotAvalible;
        private System.Windows.Forms.GroupBox groupBoxAddBook;
        private System.Windows.Forms.Label lAddOk;
        private System.Windows.Forms.Label lErrorAdd;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button btnAddGenre;
    }
}