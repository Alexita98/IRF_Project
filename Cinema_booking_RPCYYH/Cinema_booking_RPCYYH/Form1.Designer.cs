
namespace Cinema_booking_RPCYYH
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.labelTitel = new System.Windows.Forms.Label();
            this.cboxTime = new System.Windows.Forms.ComboBox();
            this.labelSeatNumber = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboxMovie = new System.Windows.Forms.ComboBox();
            this.btnSeats = new System.Windows.Forms.Button();
            this.txtboxTitle = new System.Windows.Forms.TextBox();
            this.cboxYear = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(47, 80);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.splitContainer1.Panel1.Controls.Add(this.labelTitel);
            this.splitContainer1.Panel1.Controls.Add(this.cboxTime);
            this.splitContainer1.Panel1.Controls.Add(this.labelSeatNumber);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.cboxMovie);
            this.splitContainer1.Panel1.Controls.Add(this.btnSeats);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer1.Panel2.Controls.Add(this.txtboxTitle);
            this.splitContainer1.Panel2.Controls.Add(this.cboxYear);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(909, 447);
            this.splitContainer1.SplitterDistance = 294;
            this.splitContainer1.TabIndex = 0;
            // 
            // labelTitel
            // 
            this.labelTitel.AutoSize = true;
            this.labelTitel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTitel.ForeColor = System.Drawing.Color.Maroon;
            this.labelTitel.Location = new System.Drawing.Point(3, 13);
            this.labelTitel.Name = "labelTitel";
            this.labelTitel.Size = new System.Drawing.Size(288, 29);
            this.labelTitel.TabIndex = 15;
            this.labelTitel.Text = "BlahaMozi Jegyfoglalás";
            // 
            // cboxTime
            // 
            this.cboxTime.FormattingEnabled = true;
            this.cboxTime.Location = new System.Drawing.Point(31, 212);
            this.cboxTime.Name = "cboxTime";
            this.cboxTime.Size = new System.Drawing.Size(234, 28);
            this.cboxTime.TabIndex = 10;
            this.cboxTime.Text = "Iőpontok";
            this.cboxTime.SelectedIndexChanged += new System.EventHandler(this.cboxTime_SelectedIndexChanged);
            // 
            // labelSeatNumber
            // 
            this.labelSeatNumber.AutoSize = true;
            this.labelSeatNumber.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelSeatNumber.Location = new System.Drawing.Point(181, 278);
            this.labelSeatNumber.Name = "labelSeatNumber";
            this.labelSeatNumber.Size = new System.Drawing.Size(0, 20);
            this.labelSeatNumber.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(27, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Szabad helyek:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(27, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Időpont kiválasztása:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(27, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Film kiválasztása:";
            // 
            // cboxMovie
            // 
            this.cboxMovie.FormattingEnabled = true;
            this.cboxMovie.Location = new System.Drawing.Point(31, 126);
            this.cboxMovie.Name = "cboxMovie";
            this.cboxMovie.Size = new System.Drawing.Size(234, 28);
            this.cboxMovie.TabIndex = 9;
            this.cboxMovie.Text = "Filmek";
            this.cboxMovie.SelectedIndexChanged += new System.EventHandler(this.cboxMovie_SelectedIndexChanged);
            // 
            // btnSeats
            // 
            this.btnSeats.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnSeats.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSeats.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSeats.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSeats.Location = new System.Drawing.Point(65, 361);
            this.btnSeats.Name = "btnSeats";
            this.btnSeats.Size = new System.Drawing.Size(166, 52);
            this.btnSeats.TabIndex = 8;
            this.btnSeats.Text = "Helyfoglalás";
            this.btnSeats.UseVisualStyleBackColor = false;
            this.btnSeats.Click += new System.EventHandler(this.btnSeats_Click);
            // 
            // txtboxTitle
            // 
            this.txtboxTitle.Location = new System.Drawing.Point(233, 58);
            this.txtboxTitle.Name = "txtboxTitle";
            this.txtboxTitle.Size = new System.Drawing.Size(321, 26);
            this.txtboxTitle.TabIndex = 14;
            this.txtboxTitle.Text = "Kereső";
            // 
            // cboxYear
            // 
            this.cboxYear.FormattingEnabled = true;
            this.cboxYear.Location = new System.Drawing.Point(61, 56);
            this.cboxYear.Name = "cboxYear";
            this.cboxYear.Size = new System.Drawing.Size(158, 28);
            this.cboxYear.TabIndex = 11;
            this.cboxYear.Text = "Megjelenési év";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Szűrők:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(61, 106);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(493, 307);
            this.dataGridView1.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1001, 606);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jegyfoglalás";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnSeats;
        private System.Windows.Forms.ComboBox cboxTime;
        private System.Windows.Forms.ComboBox cboxMovie;
        private System.Windows.Forms.Label labelSeatNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboxYear;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelTitel;
        private System.Windows.Forms.TextBox txtboxTitle;
    }
}

