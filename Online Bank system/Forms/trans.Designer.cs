namespace Online_Bank_system.Forms
{
    partial class trans
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(trans));
            this.stateBox = new System.Windows.Forms.ListBox();
            this.amountBox = new System.Windows.Forms.ListBox();
            this.dateBox = new System.Windows.Forms.ListBox();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // stateBox
            // 
            this.stateBox.BackColor = System.Drawing.SystemColors.Menu;
            this.stateBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.stateBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stateBox.FormattingEnabled = true;
            this.stateBox.ItemHeight = 25;
            this.stateBox.Location = new System.Drawing.Point(95, 96);
            this.stateBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.stateBox.Name = "stateBox";
            this.stateBox.Size = new System.Drawing.Size(293, 250);
            this.stateBox.TabIndex = 0;
            // 
            // amountBox
            // 
            this.amountBox.BackColor = System.Drawing.SystemColors.Menu;
            this.amountBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.amountBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountBox.FormattingEnabled = true;
            this.amountBox.ItemHeight = 25;
            this.amountBox.Location = new System.Drawing.Point(388, 96);
            this.amountBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.amountBox.Name = "amountBox";
            this.amountBox.Size = new System.Drawing.Size(281, 250);
            this.amountBox.TabIndex = 0;
            // 
            // dateBox
            // 
            this.dateBox.BackColor = System.Drawing.SystemColors.Menu;
            this.dateBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dateBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateBox.FormattingEnabled = true;
            this.dateBox.ItemHeight = 25;
            this.dateBox.Location = new System.Drawing.Point(669, 96);
            this.dateBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateBox.Name = "dateBox";
            this.dateBox.Size = new System.Drawing.Size(281, 250);
            this.dateBox.TabIndex = 0;
            // 
            // refreshBtn
            // 
            this.refreshBtn.BackColor = System.Drawing.Color.Silver;
            this.refreshBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshBtn.Location = new System.Drawing.Point(749, 418);
            this.refreshBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(170, 59);
            this.refreshBtn.TabIndex = 1;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.UseVisualStyleBackColor = false;
            // 
            // trans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(231)))), ((int)(((byte)(238)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.dateBox);
            this.Controls.Add(this.amountBox);
            this.Controls.Add(this.stateBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "trans";
            this.Text = "trans";
            this.Load += new System.EventHandler(this.trans_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox stateBox;
        private System.Windows.Forms.ListBox amountBox;
        private System.Windows.Forms.ListBox dateBox;
        private System.Windows.Forms.Button refreshBtn;
    }
}