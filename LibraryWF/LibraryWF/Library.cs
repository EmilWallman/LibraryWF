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
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }

    public class LibraryLogic
    {
        private string file;
        public List<User> users;

        public LibraryLogic(string file)
        {
            LoadUsers();
            this.file = file;
        }

        public LibraryLogic()
        {
            LoadUsers();
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
