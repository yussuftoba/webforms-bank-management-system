using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using user;
using System.Threading;
using Online_Bank_system.Forms.Classes;

namespace Online_Bank_system.Forms
{
    // a lot of code here is repeated and i don't have time for cleaning and optimizing
    // and you too can't change because you will most likley get an error  
    public partial class cards : Form
    {
        public string username;
        string fPath = "users.csv";
        string transactionPath = "Transaction.csv";

        bool canSlide = true;
        public cards(string n)
        {
            InitializeComponent();

            username = n;

            this.FormBorderStyle = FormBorderStyle.None;

            creditLbl.Parent = creditPic;
            creditLbl.BackColor = Color.Transparent;

            BalancdLbl.Parent = creditPic;
            BalancdLbl.BackColor = Color.Transparent;

            masterPic.Parent = creditPic;
            masterPic.BackColor = Color.Transparent;

            picPnl.BringToFront();
        }
        private void cards_Load(object sender, EventArgs e)
        {
            creditLbl.Text = string.Empty;
            print_credit_num();
            print_credit_balance();
        }
        private void print_credit_num()
        {
            using (StreamReader reader = new StreamReader(File.OpenRead(fPath)))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] values = line.Split(',');

                    if (values[0] == username)
                    {
                        creditLbl.Text = values[2];
                    }
                }
            }
        }

        private void print_credit_balance()
        {
            using (StreamReader reader = new StreamReader(File.OpenRead(fPath)))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] values = line.Split(',');

                    if (values[0] == username)
                    {
                        BalancdLbl.Text = values[3] + " USD";
                    }
                }
            }
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            int minSize = 806;
            int maxSize = 507;

            if (canSlide)
            {
                for (int i = minSize; i >= maxSize; i -= 4)
                {
                    sendPnl.Location = new Point(i, 2);
                }
                canSlide = false;
            }
            else
            {
                for (int i = maxSize; i < minSize; i += 4)
                {
                    sendPnl.Location = new Point(i, 2);
                }
                canSlide = true;
            }
        }
        private bool search_destined_user(string creditNum)
        {
            using (StreamReader reader = new StreamReader(File.OpenRead(fPath)))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] values = line.Split(',');

                    if (values[2].Trim() == creditNum.Trim())
                    {
                        reader.Close();
                        return true;
                    }
                }
                reader.Close();
            }

            return false;
        }


        // search for user again and update his balance 
        private void update_csv(string creditNum, double balance)
        {
            string tempFilePath = Path.GetTempFileName();
            double newBalance;

            //search again for the credit num and update the balance
            using (StreamReader reader = new StreamReader(File.OpenRead(fPath)))
            using (StreamWriter writer = new StreamWriter(tempFilePath, true))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] values = line.Split(',');

                    if (values[2].Trim() == creditNum.Trim())
                    {

                        newBalance = double.Parse(values[3]) + balance;
                        values[3] = newBalance.ToString();
                        line = string.Join(",", values);
                    }

                    writer.WriteLine(line);
                }
            }


            File.Copy(tempFilePath, fPath, true);
            File.Delete(tempFilePath);
        }

        // update the currunt user balance
        private void update_currunt_user(double balance)
        {
            string tempFilePath = Path.GetTempFileName();
            double newBalance;

            using (StreamReader reader = new StreamReader(File.OpenRead(fPath)))
            using (StreamWriter writer = new StreamWriter(tempFilePath, true))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] values = line.Split(',');

                    if (username.ToLower() == values[0].ToLower())
                    {
                        newBalance = double.Parse(values[3]) - balance;
                        values[3] = newBalance.ToString();
                        line = string.Join(",", values);
                    }

                    writer.WriteLine(line);
                }
            }


            File.Copy(tempFilePath, fPath, true);
            File.Delete(tempFilePath);
        }

        private double get_ibalance()
        {
            using (StreamReader reader = new StreamReader(File.OpenRead(fPath)))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] value = line.Split(',');
                    if (value[0].ToLower() == username.ToLower())
                    {
                        reader.Close();
                        return double.Parse(value[3]);
                    }
                }
                reader.Close();
            }
            return 0;

        }

        private void sendMoneyBtn_Click(object sender, EventArgs e)
        {
            string creditNum = destinationUserTxt.Text;
            double balanceSend = double.Parse(moneytxt.Text);
            double ibalance = get_ibalance();
            if (ibalance != 0)
            {
                if (balanceSend > ibalance)
                {
                    statuLbl.ForeColor = Color.Red;
                    statuLbl.Text = "Invalid amount of money";
                    return;
                }
            }
            else
            {
                statuLbl.ForeColor = Color.Red;
                statuLbl.Text = "You have no money to send";
            }

            if (search_destined_user(creditNum))
            {
                update_csv(creditNum, balanceSend);
                update_currunt_user(balanceSend);
                saveTransaction(balanceSend);
                update_History();                
                save_Transaction_recieved_user(creditNum, balanceSend);
                update_recieved_history(creditNum);

                statuLbl.ForeColor = Color.Green;
                statuLbl.Text = "Money have send successfully";
            }
            else
            {
                statuLbl.ForeColor = Color.Red;
                statuLbl.Text = "Couldn't find the user";
            }
        }

        //get the right index for transaction csv
        private int getIndex()
        {
            using (StreamReader reader = new StreamReader(File.OpenRead(transactionPath)))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] value = line.Split(',');
                    if (value[0] == username)
                    {
                        for (int i = 3; i < value.Length; i++)
                        {
                            if (value[i] == "")
                            {
                                reader.Close();
                                return i;
                            }
                        }
                    }
                }
                return -1;
            }
        }
        
        //save transaction for currunt user
        private void saveTransaction(double amount)
        {
            int index = getIndex();
            if (index == -1)
            {
                return;
            }
            string tempFilePath = Path.GetTempFileName();

            using (StreamReader reader = new StreamReader(File.OpenRead(transactionPath)))
            using (StreamWriter writer = new StreamWriter(tempFilePath, true))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] values = line.Split(',');

                    if (username.ToLower() == values[0].ToLower())
                    {
                        values[index] = "-" + amount.ToString();
                        line = string.Join(",", values);
                    }

                    writer.WriteLine(line);
                }
            }

            File.Copy(tempFilePath, transactionPath, true);
            File.Delete(tempFilePath);
        }

        //for currunt user history
        //this method could be useless but i will leav it anyway
        private int getIndexHistory()
        {
            using (StreamReader reader = new StreamReader(File.OpenRead(transactionPath)))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] value = line.Split(',');
                    if (value[0] == username + "history")
                    {
                        for (int i = 3; i < value.Length; i++)
                        {
                            if (value[i] == "")
                            {
                                reader.Close();
                                return i;
                            }
                        }
                    }
                }
                return -1;
            }
        }

        //update the time of the transaction for currunt user
        private void update_History()
        {
            int index = getIndexHistory();
            if (index == -1)
            {
                return;
            }
            string tempFilePath = Path.GetTempFileName();

            using (StreamReader reader = new StreamReader(File.OpenRead(transactionPath)))
            using (StreamWriter writer = new StreamWriter(tempFilePath, true))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] values = line.Split(',');

                    if (values[0] == (username + "history"))
                    {
                        values[index] = DateTime.Now.ToString();
                        line = string.Join(",", values);
                    }

                    writer.WriteLine(line);
                }
            }

            File.Copy(tempFilePath, transactionPath, true);
            File.Delete(tempFilePath);
        }

        //to get the index to add the new transaction for recieved user
        private int getReciedvedIndex(string creditCard)
        {
            StreamReader reader = new StreamReader(File.OpenRead(transactionPath));

            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                string[] value = line.Split(',');
                if (value[1] == creditCard)
                {
                    for (int i = 3; i < value.Length; i++)
                    {
                        if (value[i] == "")
                        {
                            reader.Close();
                            return i;
                        }
                    }
                }
            }
            reader.Close();
            return -1;
        }

        //save transation for recieved user
        private void save_Transaction_recieved_user(string creditCard, double amount)
        {
            int index = getReciedvedIndex(creditCard);
            if (index == -1)
            {
                return;
            }
            string tempFilePath = Path.GetTempFileName();

            using (StreamReader reader = new StreamReader(File.OpenRead(transactionPath)))
            using (StreamWriter writer = new StreamWriter(tempFilePath, true))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] values = line.Split(',');

                    if (values[1] == creditCard)
                    {
                        values[index] = "+" + amount;
                        line = string.Join(",", values);
                    }

                    writer.WriteLine(line);
                }
            }

            File.Copy(tempFilePath, transactionPath, true);
            File.Delete(tempFilePath);
        }

        private string get_recieved_name(string creditNum)
        {
            string name = "";
            StreamReader reader = new StreamReader(File.OpenRead(transactionPath));
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                string[] val = line.Split(',');
                if (val[1] == creditNum)
                {
                    name = val[0];
                    reader.Close();
                    break;
                }
            }
            reader.Close();
            return name;
        }
        private int getReciedvedHistoryIndex(string username)
        {
            StreamReader reader = new StreamReader(File.OpenRead(transactionPath));

            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                string[] value = line.Split(',');
                if (value[0] == username + "history")
                {
                    for (int i = 3; i < value.Length; i++)
                    {
                        if (value[i] == "")
                        {
                            reader.Close();
                            return i;
                        }
                    }
                }
            }
            reader.Close();
            return -1;
        }
        //update the time of the transaction for recieved user
        private void update_recieved_history(string creditCard)
        {
            string recievedName = get_recieved_name(creditCard);

            int index = getReciedvedHistoryIndex(recievedName);
            if (index == -1)
            {
                return;
            }
            string tempFilePath = Path.GetTempFileName();

            using (StreamReader reader = new StreamReader(File.OpenRead(transactionPath)))
            using (StreamWriter writer = new StreamWriter(tempFilePath, true))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] values = line.Split(',');

                    if (values[0] == (recievedName + "history"))
                    {
                        values[index] = DateTime.Now.ToString();
                        line = string.Join(",", values);
                    }

                    writer.WriteLine(line);
                }
            }

            File.Copy(tempFilePath, transactionPath, true);
            File.Delete(tempFilePath);

        }
        private void refreshBtn_Click(object sender, EventArgs e)
        {
            this.cards_Load(sender, e);
        }
    }
}
