﻿
namespace Cinema_booking_RPCYYH
{
    partial class UserControl_Information
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl_Information));
            this.labelTitle = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.textPhone = new System.Windows.Forms.TextBox();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.textName = new System.Windows.Forms.TextBox();
            this.btnFinal = new System.Windows.Forms.Button();
            this.textDate = new System.Windows.Forms.TextBox();
            this.textMovie = new System.Windows.Forms.TextBox();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelMovie = new System.Windows.Forms.Label();
            this.textTotal = new System.Windows.Forms.TextBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelNumber = new System.Windows.Forms.Label();
            this.labelTitle2 = new System.Windows.Forms.Label();
            this.textNumber = new System.Windows.Forms.TextBox();
            this.panelPopcorn = new System.Windows.Forms.Panel();
            this.labelFormat = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTitle.Location = new System.Drawing.Point(207, 24);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(206, 29);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Foglalási adatok";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.Window;
            this.splitContainer1.Panel1.Controls.Add(this.labelFormat);
            this.splitContainer1.Panel1.Controls.Add(this.labelTitle);
            this.splitContainer1.Panel1.Controls.Add(this.labelPhone);
            this.splitContainer1.Panel1.Controls.Add(this.labelEmail);
            this.splitContainer1.Panel1.Controls.Add(this.labelName);
            this.splitContainer1.Panel1.Controls.Add(this.textPhone);
            this.splitContainer1.Panel1.Controls.Add(this.textEmail);
            this.splitContainer1.Panel1.Controls.Add(this.textName);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splitContainer1.Panel2.BackgroundImage")));
            this.splitContainer1.Panel2.Controls.Add(this.btnFinal);
            this.splitContainer1.Panel2.Controls.Add(this.textDate);
            this.splitContainer1.Panel2.Controls.Add(this.textMovie);
            this.splitContainer1.Panel2.Controls.Add(this.labelTime);
            this.splitContainer1.Panel2.Controls.Add(this.labelMovie);
            this.splitContainer1.Panel2.Controls.Add(this.textTotal);
            this.splitContainer1.Panel2.Controls.Add(this.labelPrice);
            this.splitContainer1.Panel2.Controls.Add(this.labelNumber);
            this.splitContainer1.Panel2.Controls.Add(this.labelTitle2);
            this.splitContainer1.Panel2.Controls.Add(this.textNumber);
            this.splitContainer1.Size = new System.Drawing.Size(982, 555);
            this.splitContainer1.SplitterDistance = 657;
            this.splitContainer1.TabIndex = 9;
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(39, 230);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(114, 20);
            this.labelPhone.TabIndex = 15;
            this.labelPhone.Text = "Telefonszám: *";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(58, 172);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(95, 20);
            this.labelEmail.TabIndex = 14;
            this.labelEmail.Text = "E-mail cím: *";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(60, 117);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(93, 20);
            this.labelName.TabIndex = 13;
            this.labelName.Text = "Teljes név: *";
            // 
            // textPhone
            // 
            this.textPhone.Location = new System.Drawing.Point(171, 227);
            this.textPhone.Name = "textPhone";
            this.textPhone.Size = new System.Drawing.Size(297, 26);
            this.textPhone.TabIndex = 11;
            this.textPhone.TextChanged += new System.EventHandler(this.textName_TextChanged);
            this.textPhone.Validating += new System.ComponentModel.CancelEventHandler(this.textPhone_Validating);
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(171, 169);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(297, 26);
            this.textEmail.TabIndex = 10;
            this.textEmail.TextChanged += new System.EventHandler(this.textName_TextChanged);
            this.textEmail.Validating += new System.ComponentModel.CancelEventHandler(this.textEmail_Validating);
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(171, 114);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(297, 26);
            this.textName.TabIndex = 9;
            this.textName.TextChanged += new System.EventHandler(this.textName_TextChanged);
            this.textName.Validating += new System.ComponentModel.CancelEventHandler(this.textName_Validating);
            // 
            // btnFinal
            // 
            this.btnFinal.BackColor = System.Drawing.SystemColors.WindowText;
            this.btnFinal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.btnFinal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnFinal.ForeColor = System.Drawing.SystemColors.Window;
            this.btnFinal.Location = new System.Drawing.Point(96, 428);
            this.btnFinal.Name = "btnFinal";
            this.btnFinal.Size = new System.Drawing.Size(157, 49);
            this.btnFinal.TabIndex = 18;
            this.btnFinal.Text = "Véglegesítés";
            this.btnFinal.UseVisualStyleBackColor = false;
            this.btnFinal.Click += new System.EventHandler(this.btnFinal_Click);
            // 
            // textDate
            // 
            this.textDate.Enabled = false;
            this.textDate.Location = new System.Drawing.Point(147, 267);
            this.textDate.Name = "textDate";
            this.textDate.Size = new System.Drawing.Size(157, 26);
            this.textDate.TabIndex = 23;
            // 
            // textMovie
            // 
            this.textMovie.Enabled = false;
            this.textMovie.Location = new System.Drawing.Point(147, 224);
            this.textMovie.Name = "textMovie";
            this.textMovie.Size = new System.Drawing.Size(157, 26);
            this.textMovie.TabIndex = 22;
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(67, 270);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(64, 20);
            this.labelTime.TabIndex = 21;
            this.labelTime.Text = "Időpont";
            // 
            // labelMovie
            // 
            this.labelMovie.AutoSize = true;
            this.labelMovie.Location = new System.Drawing.Point(93, 233);
            this.labelMovie.Name = "labelMovie";
            this.labelMovie.Size = new System.Drawing.Size(38, 20);
            this.labelMovie.TabIndex = 20;
            this.labelMovie.Text = "Film";
            // 
            // textTotal
            // 
            this.textTotal.Enabled = false;
            this.textTotal.Location = new System.Drawing.Point(147, 179);
            this.textTotal.Name = "textTotal";
            this.textTotal.Size = new System.Drawing.Size(157, 26);
            this.textTotal.TabIndex = 19;
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(26, 179);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(105, 20);
            this.labelPrice.TabIndex = 18;
            this.labelPrice.Text = "Teljes összeg";
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.Location = new System.Drawing.Point(21, 133);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(110, 20);
            this.labelNumber.TabIndex = 16;
            this.labelNumber.Text = "Jegyek száma";
            // 
            // labelTitle2
            // 
            this.labelTitle2.AutoSize = true;
            this.labelTitle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTitle2.Location = new System.Drawing.Point(46, 24);
            this.labelTitle2.Name = "labelTitle2";
            this.labelTitle2.Size = new System.Drawing.Size(238, 29);
            this.labelTitle2.TabIndex = 17;
            this.labelTitle2.Text = "Foglalási összesítő";
            // 
            // textNumber
            // 
            this.textNumber.Enabled = false;
            this.textNumber.Location = new System.Drawing.Point(147, 130);
            this.textNumber.Name = "textNumber";
            this.textNumber.Size = new System.Drawing.Size(157, 26);
            this.textNumber.TabIndex = 12;
            // 
            // panelPopcorn
            // 
            this.panelPopcorn.BackColor = System.Drawing.SystemColors.Window;
            this.panelPopcorn.Location = new System.Drawing.Point(0, 320);
            this.panelPopcorn.Name = "panelPopcorn";
            this.panelPopcorn.Size = new System.Drawing.Size(651, 235);
            this.panelPopcorn.TabIndex = 16;
            // 
            // labelFormat
            // 
            this.labelFormat.AutoSize = true;
            this.labelFormat.Location = new System.Drawing.Point(171, 260);
            this.labelFormat.Name = "labelFormat";
            this.labelFormat.Size = new System.Drawing.Size(203, 20);
            this.labelFormat.TabIndex = 16;
            this.labelFormat.Text = "Formátum: 06/30-000-0000";
            // 
            // UserControl_Information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelPopcorn);
            this.Controls.Add(this.splitContainer1);
            this.Name = "UserControl_Information";
            this.Size = new System.Drawing.Size(982, 555);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textDate;
        private System.Windows.Forms.TextBox textMovie;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelMovie;
        private System.Windows.Forms.TextBox textTotal;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelNumber;
        private System.Windows.Forms.Label labelTitle2;
        private System.Windows.Forms.TextBox textNumber;
        private System.Windows.Forms.Button btnFinal;
        private System.Windows.Forms.Panel panelPopcorn;
        public System.Windows.Forms.TextBox textPhone;
        public System.Windows.Forms.TextBox textEmail;
        public System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label labelFormat;
    }
}
