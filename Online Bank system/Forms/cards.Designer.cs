namespace Online_Bank_system.Forms
{
    partial class cards
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cards));
            this.picPnl = new System.Windows.Forms.Panel();
            this.masterPic = new System.Windows.Forms.PictureBox();
            this.BalancdLbl = new System.Windows.Forms.Label();
            this.creditLbl = new System.Windows.Forms.Label();
            this.creditPic = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.sendBtn = new System.Windows.Forms.Button();
            this.sendPnl = new System.Windows.Forms.Panel();
            this.moneytxt = new System.Windows.Forms.TextBox();
            this.statuLbl = new System.Windows.Forms.Label();
            this.sendMoneyBtn = new System.Windows.Forms.Button();
            this.destinationUserTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.picPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.masterPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.creditPic)).BeginInit();
            this.panel2.SuspendLayout();
            this.sendPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // picPnl
            // 
            this.picPnl.Controls.Add(this.masterPic);
            this.picPnl.Controls.Add(this.BalancdLbl);
            this.picPnl.Controls.Add(this.creditLbl);
            this.picPnl.Controls.Add(this.creditPic);
            this.picPnl.Location = new System.Drawing.Point(26, 24);
            this.picPnl.Name = "picPnl";
            this.picPnl.Size = new System.Drawing.Size(274, 159);
            this.picPnl.TabIndex = 0;
            // 
            // masterPic
            // 
            this.masterPic.BackColor = System.Drawing.Color.Transparent;
            this.masterPic.Image = ((System.Drawing.Image)(resources.GetObject("masterPic.Image")));
            this.masterPic.Location = new System.Drawing.Point(149, 86);
            this.masterPic.Name = "masterPic";
            this.masterPic.Size = new System.Drawing.Size(134, 73);
            this.masterPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.masterPic.TabIndex = 3;
            this.masterPic.TabStop = false;
            // 
            // BalancdLbl
            // 
            this.BalancdLbl.AutoSize = true;
            this.BalancdLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BalancdLbl.ForeColor = System.Drawing.Color.White;
            this.BalancdLbl.Location = new System.Drawing.Point(16, 57);
            this.BalancdLbl.Name = "BalancdLbl";
            this.BalancdLbl.Size = new System.Drawing.Size(116, 25);
            this.BalancdLbl.TabIndex = 2;
            this.BalancdLbl.Text = "00,00 USD";
            // 
            // creditLbl
            // 
            this.creditLbl.AutoSize = true;
            this.creditLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.creditLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creditLbl.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.creditLbl.Location = new System.Drawing.Point(17, 115);
            this.creditLbl.Name = "creditLbl";
            this.creditLbl.Size = new System.Drawing.Size(68, 16);
            this.creditLbl.TabIndex = 1;
            this.creditLbl.Text = "creditNum";
            // 
            // creditPic
            // 
            this.creditPic.BackColor = System.Drawing.Color.Transparent;
            this.creditPic.Image = ((System.Drawing.Image)(resources.GetObject("creditPic.Image")));
            this.creditPic.Location = new System.Drawing.Point(0, 0);
            this.creditPic.Name = "creditPic";
            this.creditPic.Size = new System.Drawing.Size(274, 159);
            this.creditPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.creditPic.TabIndex = 0;
            this.creditPic.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.refreshBtn);
            this.panel2.Controls.Add(this.sendBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 203);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 247);
            this.panel2.TabIndex = 1;
            // 
            // refreshBtn
            // 
            this.refreshBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(231)))), ((int)(((byte)(238)))));
            this.refreshBtn.FlatAppearance.BorderSize = 0;
            this.refreshBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshBtn.Location = new System.Drawing.Point(26, 108);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(131, 45);
            this.refreshBtn.TabIndex = 0;
            this.refreshBtn.Text = "Refresh page";
            this.refreshBtn.UseVisualStyleBackColor = false;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // sendBtn
            // 
            this.sendBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(231)))), ((int)(((byte)(238)))));
            this.sendBtn.FlatAppearance.BorderSize = 0;
            this.sendBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendBtn.Location = new System.Drawing.Point(26, 23);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(131, 45);
            this.sendBtn.TabIndex = 0;
            this.sendBtn.Text = "Transfare money";
            this.sendBtn.UseVisualStyleBackColor = false;
            this.sendBtn.Click += new System.EventHandler(this.sendBtn_Click);
            // 
            // sendPnl
            // 
            this.sendPnl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sendPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(32)))), ((int)(((byte)(21)))));
            this.sendPnl.Controls.Add(this.moneytxt);
            this.sendPnl.Controls.Add(this.statuLbl);
            this.sendPnl.Controls.Add(this.sendMoneyBtn);
            this.sendPnl.Controls.Add(this.destinationUserTxt);
            this.sendPnl.Controls.Add(this.label2);
            this.sendPnl.Controls.Add(this.label1);
            this.sendPnl.Location = new System.Drawing.Point(806, 2);
            this.sendPnl.MaximumSize = new System.Drawing.Size(293, 500);
            this.sendPnl.Name = "sendPnl";
            this.sendPnl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.sendPnl.Size = new System.Drawing.Size(293, 500);
            this.sendPnl.TabIndex = 2;
            // 
            // moneytxt
            // 
            this.moneytxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moneytxt.Location = new System.Drawing.Point(23, 206);
            this.moneytxt.Multiline = true;
            this.moneytxt.Name = "moneytxt";
            this.moneytxt.Size = new System.Drawing.Size(244, 30);
            this.moneytxt.TabIndex = 4;
            // 
            // statuLbl
            // 
            this.statuLbl.AutoSize = true;
            this.statuLbl.Location = new System.Drawing.Point(32, 123);
            this.statuLbl.Name = "statuLbl";
            this.statuLbl.Size = new System.Drawing.Size(0, 13);
            this.statuLbl.TabIndex = 3;
            // 
            // sendMoneyBtn
            // 
            this.sendMoneyBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(54)))), ((int)(((byte)(245)))));
            this.sendMoneyBtn.FlatAppearance.BorderSize = 0;
            this.sendMoneyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendMoneyBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendMoneyBtn.ForeColor = System.Drawing.Color.White;
            this.sendMoneyBtn.Location = new System.Drawing.Point(72, 309);
            this.sendMoneyBtn.Name = "sendMoneyBtn";
            this.sendMoneyBtn.Size = new System.Drawing.Size(158, 36);
            this.sendMoneyBtn.TabIndex = 2;
            this.sendMoneyBtn.Text = "Send";
            this.sendMoneyBtn.UseVisualStyleBackColor = false;
            this.sendMoneyBtn.Click += new System.EventHandler(this.sendMoneyBtn_Click);
            // 
            // destinationUserTxt
            // 
            this.destinationUserTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.destinationUserTxt.Location = new System.Drawing.Point(23, 90);
            this.destinationUserTxt.Multiline = true;
            this.destinationUserTxt.Name = "destinationUserTxt";
            this.destinationUserTxt.Size = new System.Drawing.Size(244, 30);
            this.destinationUserTxt.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(19, 179);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(126, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Enter the money";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(19, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter the credit card number";
            // 
            // cards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sendPnl);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.picPnl);
            this.Name = "cards";
            this.Text = "cards";
            this.Load += new System.EventHandler(this.cards_Load);
            this.picPnl.ResumeLayout(false);
            this.picPnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.masterPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.creditPic)).EndInit();
            this.panel2.ResumeLayout(false);
            this.sendPnl.ResumeLayout(false);
            this.sendPnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel picPnl;
        private System.Windows.Forms.PictureBox creditPic;
        private System.Windows.Forms.Label creditLbl;
        private System.Windows.Forms.Label BalancdLbl;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button sendBtn;
        private System.Windows.Forms.Panel sendPnl;
        private System.Windows.Forms.Button sendMoneyBtn;
        private System.Windows.Forms.TextBox destinationUserTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label statuLbl;
        private System.Windows.Forms.TextBox moneytxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox masterPic;
        private System.Windows.Forms.Button refreshBtn;
    }
}