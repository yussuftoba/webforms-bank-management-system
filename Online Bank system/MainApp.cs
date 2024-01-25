using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using user;

namespace Online_Bank_system
{
    public partial class MainApp : Form
    {
        private string imagesFolderPath = Path.Combine(Application.StartupPath, "Pictures");   //the path for all the images
        private Button currentButton;
        private Form activeForm;
        public string username;
        
        public MainApp(string n)
        {
            InitializeComponent();
            set_label_Name(n);
            username = n;
            this.Size = new Size(989, 564);
        }

        private void MainApp_Load(object sender, EventArgs e)
        {
            AddcardBtn.Hide();
        }

        public void set_label_Name(string n)
        {
            titlelbl.Text = "Hello, " + n;
        }

        private void logOutbtn_Click(object sender, EventArgs e)
        {
            //maybe will be changed later
            this.Close();
        }

        private void dashBoardbtn_Click(object sender, EventArgs e)
        {
            
            string secondImagePath = Path.Combine(imagesFolderPath, "dashboardhl.png");
            Image secondImg = Image.FromFile(secondImagePath);

            cardbtn.BackColor = ColorTranslator.FromHtml("#ffffff");
            Transbtn.BackColor = ColorTranslator.FromHtml("#ffffff");

            //return other images to normal
            string cardimagePath = Path.Combine(imagesFolderPath, "creditcard.png");
            string transimagePath = Path.Combine(imagesFolderPath, "moneytransfer.png");

            Image ncardImage = Image.FromFile(cardimagePath);
            Image ntransImage = Image.FromFile(transimagePath);

            cardbtn.Image = ncardImage;
            Transbtn.Image = ntransImage;

            cardbtn.ForeColor = ColorTranslator.FromHtml("#000000");
            Transbtn.ForeColor = ColorTranslator.FromHtml("#000000");

            openChildForm(new Forms.dash(), sender);
            AddcardBtn.Hide();

        }

        private void cardbtn_Click(object sender, EventArgs e)
        {
            string secondImagePath = Path.Combine(imagesFolderPath, "creditcardhl.png");
            Image secondImg = Image.FromFile(secondImagePath);

            cardbtn.BackColor = ColorTranslator.FromHtml("#5e36f5");
            cardbtn.ForeColor = ColorTranslator.FromHtml("#ffffff");
            cardbtn.Image = secondImg;

            Transbtn.BackColor = ColorTranslator.FromHtml("#ffffff");

            //return other images to normal
            string dashimagePath = Path.Combine(imagesFolderPath, "dashboard.png");
            string transimagePath = Path.Combine(imagesFolderPath, "moneytransfer.png");

            Image ndashImage = Image.FromFile(dashimagePath);
            Image ntransImage = Image.FromFile(transimagePath);

            Transbtn.Image = ntransImage;

            Transbtn.ForeColor = ColorTranslator.FromHtml("#000000");

            openChildForm(new Forms.cards(username),sender);
            AddcardBtn.Show();

        }

        private void Transbtn_Click(object sender, EventArgs e)
        {
            string secondImagePath = Path.Combine(imagesFolderPath, "moneytransferhl.png");
            Image secondImg = Image.FromFile(secondImagePath);

            Transbtn.BackColor = ColorTranslator.FromHtml("#5e36f5");
            Transbtn.ForeColor = ColorTranslator.FromHtml("#ffffff");
            Transbtn.Image = secondImg;

            cardbtn.BackColor = ColorTranslator.FromHtml("#ffffff");

            //return other images to normal
            string cardimagePath = Path.Combine(imagesFolderPath, "creditcard.png");

            Image ncardImage = Image.FromFile(cardimagePath);

            cardbtn.Image = ncardImage;

            cardbtn.ForeColor = ColorTranslator.FromHtml("#000000");

            openChildForm(new Forms.trans(username), sender);
            AddcardBtn.Hide();

        }

        private void activateButton(object btnSender)
        {
            if(btnSender != null)
            {
                if(currentButton != (Button) btnSender)
                {
                    currentButton = (Button) btnSender;
                }
            }
        }

        private void openChildForm(Form childForm, object btnSender)
        {
            if(activeForm != null)
            {
                activeForm.Close();
            }

            activateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
        
            childForm.Dock = DockStyle.Fill;
            this.formPnl.Controls.Add(childForm);
            this.formPnl.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            titlelbl.Text = currentButton.Text;
        }

        private void AddcardBtn_Click(object sender, EventArgs e)
        {
            Forms.CheckCard card = new Forms.CheckCard(username);
            card.Show();
        }

        private void formPnl_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}