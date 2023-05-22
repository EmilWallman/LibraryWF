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

namespace LibraryWF
{
    public partial class Library : Form
    {
        private LibraryLogic libraryLogic;
        private CurrentUser currentUser;

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

        }


        //Entering all Books into the comboBox
        private void btnLendBook_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            groupBoxAddBook.Visible = true;
            btnSubmit.Visible = true;

        }

        private void btnEditBooks_Click(object sender, EventArgs e)
        {
            gBoxEditBook.Visible = true;

        }

        private void lAddOk_Click(object sender, EventArgs e)
        {

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
            LoadUsers();
            LoadBooks();
            LoadCopies();
            LoadGenre();
            this.file = file;
        }

        public LibraryLogic()
        {
            LoadUsers();
            LoadBooks();
            LoadCopies();
            LoadGenre();
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
