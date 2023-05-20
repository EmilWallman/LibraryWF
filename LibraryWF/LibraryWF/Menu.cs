﻿using librarywf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryWF
{
    public partial class Menu : Form
    {
        private MenuLogic menuLogic;

        public Menu()
        {
            InitializeComponent();
            menuLogic = new MenuLogic("users.txt");
        }

        //gets the current users ssn from login form
        public void logic ()
        {
            
        }

        private void Menu_Load_1(object sender, EventArgs e)
        {

        }
        //Does not work for some reason 
        //The userSSN is not sent over from login
        private void btnEditUser_Click(object sender, EventArgs e)
        {
            //Creates an instance for MenuLogic
            menuLogic = new MenuLogic();
            
            //Checks if the current user is Admin
            bool isAdmin = menuLogic.isAdmin();

             
            if (isAdmin == true)
            {
                boxEditUser.Visible = true;
                checkAnotherUser.Visible = true;
                Label3.Visible = true;
                comboBoxSUser.Visible = true;
            }
            if (isAdmin == false)
            {

            }
            

        }
    }

    public class MenuLogic
    {
        public string userSSN { get; set; }


        private string file;
        public List<User> users;
        public User currentUser;

        public MenuLogic(string file)
        {
            LoadUsers();
            this.file = file;
        }

        public MenuLogic()
        {
            LoadUsers();
        }

        public bool isAdmin()
        {
            LoadUsers();
            foreach (User user in users)
            {
                //userSSN does not work
                if(user.isAdmin == true && user.ssn == userSSN)
                {
                    return true;
                }
                if(user.isAdmin == false && user.ssn == userSSN)
                {
                    return false;
                }
            }
            return false;
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
