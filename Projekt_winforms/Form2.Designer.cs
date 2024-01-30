namespace Projekt_winforms
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer_date = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Przycisk_Wpisz_Date = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ZapisDaty = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Deletebutton = new System.Windows.Forms.Button();
            this.Editbutton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.Label();
            this.id_value = new System.Windows.Forms.Label();
            this.Czyscik = new System.Windows.Forms.Button();
            this.Refresh = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.ZapisDaty.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer_date
            // 
            this.timer_date.AutoSize = true;
            this.timer_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.timer_date.Location = new System.Drawing.Point(23, 36);
            this.timer_date.Name = "timer_date";
            this.timer_date.Size = new System.Drawing.Size(99, 25);
            this.timer_date.TabIndex = 0;
            this.timer_date.Text = "timer-date";
            this.timer_date.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(15, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dzisiejsza data";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.timer_date);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(638, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(150, 75);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // Przycisk_Wpisz_Date
            // 
            this.Przycisk_Wpisz_Date.Location = new System.Drawing.Point(6, 246);
            this.Przycisk_Wpisz_Date.Name = "Przycisk_Wpisz_Date";
            this.Przycisk_Wpisz_Date.Size = new System.Drawing.Size(113, 44);
            this.Przycisk_Wpisz_Date.TabIndex = 3;
            this.Przycisk_Wpisz_Date.Text = "Zapisz datę do bazy";
            this.Przycisk_Wpisz_Date.UseVisualStyleBackColor = true;
            this.Przycisk_Wpisz_Date.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(76, 138);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(129, 20);
            this.dateTimePicker1.TabIndex = 4;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(76, 195);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(129, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ZapisDaty
            // 
            this.ZapisDaty.Controls.Add(this.Refresh);
            this.ZapisDaty.Controls.Add(this.Czyscik);
            this.ZapisDaty.Controls.Add(this.id_value);
            this.ZapisDaty.Controls.Add(this.Id);
            this.ZapisDaty.Controls.Add(this.comboBox1);
            this.ZapisDaty.Controls.Add(this.Deletebutton);
            this.ZapisDaty.Controls.Add(this.Editbutton);
            this.ZapisDaty.Controls.Add(this.label3);
            this.ZapisDaty.Controls.Add(this.label2);
            this.ZapisDaty.Controls.Add(this.dateTimePicker1);
            this.ZapisDaty.Controls.Add(this.Przycisk_Wpisz_Date);
            this.ZapisDaty.Controls.Add(this.textBox1);
            this.ZapisDaty.Location = new System.Drawing.Point(28, 41);
            this.ZapisDaty.Name = "ZapisDaty";
            this.ZapisDaty.Size = new System.Drawing.Size(565, 373);
            this.ZapisDaty.TabIndex = 6;
            this.ZapisDaty.TabStop = false;
            this.ZapisDaty.Text = "Zapisywanie daty do bazy";
            this.ZapisDaty.Enter += new System.EventHandler(this.ZapisDaty_Enter);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(355, 135);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Deletebutton
            // 
            this.Deletebutton.Location = new System.Drawing.Point(7, 309);
            this.Deletebutton.Name = "Deletebutton";
            this.Deletebutton.Size = new System.Drawing.Size(112, 42);
            this.Deletebutton.TabIndex = 9;
            this.Deletebutton.Text = "Usuń datę z bazy";
            this.Deletebutton.UseVisualStyleBackColor = true;
            this.Deletebutton.Click += new System.EventHandler(this.Deletebutton_Click);
            // 
            // Editbutton
            // 
            this.Editbutton.Location = new System.Drawing.Point(149, 246);
            this.Editbutton.Name = "Editbutton";
            this.Editbutton.Size = new System.Drawing.Size(121, 44);
            this.Editbutton.TabIndex = 8;
            this.Editbutton.Text = "Edytuj Datę";
            this.Editbutton.UseVisualStyleBackColor = true;
            this.Editbutton.Click += new System.EventHandler(this.Editbutton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Opis";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Data";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Id
            // 
            this.Id.AutoSize = true;
            this.Id.Location = new System.Drawing.Point(29, 96);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(16, 13);
            this.Id.TabIndex = 11;
            this.Id.Text = "Id";
            this.Id.Click += new System.EventHandler(this.label4_Click);
            // 
            // id_value
            // 
            this.id_value.AutoSize = true;
            this.id_value.Location = new System.Drawing.Point(73, 96);
            this.id_value.Name = "id_value";
            this.id_value.Size = new System.Drawing.Size(16, 13);
            this.id_value.TabIndex = 12;
            this.id_value.Text = " - ";
            this.id_value.Click += new System.EventHandler(this.id_value_Click);
            // 
            // Czyscik
            // 
            this.Czyscik.Location = new System.Drawing.Point(149, 309);
            this.Czyscik.Name = "Czyscik";
            this.Czyscik.Size = new System.Drawing.Size(121, 42);
            this.Czyscik.TabIndex = 13;
            this.Czyscik.Text = "Wyczyść Pola";
            this.Czyscik.UseVisualStyleBackColor = true;
            this.Czyscik.Click += new System.EventHandler(this.Czyscik_Click);
            // 
            // Refresh
            // 
            this.Refresh.Location = new System.Drawing.Point(371, 96);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(90, 23);
            this.Refresh.TabIndex = 14;
            this.Refresh.Text = "Odśwież bazę";
            this.Refresh.UseVisualStyleBackColor = true;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ZapisDaty);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ZapisDaty.ResumeLayout(false);
            this.ZapisDaty.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label timer_date;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Przycisk_Wpisz_Date;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox ZapisDaty;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Editbutton;
        private System.Windows.Forms.Button Deletebutton;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label Id;
        private System.Windows.Forms.Label id_value;
        private System.Windows.Forms.Button Czyscik;
        private System.Windows.Forms.Button Refresh;
    }
}