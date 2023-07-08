using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using MySql.Data.MySqlClient;
using System.Globalization;

namespace AlecFletcherC969
{
    public partial class LoginForm : Form
    {
        string culture = CultureInfo.CurrentCulture.EnglishName;
        public static string user;
        public static int userId;
        public static bool successfulLogin = false;
        
        public LoginForm()
        {
            InitializeComponent();
        }

        //Checks through each entry in UserList and confirms that both username and password match, returning true if there is a match, and false if no match is found
        public static bool CheckLogin(string username, string password)
        {
            if (DBTables.UserList.Count == 0)
            {
                DBTables.PopulateUsersTable();
            }
            foreach (var entry in DBTables.UserList)
            {
                if (entry.username == username && entry.password == password)
                {
                    user = entry.username;
                    userId = entry.userId;
                    return true;
                }
            }
            return false;
        }

        private void connect_Button_Click(object sender, EventArgs e)
        {
            if(CheckLogin(username_TextBox.Text, password_TextBox.Text))
            {
                successfulLogin = true;
                Close();
            }
            else
            {
                if (culture.Contains("Norwegian"))
                {
                    MessageBox.Show("Brukernavn eller passord er feil.");
                }
                MessageBox.Show("Username or password is incorrect.");
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            if (culture.Contains("Norwegian"))
            {
                this.Text = "Innloggingsskjema";
                username_label.Text = "Brukernavn";
                password_label.Text = "Passord";
                login_button.Text = "Logg Inn";
            }
        }

    }
}
