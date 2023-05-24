using librarywf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

//Add a exit button from all forms

namespace LibraryWF
{
    public partial class Menu : Form
    {
        private MenuLogic menuLogic;

        //Send over the current ssn from login
        private CurrentUser currentUser;

        public Menu(CurrentUser user)
        {
            InitializeComponent();
            menuLogic = new MenuLogic("users.txt");
            currentUser = user;
        }

        //gets the current users ssn from login form ***?***
        public void logic ()
        {
            
        }

        private void Menu_Load_1(object sender, EventArgs e)
        {

        }

        private void SubmitEditUser (object sender, EventArgs e)
        {
            string user = "";
            string whatToEdit = "";
            string input = textBoxInput.Text;
            bool ok = true;

            if(checkAnotherUser.Checked == true)
            {
                user = comboBoxSUser.Text;
            }
            if(checkAnotherUser.Checked == false)
            {
                user = currentUser.ssn;
            }
            

            if (checkBoxUsername.Checked == true)
            {
                whatToEdit = "username";
            }
            if (checkBoxPassword.Checked == true)
            {
                whatToEdit = "password";
            }
            if (checkBoxSSN.Checked == true)
            {
                whatToEdit = "ssn";
            }

            
            
            if(whatToEdit == "")
            {
                ok = false;
            }

            if (ok == true)
            {
                menuLogic.editUser(user, whatToEdit, input);
            }
            

        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            //Creates an instance for MenuLogic
            menuLogic = new MenuLogic();
            
            //Checks if the current user is Admin
            bool isAdmin = menuLogic.isAdmin(currentUser.ssn);

             
            if (isAdmin == true)
            {
                boxEditUser.Visible = true;
                checkAnotherUser.Visible = true;
                if (checkAnotherUser.Checked == true)
                {
                    //Get a list with all usernames and adds them to the comboBox
                    List<string> usernames = menuLogic.Usernames();
                    foreach(string name in usernames)
                    {
                        comboBoxSUser.Items.Add(name);
                    }

                    Label3.Visible = true;
                    comboBoxSUser.Visible = true;
                }
                
            }
            if (isAdmin == false)
            {
                boxEditUser.Visible = true;
            }
            

        }
        

        private void userEditChoice1_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkBoxPassword.Checked = false;
            checkBoxSSN.Checked = false;
            
        }
        private void userEditChoice2_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkBoxSSN.Checked = false;
            checkBoxUsername.Checked = false;
            
        }
        private void userEditChoice3_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkBoxPassword.Checked = false;
            checkBoxUsername.Checked = false;
        }

        //Exit
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //LogOut
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        //Go to library
        private void btnLibrary_Click(object sender, EventArgs e)
        {
            Library library = new Library(currentUser);
            LibraryLogic libraryLogic = new LibraryLogic();
            string userSsn = currentUser.ssn;
            

            this.Hide();
            library.Show();

        }
    }

    public class MenuLogic
    {
        //Prob dont need 
        //public string userSSN { get; set; }


        private string file;
        public List<User> users;
        //Maby dont have this
        //public User currentUser;

        public MenuLogic(string file)
        {
            LoadUsers();
            this.file = file;
        }

        public MenuLogic()
        {
            LoadUsers();
        }

        public void editUser(string selectedUser, string whatToEdit, string input)
        {
            LoadUsers();

            foreach(User user in users)
            {
                if(user.ssn == selectedUser)
                {
                    switch(whatToEdit)
                    {
                        case "username":
                            user.username = input;
                            SaveUsers();
                            MessageBox.Show("Username has been changed");
                            break;
                        case "password":
                            user.password = input;
                            SaveUsers();
                            MessageBox.Show("Password has been changed");
                            break;
                        case "ssn":
                            user.ssn = input;
                            SaveUsers();
                            MessageBox.Show("Social security number has been changed");
                            break;
                    }
                    break;
                }
            }

        }


        public bool isAdmin(string currentUser)
        {
            LoadUsers();
            foreach (User user in users)
            {
                //userSSN does not work
                if(user.isAdmin == true && user.ssn == currentUser)
                {
                    return true;
                }
                if(user.isAdmin == false && user.ssn == currentUser)
                {
                    return false;
                }
            }
            return false;
        }

        public List<string> Usernames() 
        { 
            List<string> usernames = new List<string> ();
            foreach(User user in users)
            {
                usernames.Add(user.username);
            }
            return usernames;
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

        

        public void Menu1(string currentUser)
        {

        }

        
    }
}
