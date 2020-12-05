
namespace Cinema_booking_RPCYYH
{
    partial class MovieBooking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MovieBooking));
            this.mainPanel = new System.Windows.Forms.Panel();
            this.panelDetails = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnBook = new System.Windows.Forms.Button();
            this.txtFree = new System.Windows.Forms.TextBox();
            this.labelFree = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelMovie = new System.Windows.Forms.Label();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.txtMovie = new System.Windows.Forms.TextBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelChairs = new System.Windows.Forms.Panel();
            this.mainPanel.SuspendLayout();
            this.panelDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.panelChairs);
            this.mainPanel.Controls.Add(this.panelDetails);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1048, 586);
            this.mainPanel.TabIndex = 0;
            
            // 
            // panelDetails
            // 
            this.panelDetails.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelDetails.BackgroundImage")));
            this.panelDetails.Controls.Add(this.btnBack);
            this.panelDetails.Controls.Add(this.btnBook);
            this.panelDetails.Controls.Add(this.txtFree);
            this.panelDetails.Controls.Add(this.labelFree);
            this.panelDetails.Controls.Add(this.txtTotal);
            this.panelDetails.Controls.Add(this.labelTotal);
            this.panelDetails.Controls.Add(this.labelTime);
            this.panelDetails.Controls.Add(this.labelMovie);
            this.panelDetails.Controls.Add(this.txtTime);
            this.panelDetails.Controls.Add(this.txtMovie);
            this.panelDetails.Controls.Add(this.labelTitle);
            this.panelDetails.Location = new System.Drawing.Point(0, 0);
            this.panelDetails.Name = "panelDetails";
            this.panelDetails.Size = new System.Drawing.Size(293, 585);
            this.panelDetails.TabIndex = 2;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBack.Location = new System.Drawing.Point(75, 506);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(123, 53);
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "Vissza";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnBook
            // 
            this.btnBook.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnBook.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.btnBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnBook.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBook.Location = new System.Drawing.Point(75, 447);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(123, 53);
            this.btnBook.TabIndex = 9;
            this.btnBook.Text = "Foglalás";
            this.btnBook.UseVisualStyleBackColor = false;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // txtFree
            // 
            this.txtFree.Enabled = false;
            this.txtFree.Location = new System.Drawing.Point(34, 371);
            this.txtFree.Name = "txtFree";
            this.txtFree.Size = new System.Drawing.Size(219, 26);
            this.txtFree.TabIndex = 8;
            // 
            // labelFree
            // 
            this.labelFree.AutoSize = true;
            this.labelFree.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelFree.Location = new System.Drawing.Point(30, 346);
            this.labelFree.Name = "labelFree";
            this.labelFree.Size = new System.Drawing.Size(208, 22);
            this.labelFree.TabIndex = 7;
            this.labelFree.Text = "Szabad helyek száma:";
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(34, 279);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(219, 26);
            this.txtTotal.TabIndex = 6;
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTotal.Location = new System.Drawing.Point(30, 254);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(189, 22);
            this.labelTotal.TabIndex = 5;
            this.labelTotal.Text = "Összes szék száma:";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTime.Location = new System.Drawing.Point(30, 164);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(82, 22);
            this.labelTime.TabIndex = 4;
            this.labelTime.Text = "Időpont:";
            // 
            // labelMovie
            // 
            this.labelMovie.AutoSize = true;
            this.labelMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMovie.Location = new System.Drawing.Point(30, 86);
            this.labelMovie.Name = "labelMovie";
            this.labelMovie.Size = new System.Drawing.Size(53, 22);
            this.labelMovie.TabIndex = 3;
            this.labelMovie.Text = "Film:";
            // 
            // txtTime
            // 
            this.txtTime.Enabled = false;
            this.txtTime.Location = new System.Drawing.Point(34, 189);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(219, 26);
            this.txtTime.TabIndex = 2;
            // 
            // txtMovie
            // 
            this.txtMovie.BackColor = System.Drawing.SystemColors.Window;
            this.txtMovie.Enabled = false;
            this.txtMovie.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtMovie.Location = new System.Drawing.Point(34, 111);
            this.txtMovie.Name = "txtMovie";
            this.txtMovie.Size = new System.Drawing.Size(219, 26);
            this.txtMovie.TabIndex = 1;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTitle.Location = new System.Drawing.Point(81, 22);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(128, 29);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Részletek";
            // 
            // panelChairs
            // 
            this.panelChairs.BackColor = System.Drawing.SystemColors.Window;
            this.panelChairs.Location = new System.Drawing.Point(290, 0);
            this.panelChairs.Name = "panelChairs";
            this.panelChairs.Size = new System.Drawing.Size(755, 586);
            this.panelChairs.TabIndex = 3;
            // 
            // MovieBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 586);
            this.Controls.Add(this.mainPanel);
            this.Name = "MovieBooking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Székválasztás";
            this.mainPanel.ResumeLayout(false);
            this.panelDetails.ResumeLayout(false);
            this.panelDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel panelDetails;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.TextBox txtFree;
        private System.Windows.Forms.Label labelFree;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelMovie;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.TextBox txtMovie;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panelChairs;
    }
}