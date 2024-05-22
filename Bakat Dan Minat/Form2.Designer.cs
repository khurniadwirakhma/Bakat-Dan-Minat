namespace Bakat_Dan_Minat
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.namatext = new System.Windows.Forms.TextBox();
            this.rblaki = new System.Windows.Forms.RadioButton();
            this.rbperempuan = new System.Windows.Forms.RadioButton();
            this.jurusancombo = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btbersih = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(181, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(181, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Jenis kelamin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(181, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "bakat";
            // 
            // namatext
            // 
            this.namatext.Location = new System.Drawing.Point(257, 88);
            this.namatext.Name = "namatext";
            this.namatext.Size = new System.Drawing.Size(166, 20);
            this.namatext.TabIndex = 3;
            // 
            // rblaki
            // 
            this.rblaki.AutoSize = true;
            this.rblaki.Location = new System.Drawing.Point(257, 126);
            this.rblaki.Name = "rblaki";
            this.rblaki.Size = new System.Drawing.Size(60, 17);
            this.rblaki.TabIndex = 4;
            this.rblaki.TabStop = true;
            this.rblaki.Text = "laki laki";
            this.rblaki.UseVisualStyleBackColor = true;
            // 
            // rbperempuan
            // 
            this.rbperempuan.AutoSize = true;
            this.rbperempuan.Location = new System.Drawing.Point(348, 126);
            this.rbperempuan.Name = "rbperempuan";
            this.rbperempuan.Size = new System.Drawing.Size(78, 17);
            this.rbperempuan.TabIndex = 5;
            this.rbperempuan.TabStop = true;
            this.rbperempuan.Text = "perempuan";
            this.rbperempuan.UseVisualStyleBackColor = true;
            // 
            // jurusancombo
            // 
            this.jurusancombo.FormattingEnabled = true;
            this.jurusancombo.Items.AddRange(new object[] {
            "MENYANYI",
            "MELUKIS",
            "MENARI"});
            this.jurusancombo.Location = new System.Drawing.Point(257, 169);
            this.jurusancombo.Name = "jurusancombo";
            this.jurusancombo.Size = new System.Drawing.Size(166, 21);
            this.jurusancombo.TabIndex = 6;
            this.jurusancombo.Text = "pilih bakat";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(257, 208);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(166, 108);
            this.listBox1.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(222, 356);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Proses";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btbersih
            // 
            this.btbersih.Location = new System.Drawing.Point(338, 356);
            this.btbersih.Name = "btbersih";
            this.btbersih.Size = new System.Drawing.Size(75, 23);
            this.btbersih.TabIndex = 9;
            this.btbersih.Text = "bersih";
            this.btbersih.UseVisualStyleBackColor = true;
            this.btbersih.Click += new System.EventHandler(this.btbersih_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(464, 356);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "keluar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btbersih);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.jurusancombo);
            this.Controls.Add(this.rbperempuan);
            this.Controls.Add(this.rblaki);
            this.Controls.Add(this.namatext);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox namatext;
        private System.Windows.Forms.RadioButton rblaki;
        private System.Windows.Forms.RadioButton rbperempuan;
        private System.Windows.Forms.ComboBox jurusancombo;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btbersih;
        private System.Windows.Forms.Button button3;
    }
}