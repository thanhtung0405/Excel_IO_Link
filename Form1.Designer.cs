
namespace Locking_Time
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.category = new System.Windows.Forms.ComboBox();
            this.incident_txt = new System.Windows.Forms.TextBox();
            this.time_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.costcenter = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.week = new System.Windows.Forms.ComboBox();
            this.sheet = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.name_label = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(232, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "WW";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(232, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 40);
            this.label2.TabIndex = 1;
            this.label2.Text = "Category";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(232, 326);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 40);
            this.label3.TabIndex = 2;
            this.label3.Text = "Incident No.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(232, 392);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(213, 40);
            this.label4.TabIndex = 3;
            this.label4.Text = "Time (Hours)";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(143, 448);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 50);
            this.button1.TabIndex = 4;
            this.button1.Text = "Enter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(359, 448);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 50);
            this.button2.TabIndex = 5;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(576, 448);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(191, 50);
            this.button3.TabIndex = 6;
            this.button3.Text = "File directory";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // category
            // 
            this.category.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.category.FormattingEnabled = true;
            this.category.Location = new System.Drawing.Point(526, 209);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(319, 44);
            this.category.TabIndex = 8;
            // 
            // incident_txt
            // 
            this.incident_txt.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incident_txt.Location = new System.Drawing.Point(526, 326);
            this.incident_txt.Name = "incident_txt";
            this.incident_txt.Size = new System.Drawing.Size(319, 40);
            this.incident_txt.TabIndex = 9;
            this.incident_txt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // time_txt
            // 
            this.time_txt.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time_txt.Location = new System.Drawing.Point(526, 392);
            this.time_txt.Name = "time_txt";
            this.time_txt.Size = new System.Drawing.Size(128, 40);
            this.time_txt.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.LimeGreen;
            this.label5.Location = new System.Drawing.Point(417, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(333, 55);
            this.label5.TabIndex = 11;
            this.label5.Text = "LOCK TIME APP";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(232, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(190, 40);
            this.label6.TabIndex = 12;
            this.label6.Text = "Cost center";
            // 
            // costcenter
            // 
            this.costcenter.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costcenter.FormattingEnabled = true;
            this.costcenter.Location = new System.Drawing.Point(526, 269);
            this.costcenter.Name = "costcenter";
            this.costcenter.Size = new System.Drawing.Size(319, 44);
            this.costcenter.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(234, 501);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(741, 26);
            this.label7.TabIndex = 14;
            this.label7.Text = "Please select the Excel file in \"File directory\" button for precise time locking";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // week
            // 
            this.week.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.week.FormattingEnabled = true;
            this.week.Location = new System.Drawing.Point(526, 151);
            this.week.Name = "week";
            this.week.Size = new System.Drawing.Size(128, 44);
            this.week.TabIndex = 15;
            this.week.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // sheet
            // 
            this.sheet.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sheet.FormattingEnabled = true;
            this.sheet.Location = new System.Drawing.Point(526, 92);
            this.sheet.Name = "sheet";
            this.sheet.Size = new System.Drawing.Size(185, 44);
            this.sheet.TabIndex = 17;
            this.sheet.SelectedIndexChanged += new System.EventHandler(this.sheet_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Trebuchet MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(232, 92);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(199, 40);
            this.label9.TabIndex = 19;
            this.label9.Text = "Select sheet";
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_label.Location = new System.Drawing.Point(521, 63);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(74, 26);
            this.name_label.TabIndex = 21;
            this.name_label.Text = "*Name";
            this.name_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(717, 92);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(128, 44);
            this.button4.TabIndex = 22;
            this.button4.Text = "Select";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(139, 134);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(847, 448);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(128, 50);
            this.button5.TabIndex = 24;
            this.button5.Text = "History";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1116, 536);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.name_label);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.sheet);
            this.Controls.Add(this.week);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.costcenter);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.time_txt);
            this.Controls.Add(this.incident_txt);
            this.Controls.Add(this.category);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Locktime";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox category;
        private System.Windows.Forms.TextBox incident_txt;
        private System.Windows.Forms.TextBox time_txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox costcenter;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox week;
        private System.Windows.Forms.ComboBox sheet;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button5;
    }
}

