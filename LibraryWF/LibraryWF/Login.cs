using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Threading;
using LibraryWF;
using librarywf;
using System.Web;

namespace LibraryWF
{
    public partial class Login : Form
    {
        private UserManeger userManeger;
        public CurrentUser currentUser = new CurrentUser();


        public Login()
        {
            InitializeComponent();
            userManeger = new UserManeger("users.txt");
        }


        //Shows the nessesarry inputs to loggin
        public void loggin_Click(object sender, EventArgs e)
        {
            
            tbUsername.Visible = true;
            tbPassword.Visible = true;
            tbSSN.Visible = false;
            lUsername.Visible = true;
            lPassword.Visible = true;
            lSSN.Visible = false;
            btnSubbmit.Visible = true;
            
        }

        //Shows the nessesarry inputs to create an account
        public void createAcc_Click(object sender, EventArgs e)
        {
            tbUsername.Visible = true;
            tbPassword.Visible = true;
            tbSSN.Visible = true;
            lUsername.Visible = true;
            lPassword.Visible = true;
            lSSN.Visible = true;
            btnSubbmit.Visible = true;
        }

        public void Submit_Click(object sender, EventArgs e)
        {
            lError.Visible = false;
            Menu menu = new Menu(currentUser);
            MenuLogic menuLogic = new MenuLogic();
            
            
            //Create account
            if (lSSN.Visible == true)
            {
                string username = tbUsername.Text;
                string password = tbPassword.Text;
                string ssn = tbSSN.Text;

                bool UserExists = userManeger.UserExists(username, password);

                if (UserExists == true)
                {
                    //type in error
                }
                else
                {
                    bool CreateAccount = userManeger.CreateAccount(username, password, ssn);

                    if (CreateAccount == true)
                    {

                        string UserSsn = userManeger.userSSN(username, password);
                        //menuLogic.userSSN = UserSsn;

                        currentUser.ssn = UserSsn;

                        menuLogic.Menu1(UserSsn);


                        this.Hide();
                        menu.Show();

                    }
                }

            }

            //Loggin in
            if (lSSN.Visible == false)
            {
                string username = tbUsername.Text;
                string password = tbPassword.Text;
                
                bool UserExists = userManeger.UserExists(username, password);

                if (UserExists == true)
                {
                    string UserSsn = userManeger.userSSN(username, password);
                    
                    //menuLogic.userSSN = UserSsn;
                    currentUser.ssn = UserSsn;

                    
                    this.Hide();
                    menu.Show();

                    
                }
                else
                {
                    tbPassword.Clear();
                    tbUsername.Clear();
                    lError.Visible = true;
                }

            }
        }
        
    }
    
    public class UserManeger
    {
        private string file;
        public List<User> users;
        public User currentUser;

        public UserManeger(string file)
        {
            LoadUsers();
            this.file = file;
        }

        public bool UserExists(string username, string password)
        {
            foreach(User user in users)
            {
                if (user.username == username && user.password == password)
                {
                    return true;
                }
            }
            return false;
        }
        public string userSSN(string username, string password)
        {
            foreach(User user in users)
            {
                if(user.username == username && user.password == password)
                {
                    return user.ssn;
                }
            }
            return "-1";
        }

        public bool CreateAccount(string username, string password, string ssn)
        {
            User user = new User(username, password, ssn, false);
            users.Add(user);
            SaveUsers();
            return true;

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
    /*
    public class Test
    {
        
        public List<User> users;
        public User currentUser;

        public Test()
        {
            users = new List<User>();
            LoadUsers();
        }

        public void login(string username, string password)
        {
            foreach (User user in users)
            {
                //Check if username and password is correct
                if (user.username == username && user.password == password)
                {
                    //You are logged in (go to the interface form
                    Menu menu = new Menu();
                    menu.Show();
                    
                }
            }
            Login login = new Login();
            login.Show();
        }

        public void LoadUsers()
        {
            if (!File.Exists("users.txt"))
            {
                File.Create("users.txt");
            }

            string[] lines = File.ReadAllLines("users.txt");
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
    }*/
}
