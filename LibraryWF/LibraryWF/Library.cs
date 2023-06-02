using librarywf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using System.Net;
using System.Management.Automation.Language;
using System.Diagnostics;

namespace LibraryWF
{
    public partial class Library : Form
    {
        private LibraryLogic libraryLogic;
        private CurrentUser currentUser;

        private enum LibraryOperation { LendBook, ReturnBook }
        private LibraryOperation currentOperation;
        private enum LibraryYesNo { Yes, No}
        private LibraryYesNo libraryYesNo;


        public Library(CurrentUser user)
        {

            InitializeComponent();
            libraryLogic = new LibraryLogic("users.txt");
            currentUser = user;
            btnEditBooks.Visible = false;
            bool isAdmin = libraryLogic.IsAdmin(currentUser.ssn);

            if(isAdmin == true)
            {
                btnEditBooks.Visible = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnManageBooks_Click(object sender, EventArgs e)
        {
            gBoxManageBook.Visible = true;
            gBoxEditBook.Visible = false;
        }

        private void btnLendBook_Click(object sender, EventArgs e)
        {
            currentOperation = LibraryOperation.LendBook;

            comboBoxBooks.Visible = true;
            btnSelect.Visible = true;

            comboBoxBooks.Items.Clear();

            List<string> booksList = libraryLogic.ListAllBooks("title");

            for (int i = 0; i < booksList.Count; i++)
            {
                comboBoxBooks.Items.Add(booksList[i]);
            }
        }

        private void btnReturnBook_Click(Object sender, EventArgs e)
        {
            currentOperation = LibraryOperation.ReturnBook;
            comboBoxBooks.ResetText();

            comboBoxBooks.Visible = true;
            btnSelect.Visible = true;

            comboBoxBooks.Items.Clear();
            List<string> bookList = libraryLogic.UserBooks(currentUser.ssn);

            foreach (var book in bookList)
            {
                comboBoxBooks.Items.Add(book);
            }
        }


        private void LendAndReturn (object sender, EventArgs e)
        {
            comboBoxBooks.ResetText();
           
            
            //Lend Book
            if (currentOperation == LibraryOperation.LendBook)
            {
                string bookToLend = comboBoxBooks.SelectedItem.ToString();

                int LendBook = libraryLogic.LendBook(bookToLend, currentUser.ssn);

                switch (LendBook)
                {
                    case 1:
                        MessageBox.Show("The Book has been succesfully lended");
                        break;

                    case 2:

                        DialogResult result = MessageBox.Show("Do you want to get in queue for the book?", "Queue Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


                        //Wants to get in queue
                        if (result == DialogResult.Yes)
                        {
                            bool answer = libraryLogic.Queue(bookToLend, currentUser.ssn);
                            
                            if (answer == true)
                            {
                                MessageBox.Show("You have been placed in line for the book");

                                comboBoxBooks.ResetText();
                                break;
                            }
                            else
                            {
                                MessageBox.Show("Something went wrong! Try Again!");
                                

                                comboBoxBooks.ResetText();
                                break;
                            }

                        }

                        //Does not want to get in queue
                        else if(result == DialogResult.No)
                        {
                            MessageBox.Show("Okay you have not been placed in line");
                            

                            comboBoxBooks.ResetText();
                            break;
                        }

                        else
                        {
                            //Error
                        }
                        


                        break;

                    case 3:
                        MessageBox.Show("Something went wrong! Try again!");
                        

                        comboBoxBooks.ResetText();

                        break;


                    default:
                        break;
                }
                lManageBookLabel.Visible = true;
            }

            //Returning Book
            else if(currentOperation == LibraryOperation.ReturnBook)
            {
                string BookToReturn = comboBoxBooks.Text;

                libraryLogic.ReturnBook(BookToReturn, currentUser.ssn);
                MessageBox.Show("Book has been returned");
                comboBoxBooks.ResetText();
            }
        }


        private void btnAddBook_Click(object sender, EventArgs e)
        {
            groupBoxAddBook.Visible = true;
            btnSubmit.Visible = true;
            tBoxGenre.Visible = false;
            comboBoxDelete.Visible = false;
            tBoxTitle.Clear();
            tBoxAuthor.Clear();
            comboBoxGenre.ResetText();
            

            List<string> list = libraryLogic.Genres();
            for (int i = 0; i < list.Count; i++)
            {
                comboBoxGenre.Items.Add(list[i]);
            }
        }

        private void btnAddGenre_Click(object sender, EventArgs e)
        {
            tBoxGenre.Visible = true;
            btnSubmit.Visible = true;
            groupBoxAddBook.Visible = false;
            comboBoxDelete.Visible = false;
            comboBoxGenre.ResetText();
            comboBoxGenre.Items.Clear();

            
        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            comboBoxDelete.Visible = true;
            btnSubmit.Visible = true;
            tBoxGenre.Visible = false;
            groupBoxAddBook.Visible = false;
            comboBoxDelete.Items.Clear();
            comboBoxDelete.ResetText();

            List<string> books = libraryLogic.ListAllBooks("title");
            for (int i = 0; i < books.Count; i++)
            {
                comboBoxDelete.Items.Add(books[i]);
            }
        }

        private void EditBooks(object sender, EventArgs e)
        {


            //Add book
            if (groupBoxAddBook.Visible == true)
            {
                string Title = tBoxTitle.Text;
                string Author = tBoxAuthor.Text;
                string Genre = comboBoxGenre.Text;

                //Cheks for errors with input
                bool a = string.IsNullOrWhiteSpace(Title);
                bool b = string.IsNullOrWhiteSpace(Author);
                bool c = string.IsNullOrWhiteSpace(Genre);

                if (a == false && b == false && c == false)
                {
                    libraryLogic.AddBook(Title, Author, Genre);
                    MessageBox.Show("Book has been added!");
                }
                else
                {
                    MessageBox.Show("Something went wrong! Try Again");
                }
            }

            //Delete book
            if (comboBoxDelete.Visible == true)
            {
                
                if(string.IsNullOrWhiteSpace(comboBoxDelete.Text) == false)
                {
                    libraryLogic.DeleteBook(comboBoxDelete.Text);
                    MessageBox.Show("Book has been deleted!");
                    comboBoxDelete.ResetText();
                }
                else
                {
                    MessageBox.Show("Something went wrong! Try Again");
                }
                

            }

            //Add genre
            if (tBoxGenre.Visible == true)
            {
                bool test = string.IsNullOrEmpty(tBoxGenre.Text);

                if(test == false)
                {
                    libraryLogic.GenreAdd(tBoxGenre.Text);
                    MessageBox.Show("Genre has been added");
                    tBoxGenre.Clear();
                }
                else
                {
                    MessageBox.Show("Something went wrong! Try Again");
                }
            }
        
        }

        private void btnEditBooks_Click(object sender, EventArgs e)
        {
            gBoxEditBook.Visible = true;
            gBoxManageBook.Visible = false;
        }

        private void lAddOk_Click(object sender, EventArgs e)
        {

        }

        //Exit
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Back to menu
        private void btnBack_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu(currentUser);
            menu.Show();
            this.Hide();
        }

        private void btnListAllBooks_Click(object sender, EventArgs e)
        {
            listViewListBooks.Items.Clear();
            listViewListBooks.Visible = true;
            
            List<string> titleList= libraryLogic.ListAllBooks("title");
            List<string> authorList = libraryLogic.ListAllBooks("author");
            List<string> genreList = libraryLogic.ListAllBooks("genre");

            for (int i = 0; i < titleList.Count; i++)
            {

                ListViewItem listItem = new ListViewItem(titleList[i]);

                // Create the sub-items and add them to the ListViewItem
                listItem.SubItems.Add(authorList[i]);
                listItem.SubItems.Add(genreList[i]);

                // Add the ListViewItem to the ListView control
                listViewListBooks.Items.Add(listItem);
            }


        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = tBoxSearch.Text;
            listViewListBooks.Items.Clear();
            listViewListBooks.Visible = true;

            List<Book> books = libraryLogic.Search(searchTerm);

            foreach(Book book in books)
            {
                ListViewItem listItem = new ListViewItem(book.title);

                // Create the sub-items and add them to the ListViewItem
                listItem.SubItems.Add(book.author);
                listItem.SubItems.Add(book.genre);

                // Add the ListViewItem to the ListView control
                listViewListBooks.Items.Add(listItem);

            }
        }
    }

    public class LibraryLogic
    {
        private string file;
        public List<User> users;
        public List<Book> books;
        public List<Copy> copies;
        public List<Queue> queues;
        public List<GenreSave> genres;

        public LibraryLogic(string file)
        {
            users = new List<User>();
            books = new List<Book>();
            copies = new List<Copy>();
            queues = new List<Queue>();
            genres = new List<GenreSave>();

            LoadUsers();
            LoadBooks();
            LoadCopies();
            LoadGenre();
            this.file = file;
        }

        public LibraryLogic()
        {
            users = new List<User>();
            books = new List<Book>();
            copies = new List<Copy>();
            queues = new List<Queue>();
            genres = new List<GenreSave>();

            LoadUsers();
            LoadBooks();
            LoadCopies();
            LoadGenre();
        }

        public List<Book> Search (string SearchTerm)
        {
            const int MAX_DISTANCE = 2; // Maximum Levenshtein distance for a match

            int isbn;
            bool isNumeric = int.TryParse(SearchTerm, out isbn);

            // Search for books that match the search term in the title, author, genre, or ISBN
            List<Book> matchingBooks = books.Where(b =>
                ((isNumeric && b.id == isbn) || (!isNumeric &&
                (b.title.ToLower().Contains(SearchTerm.ToLower()) ||
                b.author.ToLower().Contains(SearchTerm.ToLower()) ||
                b.genre.ToLower().Contains(SearchTerm.ToLower()))))
            ).ToList();

            // Search for close matches using Levenshtein distance
            foreach (Book book in books)
            {
                int titleDistance = ComputeLevenshteinDistance(book.title.ToLower(), SearchTerm.ToLower());
                int authorDistance = ComputeLevenshteinDistance(book.author.ToLower(), SearchTerm.ToLower());
                int genreDistance = ComputeLevenshteinDistance(book.genre.ToLower(), SearchTerm.ToLower());

                if ((titleDistance <= MAX_DISTANCE || authorDistance <= MAX_DISTANCE || genreDistance <= MAX_DISTANCE) && !matchingBooks.Contains(book))
                {
                    matchingBooks.Add(book);
                }
            }

            return matchingBooks;
        }

        private static int ComputeLevenshteinDistance(string s, string t)
        {
            int[,] d = new int[s.Length + 1, t.Length + 1];

            for (int i = 0; i <= s.Length; i++)
            {
                d[i, 0] = i;
            }

            for (int j = 0; j <= t.Length; j++)
            {
                d[0, j] = j;
            }

            for (int j = 1; j <= t.Length; j++)
            {
                for (int i = 1; i <= s.Length; i++)
                {
                    int substitutionCost = (s[i - 1] == t[j - 1]) ? 0 : 1;

                    d[i, j] = Math.Min(Math.Min(
                        d[i - 1, j] + 1,      // Deletion
                        d[i, j - 1] + 1),     // Insertion
                        d[i - 1, j - 1] + substitutionCost); // Substitution
                }
            }

            return d[s.Length, t.Length];
        }

        public void ReturnBook(string bookToReturn, string userSsn)
        {
            int ssnUser = Int32.Parse(userSsn);

            List<int> usersBooks = new List<int>();

            foreach (Copy copy in copies)
            {
                if (copy.ssn == ssnUser)
                {
                    usersBooks.Add(copy.id);
                }
            }

            int returnBook = -1;
            string answer = bookToReturn;

            foreach (Book book in books)
            {
                if (answer == book.title)
                {
                    for (int i = 0; i < usersBooks.Count; i++)
                    {
                        if (usersBooks[i] == book.id)
                        {
                            returnBook = book.id;
                        }
                    }
                }
            }

            int ssnNewUser = -1;
            foreach (Copy copy in copies)
            {
                if (copy.id == returnBook && copy.ssn == ssnUser)
                {

                    //If there is someone in the queue
                    if (File.Exists("queue_" + copy.id + ".txt"))
                    {
                        LoadQueue(copy.id);
                        foreach (Queue queue in queues)
                        {
                            if (queue.ISBN == copy.id)
                            {
                                ssnNewUser = queue.ssn;
                                Queue userToDelete = queues.Find(b => b.ssn == ssnNewUser);
                                if (userToDelete != null)
                                {
                                    queues.Remove(userToDelete);
                                    SaveQueue(copy.id);
                                }
                                copy.ssn = ssnNewUser;
                                SaveCopies();
                                break;
                            }
                        }
                    }

                    else
                    {
                        copy.ssn = -1;
                        SaveCopies();
                    }
                }
            }
        }

        public int LendBook(string bookToLend, string userSsn)
        {
            //Returns:
            //1 Book is lended
            //2 Book is not avalible
            //3 Error


            int userSSN = Int32.Parse(userSsn);
            int bookID = -1;

            //Getting the books id
            foreach(Book book in books)
            {
                if (book.title == bookToLend)
                {
                    bookID = book.id; 
                    break;
                }
            }

            //Getting the number of copies of the book 
            int numOfCopies = -1;
            foreach(Copy copy in copies)
            {
                if(copy.id == bookID)
                {
                    numOfCopies++;
                }
            }

            int check2 = -1;
            foreach (Copy copy in copies)
            {
                if (copy.id == bookID)
                {
                    check2++;

                    //If there is a book avalible
                    if (copy.ssn == -1)
                    {
                        copy.ssn = userSSN;
                        SaveCopies();
                        return 1;
                    }

                    //No books avalible
                    if (copy.ssn != -1 && check2 == numOfCopies)
                    {
                        return 2;
                    }
                }
            }

            //Something went wrong
            return 3;
        }

        public bool Queue (string bookToLend, string userSsn)
        {

            int userSSN = Int32.Parse(userSsn);
            int bookID = -1;
            
            //Getting the books id
            foreach (Book book in books)
            {
                if (book.title == bookToLend)
                {
                    bookID = book.id;
                    break;
                }
            }



            //Getting the number of copies of the book 
            int numOfCopies = -1;
            foreach (Copy copy in copies)
            {
                if (copy.id == bookID)
                {
                    numOfCopies++;
                }
            }

            
            int check = -1;
            foreach (Copy copy in copies)
            {
                if (copy.id == bookID)
                {
                    check++;

                    if (copy.ssn != -1 && check == numOfCopies)
                    {
                        if (File.Exists("queue_" + copy.id + ".txt"))
                        {
                            LoadQueue(copy.id);
                            Queue queue = new Queue(copy.id, userSSN);
                            queues.Add(queue);
                            SaveQueue(copy.id);
                            return true;
                        }
                        if (!File.Exists("queue_" + copy.id + ".txt"))
                        {
                            var myFile = File.Create("queue_" + bookID + ".txt");
                            myFile.Close();
                            LoadQueue(copy.id);
                            Queue queue = new Queue(copy.id, userSSN);
                            queues.Add(queue);

                            SaveQueue(copy.id);
                            return true;

                        }
                    }
                }
            }

            //Something went wrong
            return false;
        }

        public List<string> UserBooks(string userSsn)
        {
             
            List<int> list = new List<int>();
            List<string> bookTitles = new List<string>();

            foreach (Copy copy in copies)
            {
                if (copy.ssn == Convert.ToInt32(userSsn))
                {
                    list.Add(copy.id);
                }
            }

            foreach (Book book in books)
            {
                foreach(var bookID in list)
                {
                    if (bookID == book.id)
                    {
                        bookTitles.Add(book.title);
                    }
                }
            }

            return bookTitles;

            

        }

        public void GenreAdd(string genreName)
        {
            GenreSave genreSave = new GenreSave(genreName);
            genres.Add(genreSave);
            SaveGenres();
            
        }

        public List<string> Genres()
        {
            List<string> genreList = new List<string>();

            foreach(GenreSave genreSave in genres)
            {
                genreList.Add(genreSave.genre);
            }

            return genreList;
        }

        public void DeleteBook(string title)
        {
            int BookId = -1;
            int numOfCopies = 0;

            foreach (Book book in books)
            {
                if (book.title == title)
                {
                    BookId = book.id;

                    foreach (Copy copy in copies)
                    {
                        if (copy.id == book.id)
                        { 
                            numOfCopies++;
                        }
                    }
                }
            }

            foreach (Book book in books)
            {
                if(book.title == title)
                {
                    BookId = book.id;
                    books.Remove(book);
                    SaveBooks();
                    break;
                }
            }
            
            //This for loop makes it so that I can use break in the if loop
            for(int i = 0; i < numOfCopies; i++)
            {
                foreach (Copy copy in copies)
                {
                    if (copy.id == BookId)
                    {
                        copies.Remove(copy);
                        SaveCopies();
                        break;
                    }
                }
            }
            

        }

        public List<string> ListAllBooks(string titleAuthorGenre)
        {


            List<string> list = new List<string>();
            foreach(Book book in books)
            {
                switch (titleAuthorGenre)
                {
                    case "title":
                        list.Add(book.title);
                        break;
                    case "author":
                        list.Add(book.author);
                        break;
                    case "genre":
                        list.Add(book.genre);
                        break;
                }
            }
            return list;
        }

        public int AddBook(string Title, string Author, string Genre)
        {
            //Return:
            //1 Added book
            //2 Creating copy of existing book
            //3 Error
            int ssn = -1;

            //Makes it so that the next book gest a higher ID
            int id = 0;

            for (int i = 0; i < books.Count; i++)
            {
                id = books[i].id + 1;
            }
            int ISBN = 0;
            for (int i = 0; i < copies.Count; i++)
            {
                ISBN = copies[i].ISBN + 1;
            }
            int check = 0;

            foreach (Book book in books)
            {
                if (book.title == Title)
                {
                    
                    check = 1;
                    id = book.id;
                    if (check == 1)
                    {
                        Copy copy = new Copy(id, ISBN, ssn);
                        copies.Add(copy);
                        SaveCopies();
                    }
                    
                    return 2;
                }
            }

            if (check == 0)
            {
                Copy copy = new Copy(id, ISBN, ssn);
                Book book = new Book(id, Title, Author, Genre);
                books.Add(book);
                copies.Add(copy);
                SaveBooks();
                SaveCopies();
            }

            return 0;
        }

        public bool IsAdmin (string userSsn)
        {
            foreach(User user in users)
            {
                if(user.ssn == userSsn)
                {
                    if (user.isAdmin == true)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return false;
        }



        //All saving and loading methods
        public void LoadGenre()
        {
            if (!File.Exists("genre.txt"))
            {
                File.Create("genre.txt");
                return;
            }

            string[] lines = File.ReadAllLines("genre.txt");
            foreach (string line in lines)
            {
                string[] parts = line.Split(',');
                string genre = parts[0];

                GenreSave genreSave = new GenreSave(genre);
                genres.Add(genreSave);
            }
        }

        public void LoadBooks()
        {
            if (!File.Exists("books.txt"))
            {
                File.Create("books.txt");
                return;
            }

            string[] lines = File.ReadAllLines("books.txt");
            foreach (string line in lines)
            {
                string[] parts = line.Split(',');
                int ISBN = int.Parse(parts[0]);
                string title = parts[1];
                string author = parts[2];
                string genre = parts[3];

                Book book = new Book(ISBN, title, author, genre);
                books.Add(book);
            }
        }

        public void LoadQueue(int bookId)
        {

            if (!File.Exists("queue_" + bookId + ".txt"))
            {

                return;
            }
            queues.Clear();
            string[] lines = File.ReadAllLines("queue_" + bookId + ".txt");
            foreach (string line in lines)
            {
                string[] parts = line.Split(',');
                int ISBN = int.Parse(parts[0]);
                int ssn = int.Parse(parts[1]);

                Queue queue = new Queue(ISBN, ssn);
                queues.Add(queue);
            }
        }

        public void LoadCopies()
        {
            if (!File.Exists("copy.txt"))
            {
                File.Create("copy.txt");
                return;
            }

            string[] lines = File.ReadAllLines("copy.txt");
            foreach (string line in lines)
            {
                string[] parts = line.Split(',');
                int id = int.Parse(parts[0]);
                int ISBN = int.Parse(parts[1]);
                int ssn = int.Parse(parts[2]);

                Copy copy = new Copy(id, ISBN, ssn);
                copies.Add(copy);
            }

        }

        public void LoadUsers()
        {
            if (!File.Exists("users.txt"))
            {
                File.Create("users.txt");
            }

            string[] lines = File.ReadAllLines("users.txt");

            users = new List<User>();

            foreach (string line in lines)
            {
                string[] parts = line.Split(',');
                string username = parts[0];
                string password = parts[1];
                string ssn = parts[2];
                bool isAdmin = bool.Parse(parts[3]);

                User user = new User(username, password, ssn, isAdmin);
                users.Add(user);
            }
            SaveUsers();
        }

        public void SaveGenres()
        {
            List<string> lines = new List<string>();
            foreach (GenreSave genre in genres)
            {
                lines.Add(genre.genre);
            }
            File.WriteAllLines("genre.txt", lines);
        }

        public void SaveCopies()
        {
            List<string> lines = new List<string>();
            foreach (Copy copy in copies)
            {
                lines.Add(copy.id + "," + copy.ISBN + "," + copy.ssn);
            }
            File.WriteAllLines("copy.txt", lines);
        }

        public void SaveBooks()
        {
            List<string> lines = new List<string>();
            foreach (Book book in books)
            {
                lines.Add(book.id + "," + book.title + "," + book.author + "," + book.genre);
            }
            File.WriteAllLines("books.txt", lines);
        }

        public void SaveQueue(int ISBN)
        {

            List<string> lines = new List<string>();
            foreach (Queue queue in queues)
            {
                lines.Add(queue.ISBN + "," + queue.ssn);
            }
            File.WriteAllLines("queue_" + ISBN + ".txt", lines);
            if (queues.Count <= 0)
            {
                File.Delete("queue_" + ISBN + ".txt");
            }
        }

        private void SaveUsers()
        {

            List<string> lines = new List<string>();
            foreach (User user in users)
            {
                lines.Add(user.username + "," + user.password + "," + user.ssn + "," + user.isAdmin);
            }
            File.WriteAllLines("users.txt", lines);
        }
    }
}
