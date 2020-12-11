
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
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cboxTime = new System.Windows.Forms.ComboBox();
            this.labelSeatNumber = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboxMovie = new System.Windows.Forms.ComboBox();
            this.btnSeats = new System.Windows.Forms.Button();
            this.cBoxFilters = new System.Windows.Forms.ComboBox();
            this.cboxYear = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
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
            this.splitContainer1.Panel1.Controls.Add(this.btnSave);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
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
            this.splitContainer1.Panel2.Controls.Add(this.cBoxFilters);
            this.splitContainer1.Panel2.Controls.Add(this.cboxYear);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(909, 447);
            this.splitContainer1.SplitterDistance = 294;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSave.Location = new System.Drawing.Point(54, 302);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(200, 51);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Moziműsor mentése";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(3, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 29);
            this.label1.TabIndex = 15;
            this.label1.Text = "BlahaMozi Jegyfoglalás";
            // 
            // cboxTime
            // 
            this.cboxTime.FormattingEnabled = true;
            this.cboxTime.Location = new System.Drawing.Point(31, 212);
            this.cboxTime.Name = "cboxTime";
            this.cboxTime.Size = new System.Drawing.Size(234, 28);
            this.cboxTime.TabIndex = 10;
            this.cboxTime.SelectedIndexChanged += new System.EventHandler(this.cboxTime_SelectedIndexChanged);
            // 
            // labelSeatNumber
            // 
            this.labelSeatNumber.AutoSize = true;
            this.labelSeatNumber.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelSeatNumber.Location = new System.Drawing.Point(174, 263);
            this.labelSeatNumber.Name = "labelSeatNumber";
            this.labelSeatNumber.Size = new System.Drawing.Size(0, 20);
            this.labelSeatNumber.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(27, 263);
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
            this.cboxMovie.SelectedIndexChanged += new System.EventHandler(this.cboxMovie_SelectedIndexChanged);
            // 
            // btnSeats
            // 
            this.btnSeats.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnSeats.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.btnSeats.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeats.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSeats.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSeats.Location = new System.Drawing.Point(54, 376);
            this.btnSeats.Name = "btnSeats";
            this.btnSeats.Size = new System.Drawing.Size(200, 51);
            this.btnSeats.TabIndex = 8;
            this.btnSeats.Text = "Helyfoglalás";
            this.btnSeats.UseVisualStyleBackColor = false;
            this.btnSeats.Click += new System.EventHandler(this.btnSeats_Click);
            // 
            // cBoxFilters
            // 
            this.cBoxFilters.FormattingEnabled = true;
            this.cBoxFilters.Location = new System.Drawing.Point(61, 53);
            this.cBoxFilters.Name = "cBoxFilters";
            this.cBoxFilters.Size = new System.Drawing.Size(158, 28);
            this.cBoxFilters.TabIndex = 13;
            this.cBoxFilters.Text = "Filters";
            this.cBoxFilters.SelectedIndexChanged += new System.EventHandler(this.cBoxFilters_SelectedIndexChanged);
            // 
            // cboxYear
            // 
            this.cboxYear.FormattingEnabled = true;
            this.cboxYear.Location = new System.Drawing.Point(243, 53);
            this.cboxYear.Name = "cboxYear";
            this.cboxYear.Size = new System.Drawing.Size(158, 28);
            this.cboxYear.TabIndex = 11;
            this.cboxYear.SelectedIndexChanged += new System.EventHandler(this.cboxYear_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Szűrők:";
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cBoxFilters;
    }
}

