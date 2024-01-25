using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Online_Bank_system.Forms
{
    public partial class trans : Form
    {
        string transactionPath = "Transaction.csv";

        string username;
        string[] state;
        string[] amount;
        string[] date;
        public trans(string u)
        {
            InitializeComponent();

            stateBox.DrawMode = DrawMode.OwnerDrawFixed;
            stateBox.DrawItem += ListBox_DrawItem;

            amountBox.DrawMode = DrawMode.OwnerDrawFixed;
            amountBox.DrawItem += ListBox_DrawItem2;

            dateBox.DrawMode = DrawMode.OwnerDrawFixed;
            dateBox.DrawItem += ListBox_DrawItem3;

            username = u;
            stateBox.Items.Add("State");
            

            amountBox.Items.Add("Amount");
            

            dateBox.Items.Add("Date");
            
            get_data();
            display_transactions();
        }

        
        private void get_data()
        {
            using (StreamReader reader = new StreamReader(File.OpenRead(transactionPath)))
            {
                amount = new string[20];
                state = new string[20];
                date = new string[20];
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] value = line.Split(',');
                    if (value[0] == username)
                    {
                        int j = 0;
                        for (int i = 3; i < value.Length; i++)
                        {
                            if (value[i] == "") break;
                            if (value[i][0] == '-')
                            {
                                state[j] = "Send";
                            }
                            else
                            {
                                state[j] = "Reciaved";
                            }
                            amount[j] = value[i].Substring(1);
                            j++;
                        }
                    }

                    if (value[0] == username + "history")
                    {
                        int j = 0;
                        for (int i = 3; i < value.Length; i++)
                        {
                            if (value[i] == "") break;
                            date[j] = value[i];
                            j++;
                        }
                    }
                }
            }
            
        }

        // get the size of csv
        private int get_size()
        {
            int size = 0;
            while (true)
            {
                if (amount[size] == null || amount[size].Length == 0) break;

                size++;
            }
            return size;
        }

        private void display_transactions()
        {
            int size = get_size();
            for(int i = size - 1; i >= 0; i--)
            {
                if (amount[i] == null) break;
                stateBox.Items.Add(state[i]);
                amountBox.Items.Add(amount[i]);
                dateBox.Items.Add(date[i]);
            }
        }

        private void trans_Load(object sender, EventArgs e)
        {

        }

        private void ListBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            // Check if the item is the first item
            if (e.Index == 0)
            {
                // Change the color for the first item
                e.Graphics.FillRectangle(Brushes.LightBlue, e.Bounds);
                e.Graphics.DrawString(stateBox.Items[e.Index].ToString(), e.Font, Brushes.DarkBlue, e.Bounds, StringFormat.GenericDefault);
            }
            else
            {
                // Default rendering for other items
                e.DrawBackground();
                e.Graphics.DrawString(stateBox.Items[e.Index].ToString(), e.Font, Brushes.Black, e.Bounds, StringFormat.GenericDefault);
                e.DrawFocusRectangle();
            }
        }

        private void ListBox_DrawItem2(object sender, DrawItemEventArgs e)
        {
            // Check if the item is the first item
            if (e.Index == 0)
            {
                // Change the color for the first item
                e.Graphics.FillRectangle(Brushes.LightBlue, e.Bounds);
                e.Graphics.DrawString(amountBox.Items[e.Index].ToString(), e.Font, Brushes.DarkBlue, e.Bounds, StringFormat.GenericDefault);
            }
            else
            {
                // Default rendering for other items
                e.DrawBackground();
                e.Graphics.DrawString(amountBox.Items[e.Index].ToString(), e.Font, Brushes.Black, e.Bounds, StringFormat.GenericDefault);
                e.DrawFocusRectangle();
            }
        }

        private void ListBox_DrawItem3(object sender, DrawItemEventArgs e)
        {
            // Check if the item is the first item
            if (e.Index == 0)
            {
                // Change the color for the first item
                e.Graphics.FillRectangle(Brushes.LightBlue, e.Bounds);
                e.Graphics.DrawString(dateBox.Items[e.Index].ToString(), e.Font, Brushes.DarkBlue, e.Bounds, StringFormat.GenericDefault);
            }
            else
            {
                // Default rendering for other items
                e.DrawBackground();
                e.Graphics.DrawString(dateBox.Items[e.Index].ToString(), e.Font, Brushes.Black, e.Bounds, StringFormat.GenericDefault);
                e.DrawFocusRectangle();
            }
        }

    }
}
