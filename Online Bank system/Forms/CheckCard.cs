using Online_Bank_system.Forms.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using user;
using System.IO;

namespace Online_Bank_system.Forms
{
    public partial class CheckCard : Form
    {
        string fPath = "users.csv";
        string transactionPath = "Transaction.csv";

        public string username;
        public CheckCard(string n)
        {
            InitializeComponent();
            username = n;
        }

        private void CheckCard_Load(object sender, EventArgs e)
        {
            try
            {
                creditNumtxt.Text = "0000000000000000";
                creditNumtxt.ForeColor = Color.Gray;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading the form: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Account a = new Account();
                a.creditCardNumber = creditNumtxt.Text;
                a.balance = double.Parse(balancetxt.Text);

                if (a.creditCardNumber.Length == 16)
                {
                    int result = a.sumEvenDigit(a.creditCardNumber) + a.sumOddDigit(a.creditCardNumber);

                    if (result % 10 == 0)
                    {
                        write_card_csv(a.creditCardNumber, a.balance);
                        write_Transaction_csv(a.creditCardNumber);
                        this.Hide();
                    }
                    else
                    {
                        msgLbl.Text = "Not valid card number";
                        msgLbl.ForeColor = Color.Red;
                    }
                }
                else
                {
                    msgLbl.Text = "Credit card number must contain 16 digits";
                    msgLbl.ForeColor = Color.Red;
                }
            }
            catch (FormatException)
            {
                msgLbl.Text = "Invalid balance format. Please enter a valid number.";
                msgLbl.ForeColor = Color.Red;
            }
            catch (Exception ex)
            {
                msgLbl.Text = $"An error occurred: {ex.Message}";
                msgLbl.ForeColor = Color.Red;
            }
        }
        private void creditNumtxt_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                creditNumtxt.Text = "";
                creditNumtxt.ForeColor = Color.Black;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred during double-click handling: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void write_Transaction_csv(string creditNum)
        {
            string tempFilePath = Path.GetTempFileName();
            string newCardValue = creditNum.Trim();

            using (StreamReader reader = new StreamReader(File.OpenRead(transactionPath)))
            using (StreamWriter writer = new StreamWriter(tempFilePath, true))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] values = line.Split(',');

                    if (username.ToLower() == values[0].ToLower())
                    {
                        values[1] = newCardValue;
                        line = string.Join(",", values);
                    }

                    writer.WriteLine(line);
                }
            }

            File.Copy(tempFilePath, transactionPath, true);
            File.Delete(tempFilePath);
        }


        private void write_card_csv(string creditNum, double balance)
        {
            try
            {
                string tempFilePath = Path.GetTempFileName();
                string newCardValue = creditNum.Trim();
                string newBalanceValue = balance.ToString();

                bool cardExists = false;
                bool cardAssociatedWithOtherUser = false;

                using (StreamReader reader = new StreamReader(File.OpenRead(fPath)))
                using (StreamWriter writer = new StreamWriter(tempFilePath, true))
                {
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        string[] values = line.Split(',');

                        if (username.ToLower() == values[0].ToLower())
                        {
                            // Check if the credit card already exists
                            if (values[2].Trim() == newCardValue)
                            {
                                cardExists = true;

                                // Check if the credit card is associated with another user
                                if (values[0].ToLower() != username.ToLower())
                                {
                                    cardAssociatedWithOtherUser = true;
                                    break;
                                }
                            }

                            values[2] = newCardValue;
                            values[3] = newBalanceValue;
                            line = string.Join(",", values);
                        }

                        writer.WriteLine(line);
                    }
                }

                if (cardExists)
                {
                    if (cardAssociatedWithOtherUser)
                    {
                        MessageBox.Show("The credit card is already associated with another user.", "Credit Card Associated Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Credit card already exists for the user.", "Duplicate Credit Card", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    return; // Do not proceed further
                }

                File.Copy(tempFilePath, fPath, true);
                File.Delete(tempFilePath);

                MessageBox.Show("Credit card information updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while writing to the user file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
