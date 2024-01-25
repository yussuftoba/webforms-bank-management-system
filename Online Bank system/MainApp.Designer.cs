namespace Online_Bank_system
{
    partial class MainApp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainApp));
            this.btnspnl = new System.Windows.Forms.Panel();
            this.logOutbtn = new System.Windows.Forms.Button();
            this.Transbtn = new System.Windows.Forms.Button();
            this.cardbtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AddcardBtn = new System.Windows.Forms.Button();
            this.titlelbl = new System.Windows.Forms.Label();
            this.formPnl = new System.Windows.Forms.Panel();
            this.btnspnl.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnspnl
            // 
            this.btnspnl.BackColor = System.Drawing.Color.Gainsboro;
            this.btnspnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnspnl.Controls.Add(this.logOutbtn);
            this.btnspnl.Controls.Add(this.Transbtn);
            this.btnspnl.Controls.Add(this.cardbtn);
            this.btnspnl.Controls.Add(this.panel2);
            this.btnspnl.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnspnl.Location = new System.Drawing.Point(0, 0);
            this.btnspnl.Name = "btnspnl";
            this.btnspnl.Size = new System.Drawing.Size(190, 529);
            this.btnspnl.TabIndex = 0;
            // 
            // logOutbtn
            // 
            this.logOutbtn.BackColor = System.Drawing.Color.Silver;
            this.logOutbtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.logOutbtn.FlatAppearance.BorderSize = 0;
            this.logOutbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logOutbtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutbtn.Image = ((System.Drawing.Image)(resources.GetObject("logOutbtn.Image")));
            this.logOutbtn.Location = new System.Drawing.Point(0, 482);
            this.logOutbtn.Name = "logOutbtn";
            this.logOutbtn.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.logOutbtn.Size = new System.Drawing.Size(188, 45);
            this.logOutbtn.TabIndex = 5;
            this.logOutbtn.Text = "   Log out";
            this.logOutbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.logOutbtn.UseVisualStyleBackColor = false;
            this.logOutbtn.Click += new System.EventHandler(this.logOutbtn_Click);
            // 
            // Transbtn
            // 
            this.Transbtn.BackColor = System.Drawing.Color.Silver;
            this.Transbtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Transbtn.FlatAppearance.BorderSize = 0;
            this.Transbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Transbtn.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Transbtn.Image = ((System.Drawing.Image)(resources.GetObject("Transbtn.Image")));
            this.Transbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Transbtn.Location = new System.Drawing.Point(0, 128);
            this.Transbtn.Name = "Transbtn";
            this.Transbtn.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.Transbtn.Size = new System.Drawing.Size(188, 45);
            this.Transbtn.TabIndex = 3;
            this.Transbtn.Text = "   Transactions";
            this.Transbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Transbtn.UseVisualStyleBackColor = false;
            this.Transbtn.Click += new System.EventHandler(this.Transbtn_Click);
            // 
            // cardbtn
            // 
            this.cardbtn.BackColor = System.Drawing.Color.Silver;
            this.cardbtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.cardbtn.FlatAppearance.BorderSize = 0;
            this.cardbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cardbtn.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardbtn.Image = ((System.Drawing.Image)(resources.GetObject("cardbtn.Image")));
            this.cardbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cardbtn.Location = new System.Drawing.Point(0, 83);
            this.cardbtn.Name = "cardbtn";
            this.cardbtn.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.cardbtn.Size = new System.Drawing.Size(188, 45);
            this.cardbtn.TabIndex = 2;
            this.cardbtn.Text = "   Cards";
            this.cardbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cardbtn.UseVisualStyleBackColor = false;
            this.cardbtn.Click += new System.EventHandler(this.cardbtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(188, 83);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(85, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Beyond";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(24, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.AddcardBtn);
            this.panel1.Controls.Add(this.titlelbl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(190, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(753, 84);
            this.panel1.TabIndex = 1;
            // 
            // AddcardBtn
            // 
            this.AddcardBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddcardBtn.BackColor = System.Drawing.Color.Gainsboro;
            this.AddcardBtn.FlatAppearance.BorderSize = 0;
            this.AddcardBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddcardBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddcardBtn.Image = ((System.Drawing.Image)(resources.GetObject("AddcardBtn.Image")));
            this.AddcardBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddcardBtn.Location = new System.Drawing.Point(566, 15);
            this.AddcardBtn.Name = "AddcardBtn";
            this.AddcardBtn.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.AddcardBtn.Size = new System.Drawing.Size(130, 48);
            this.AddcardBtn.TabIndex = 1;
            this.AddcardBtn.Text = "  Add new card";
            this.AddcardBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AddcardBtn.UseVisualStyleBackColor = false;
            this.AddcardBtn.Click += new System.EventHandler(this.AddcardBtn_Click);
            // 
            // titlelbl
            // 
            this.titlelbl.AutoSize = true;
            this.titlelbl.BackColor = System.Drawing.Color.Gainsboro;
            this.titlelbl.Font = new System.Drawing.Font("Corbel", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titlelbl.ForeColor = System.Drawing.Color.Black;
            this.titlelbl.Location = new System.Drawing.Point(27, 22);
            this.titlelbl.Name = "titlelbl";
            this.titlelbl.Size = new System.Drawing.Size(92, 33);
            this.titlelbl.TabIndex = 0;
            this.titlelbl.Text = "titelLbl";
            // 
            // formPnl
            // 
            this.formPnl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("formPnl.BackgroundImage")));
            this.formPnl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.formPnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formPnl.Location = new System.Drawing.Point(190, 84);
            this.formPnl.Name = "formPnl";
            this.formPnl.Size = new System.Drawing.Size(753, 445);
            this.formPnl.TabIndex = 2;
            this.formPnl.Paint += new System.Windows.Forms.PaintEventHandler(this.formPnl_Paint);
            // 
            // MainApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(943, 529);
            this.Controls.Add(this.formPnl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnspnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.MainApp_Load);
            this.btnspnl.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel btnspnl;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Transbtn;
        private System.Windows.Forms.Button cardbtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button logOutbtn;
        private System.Windows.Forms.Panel formPnl;
        private System.Windows.Forms.Label titlelbl;
        private System.Windows.Forms.Button AddcardBtn;
    }
}

