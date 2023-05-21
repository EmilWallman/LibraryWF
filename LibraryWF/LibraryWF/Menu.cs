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

        //gets the current users ssn from login form
        public void logic ()
        {
            
        }

        private void Menu_Load_1(object sender, EventArgs e)
        {

        }

        private void SubmitEditUser (object sender, EventArgs e)
        {
            
            switch (userEditChoice)
            {
                case :
                    break;
                default:
                    break;
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

            }
            

        }
        //Only one alternative can be selected
        private void userEditChoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            int iSelectedIndex = userEditChoice.SelectedIndex;
            if (iSelectedIndex == -1)
                return;
            for (int iIndex = 0; iIndex < userEditChoice.Items.Count; iIndex++)
                userEditChoice.SetItemCheckState(iIndex, CheckState.Unchecked);
            userEditChoice.SetItemCheckState(iSelectedIndex, CheckState.Checked);
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
