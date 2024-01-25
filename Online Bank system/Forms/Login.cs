using Online_Bank_system.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using user;

// dear programer when i first wrote this code only allah and i know how it works
// but now only allah knows how

namespace Online_Bank_system.Forms
{
    public partial class Login : Form
    {
        string Path = "users.csv";
        string transactionPath = "Transaction.csv";
        public bool UserSuccessfullyAuthenticated { get; private set; }

        public string username;

        public Login()
        {
            InitializeComponent();

            signUppnl.Hide();

            // log in 
            usertxt.KeyPress += usertxt_KeyPress;
            passtxt.KeyPress += passtxt_KeyPress;


            suUsertxt.KeyPress += suUsertxt_KeyPress;
            suPasstxt.KeyPress += suPasstxt_KeyPress;

            //log in
            usertxt.Text = "User Name";
            usertxt.ForeColor = Color.Gray;

            passtxt.Text = "Password";
            passtxt.ForeColor = Color.Gray;

            //signup panal
            suUsertxt.Text = "User Name";
            suUsertxt.ForeColor = Color.Gray;

            suPasstxt.Text = "Password";
            suPasstxt.ForeColor = Color.Gray;


            pictureBox6.MouseHover += leave;
        }

        //search users when logging in
        private bool search_user(User u)
        {
            StreamReader reader = new StreamReader(File.OpenRead(Path));

            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                string[] values = line.Split(',');
                if (u.Name.ToLower() == values[0].ToLower())
                {
                    reader.Close();
                    return true;
                }
            }

            reader.Close();
            return false;
        }

        private void add_transaction_csv(string username)
        {
            using (StreamWriter writer = new StreamWriter(transactionPath, true))
            {
                
                writer.WriteLine(username + "," + "" +"," + "" + "," + "");
                writer.WriteLine(username + "history" + "," + "" + "," + "" + "," + "" + "," + "");
            }
        }

        // search for username when signing up
        private bool search_user2(User u)
        {
            StreamReader reader = new StreamReader(File.OpenRead(Path));

            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                string[] values = line.Split(',');
                if (u.Name.ToLower() == values[0].ToLower() &&
                    u.Password.ToLower() == values[1].ToLower())
                {
                    reader.Close();
                    return true;
                }
            }

            reader.Close();
            return false;
        }

        //adding new user
        private int writeCsv(User us)
        {
            int usernameValidationResult = IsValidUsername(us.Name);
            if (usernameValidationResult == 1)
            {
                return 1;
            }

            int passwordValidationResult = IsValidPassword(us.Password);
            if (passwordValidationResult == 1)
            {
                return 1;
            }

            if (search_user(us))
            {
                resultlbl.ForeColor = Color.Red;
                resultlbl.Text = "This username already exists";
                return 1;
            }

            resultlbl.Text = "";

            using (StreamWriter writer = new StreamWriter(Path, true))
            {
                writer.WriteLine(us.Name + "," + us.Password + "," + "" + "," + "");
            }
            return 0;
        }

        //checking for the validity of name
        int IsValidUsername(string username)
        {
            User u = new User();
            u.Name = username;

            // Check if the username contains only valid characters
            if (!Regex.IsMatch(username, "^[a-zA-Z0-9_]+$"))
            {
                resultlbl.ForeColor = Color.Red;
                resultlbl.Text = "Username can only contain letters and numbers";
                return 1;
            }

            //checking for the length of username
            if (username.Length < 7 || username.Length > 20)
            {
                resultlbl.ForeColor = Color.Red;
                resultlbl.Text = "Username must be between 7 and 20 characters";
                return 1;
            }

            return 0;
        }

        // Password sign in 
        // Password sign in 
        int IsValidPassword(string password)
        {
            // check password length
            if (password.Length < 8)
            {
                resultlbl.ForeColor = Color.Red;
                resultlbl.Text = "Password must be at least 8 characters long";
                return 1;
            }

            // Check if the password contains both letters and numbers
            if (!Regex.IsMatch(password, "(?=.*[a-zA-Z])(?=.*[0-9])"))
            {
                resultlbl.ForeColor = Color.Red;
                resultlbl.Text = "Password must contain both letters and numbers";
                return 1;
            }

            return 0;
        }



        //everu thing is fine
        private void accept_user()
        {
            statelbl.Text = "Account created Successfuly";
            statelbl.ForeColor = Color.Green;
            signUppnl.Hide();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }

        //not used
        private void exitlbl_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Close();
        }

        private void signUplbl_Click(object sender, EventArgs e)
        {
            signUppnl.Show();
            statelbl.Text = "";
        }

        //signup button
        private void button1_Click(object sender, EventArgs e)
        {
            //this propubly should be done in the validation method
            if(suUsertxt.Text != "" &&  suPasstxt.Text != "")
            {
                if(File.Exists(Path))
                {
                    User u = new User();
                    u.Name = suUsertxt.Text;
                    u.Password = suPasstxt.Text;
                    if(writeCsv(u) == 0)
                    {
                        accept_user();
                        add_transaction_csv(u.Name);
                    }
                }
                else
                {
                    MessageBox.Show("File doesn't exist");
                }
            }
        }

        //logging into account
        private void loginbtn_Click(object sender, EventArgs e)
        {
            User u = new User();
            u.Name = usertxt.Text;
            u.Password = passtxt.Text;

            if (search_user2(u))
            {
                username = u.Name;
                this.Close();

                UserSuccessfullyAuthenticated = true;
            }
            else
            {
                statelbl.ForeColor = Color.Red;
                statelbl.Text = "The username or password is wrong";
                
            }
            
        }

        private void suPasstxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            signUppnl.Hide();
        }

        //all the following is for style
        private void usertxt_Click(object sender, EventArgs e)
        {
            ClearTextIfDefault(usertxt, "User Name");
        }

        private void passtxt_Click(object sender, EventArgs e)
        {
            ClearTextIfDefault(passtxt, "Password");
        }


        private void suUsertxt_Click(object sender, EventArgs e)
        {
            ClearTextIfDefault(suUsertxt, "User Name");
        }


        private void suPasstxt_Click(object sender, EventArgs e)
        {
            ClearTextIfDefault(suPasstxt, "Password");
        }
        private void ClearTextIfDefault(TextBox textBox, string defaultText)
        {
            if (textBox.Text == defaultText)
            {
                textBox.Text = "";
                textBox.Font = new Font("Microsoft Sans Serif", 11, FontStyle.Regular);
                textBox.ForeColor = Color.Black;
                if (textBox == passtxt || textBox == suPasstxt)
                {
                    textBox.PasswordChar = '*';
                }
            }
        }

        private void signUppnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void leave(object sender, EventArgs e)
        {
            this.pictureBox6.Image = global::Online_Bank_system.Properties.Resources.icons8_exit1;
        }
        private void usertxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                passtxt.Focus();
                e.Handled = true;
            }
        }

        private void passtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                // Call the login or signup method here
                loginbtn_Click(sender, e); 
                e.Handled = true; 
            }
        }
        private void suUsertxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                suPasstxt.Focus();
                e.Handled = true; 
            }
        }

        private void suPasstxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                // Call the signup method here
                button1_Click(sender, e); 
                e.Handled = true; 
            }
        }

    }
}
