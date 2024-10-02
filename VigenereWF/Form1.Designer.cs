namespace VigenereWF
{
    partial class PXH_Vigenere_Hill
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
            this.PlainText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Key1 = new System.Windows.Forms.TextBox();
            this.Encrypted = new System.Windows.Forms.Button();
            this.Decrypted = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.PlainTextDelBtn = new System.Windows.Forms.Button();
            this.Tab = new System.Windows.Forms.TabControl();
            this.Vigenere = new System.Windows.Forms.TabPage();
            this.RandomKey = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.EncryptedTextDelBtn = new System.Windows.Forms.Button();
            this.Key2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.EncryptedText = new System.Windows.Forms.TextBox();
            this.Hill = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.HillRandomKey = new System.Windows.Forms.Button();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox01 = new System.Windows.Forms.TextBox();
            this.textBox00 = new System.Windows.Forms.TextBox();
            this.HillDelete = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.HillEncryptedTxt = new System.Windows.Forms.TextBox();
            this.HillDecrypted = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.HillPlainTxt = new System.Windows.Forms.TextBox();
            this.HillEncrypted = new System.Windows.Forms.Button();
            this.EncryptedDel = new System.Windows.Forms.Button();
            this.PlainDel = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.Tab.SuspendLayout();
            this.Vigenere.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.Hill.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // PlainText
            // 
            this.PlainText.Location = new System.Drawing.Point(6, 26);
            this.PlainText.Multiline = true;
            this.PlainText.Name = "PlainText";
            this.PlainText.Size = new System.Drawing.Size(507, 436);
            this.PlainText.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(145, 472);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Khóa dịch K:";
            // 
            // Key1
            // 
            this.Key1.Location = new System.Drawing.Point(6, 497);
            this.Key1.Multiline = true;
            this.Key1.Name = "Key1";
            this.Key1.Size = new System.Drawing.Size(382, 61);
            this.Key1.TabIndex = 4;
            // 
            // Encrypted
            // 
            this.Encrypted.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Encrypted.Location = new System.Drawing.Point(554, 97);
            this.Encrypted.Name = "Encrypted";
            this.Encrypted.Size = new System.Drawing.Size(116, 49);
            this.Encrypted.TabIndex = 0;
            this.Encrypted.Text = "Mã hóa";
            this.Encrypted.UseVisualStyleBackColor = true;
            this.Encrypted.Click += new System.EventHandler(this.Encrypted_Click);
            // 
            // Decrypted
            // 
            this.Decrypted.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Decrypted.Location = new System.Drawing.Point(554, 335);
            this.Decrypted.Name = "Decrypted";
            this.Decrypted.Size = new System.Drawing.Size(116, 49);
            this.Decrypted.TabIndex = 7;
            this.Decrypted.Text = "Giải mã";
            this.Decrypted.UseVisualStyleBackColor = true;
            this.Decrypted.Click += new System.EventHandler(this.Decrypted_Click);
            // 
            // Delete
            // 
            this.Delete.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Delete.Location = new System.Drawing.Point(554, 216);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(116, 49);
            this.Delete.TabIndex = 7;
            this.Delete.Text = "Xóa";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.PlainTextDelBtn);
            this.groupBox2.Controls.Add(this.PlainText);
            this.groupBox2.Controls.Add(this.Key1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(8, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(519, 568);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bản rõ";
            // 
            // PlainTextDelBtn
            // 
            this.PlainTextDelBtn.Location = new System.Drawing.Point(394, 497);
            this.PlainTextDelBtn.Name = "PlainTextDelBtn";
            this.PlainTextDelBtn.Size = new System.Drawing.Size(119, 61);
            this.PlainTextDelBtn.TabIndex = 5;
            this.PlainTextDelBtn.Text = "Xóa bản rõ";
            this.PlainTextDelBtn.UseVisualStyleBackColor = true;
            this.PlainTextDelBtn.Click += new System.EventHandler(this.PlainTextDelBtn_Click);
            // 
            // Tab
            // 
            this.Tab.Controls.Add(this.Vigenere);
            this.Tab.Controls.Add(this.Hill);
            this.Tab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tab.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Tab.Location = new System.Drawing.Point(0, 0);
            this.Tab.Name = "Tab";
            this.Tab.SelectedIndex = 0;
            this.Tab.Size = new System.Drawing.Size(1231, 791);
            this.Tab.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.Tab.TabIndex = 8;
            // 
            // Vigenere
            // 
            this.Vigenere.Controls.Add(this.RandomKey);
            this.Vigenere.Controls.Add(this.groupBox1);
            this.Vigenere.Controls.Add(this.Decrypted);
            this.Vigenere.Controls.Add(this.Delete);
            this.Vigenere.Controls.Add(this.groupBox2);
            this.Vigenere.Controls.Add(this.Encrypted);
            this.Vigenere.Location = new System.Drawing.Point(4, 28);
            this.Vigenere.Name = "Vigenere";
            this.Vigenere.Padding = new System.Windows.Forms.Padding(3);
            this.Vigenere.Size = new System.Drawing.Size(1223, 718);
            this.Vigenere.TabIndex = 0;
            this.Vigenere.Text = "Vigenere";
            this.Vigenere.UseVisualStyleBackColor = true;
            // 
            // RandomKey
            // 
            this.RandomKey.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.RandomKey.Location = new System.Drawing.Point(554, 443);
            this.RandomKey.Name = "RandomKey";
            this.RandomKey.Size = new System.Drawing.Size(116, 49);
            this.RandomKey.TabIndex = 9;
            this.RandomKey.Text = "Tạo khóa";
            this.RandomKey.UseVisualStyleBackColor = true;
            this.RandomKey.Click += new System.EventHandler(this.RandomKey_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.EncryptedTextDelBtn);
            this.groupBox1.Controls.Add(this.Key2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.EncryptedText);
            this.groupBox1.Location = new System.Drawing.Point(694, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(519, 568);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bản mã";
            // 
            // EncryptedTextDelBtn
            // 
            this.EncryptedTextDelBtn.Location = new System.Drawing.Point(394, 497);
            this.EncryptedTextDelBtn.Name = "EncryptedTextDelBtn";
            this.EncryptedTextDelBtn.Size = new System.Drawing.Size(119, 61);
            this.EncryptedTextDelBtn.TabIndex = 8;
            this.EncryptedTextDelBtn.Text = "Xóa bản mã";
            this.EncryptedTextDelBtn.UseVisualStyleBackColor = true;
            this.EncryptedTextDelBtn.Click += new System.EventHandler(this.EncryptedTextDelBtn_Click);
            // 
            // Key2
            // 
            this.Key2.Location = new System.Drawing.Point(6, 497);
            this.Key2.Multiline = true;
            this.Key2.Name = "Key2";
            this.Key2.Size = new System.Drawing.Size(382, 61);
            this.Key2.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(145, 472);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Khóa dịch K:";
            // 
            // EncryptedText
            // 
            this.EncryptedText.Location = new System.Drawing.Point(6, 26);
            this.EncryptedText.Multiline = true;
            this.EncryptedText.Name = "EncryptedText";
            this.EncryptedText.Size = new System.Drawing.Size(507, 436);
            this.EncryptedText.TabIndex = 2;
            // 
            // Hill
            // 
            this.Hill.Controls.Add(this.PlainDel);
            this.Hill.Controls.Add(this.EncryptedDel);
            this.Hill.Controls.Add(this.groupBox5);
            this.Hill.Controls.Add(this.HillDelete);
            this.Hill.Controls.Add(this.groupBox3);
            this.Hill.Controls.Add(this.HillDecrypted);
            this.Hill.Controls.Add(this.groupBox4);
            this.Hill.Controls.Add(this.HillEncrypted);
            this.Hill.Location = new System.Drawing.Point(4, 28);
            this.Hill.Name = "Hill";
            this.Hill.Padding = new System.Windows.Forms.Padding(3);
            this.Hill.Size = new System.Drawing.Size(1223, 759);
            this.Hill.TabIndex = 1;
            this.Hill.Text = "Hill";
            this.Hill.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.button1);
            this.groupBox5.Controls.Add(this.textBox11);
            this.groupBox5.Controls.Add(this.HillRandomKey);
            this.groupBox5.Controls.Add(this.textBox10);
            this.groupBox5.Controls.Add(this.textBox01);
            this.groupBox5.Controls.Add(this.textBox00);
            this.groupBox5.Location = new System.Drawing.Point(344, 525);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(550, 174);
            this.groupBox5.TabIndex = 16;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Chọn khóa K";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button1.Location = new System.Drawing.Point(386, 101);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 40);
            this.button1.TabIndex = 16;
            this.button1.Text = "Xóa khóa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(228, 114);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(100, 27);
            this.textBox11.TabIndex = 3;
            this.textBox11.Leave += new System.EventHandler(this.textBox11_Leave);
            // 
            // HillRandomKey
            // 
            this.HillRandomKey.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.HillRandomKey.Location = new System.Drawing.Point(386, 43);
            this.HillRandomKey.Name = "HillRandomKey";
            this.HillRandomKey.Size = new System.Drawing.Size(105, 40);
            this.HillRandomKey.TabIndex = 15;
            this.HillRandomKey.Text = "Tạo khóa";
            this.HillRandomKey.UseVisualStyleBackColor = true;
            this.HillRandomKey.Click += new System.EventHandler(this.HillRandomKey_Click);
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(65, 114);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(100, 27);
            this.textBox10.TabIndex = 2;
            this.textBox10.Leave += new System.EventHandler(this.textBox10_Leave);
            // 
            // textBox01
            // 
            this.textBox01.Location = new System.Drawing.Point(228, 43);
            this.textBox01.Name = "textBox01";
            this.textBox01.Size = new System.Drawing.Size(100, 27);
            this.textBox01.TabIndex = 1;
            this.textBox01.Leave += new System.EventHandler(this.textBox01_Leave);
            // 
            // textBox00
            // 
            this.textBox00.Location = new System.Drawing.Point(65, 43);
            this.textBox00.Name = "textBox00";
            this.textBox00.Size = new System.Drawing.Size(100, 27);
            this.textBox00.TabIndex = 0;
            this.textBox00.Leave += new System.EventHandler(this.textBox00_Leave);
            // 
            // HillDelete
            // 
            this.HillDelete.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.HillDelete.Location = new System.Drawing.Point(556, 235);
            this.HillDelete.Name = "HillDelete";
            this.HillDelete.Size = new System.Drawing.Size(116, 49);
            this.HillDelete.TabIndex = 12;
            this.HillDelete.Text = "Xóa";
            this.HillDelete.UseVisualStyleBackColor = true;
            this.HillDelete.Click += new System.EventHandler(this.HillDelete_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.HillEncryptedTxt);
            this.groupBox3.Location = new System.Drawing.Point(696, 14);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(519, 469);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Bản mã";
            // 
            // HillEncryptedTxt
            // 
            this.HillEncryptedTxt.Location = new System.Drawing.Point(6, 26);
            this.HillEncryptedTxt.Multiline = true;
            this.HillEncryptedTxt.Name = "HillEncryptedTxt";
            this.HillEncryptedTxt.Size = new System.Drawing.Size(507, 436);
            this.HillEncryptedTxt.TabIndex = 2;
            // 
            // HillDecrypted
            // 
            this.HillDecrypted.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.HillDecrypted.Location = new System.Drawing.Point(556, 410);
            this.HillDecrypted.Name = "HillDecrypted";
            this.HillDecrypted.Size = new System.Drawing.Size(116, 49);
            this.HillDecrypted.TabIndex = 11;
            this.HillDecrypted.Text = "Giải mã";
            this.HillDecrypted.UseVisualStyleBackColor = true;
            this.HillDecrypted.Click += new System.EventHandler(this.HillDecrypted_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.HillPlainTxt);
            this.groupBox4.Location = new System.Drawing.Point(8, 14);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(519, 469);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Bản rõ";
            // 
            // HillPlainTxt
            // 
            this.HillPlainTxt.Location = new System.Drawing.Point(6, 26);
            this.HillPlainTxt.Multiline = true;
            this.HillPlainTxt.Name = "HillPlainTxt";
            this.HillPlainTxt.Size = new System.Drawing.Size(507, 436);
            this.HillPlainTxt.TabIndex = 2;
            // 
            // HillEncrypted
            // 
            this.HillEncrypted.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.HillEncrypted.Location = new System.Drawing.Point(556, 60);
            this.HillEncrypted.Name = "HillEncrypted";
            this.HillEncrypted.Size = new System.Drawing.Size(116, 49);
            this.HillEncrypted.TabIndex = 10;
            this.HillEncrypted.Text = "Mã hóa";
            this.HillEncrypted.UseVisualStyleBackColor = true;
            this.HillEncrypted.Click += new System.EventHandler(this.HillEncrypted_Click);
            // 
            // EncryptedDel
            // 
            this.EncryptedDel.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.EncryptedDel.Location = new System.Drawing.Point(1095, 489);
            this.EncryptedDel.Name = "EncryptedDel";
            this.EncryptedDel.Size = new System.Drawing.Size(114, 36);
            this.EncryptedDel.TabIndex = 17;
            this.EncryptedDel.Text = "Xóa bản mã ";
            this.EncryptedDel.UseVisualStyleBackColor = true;
            this.EncryptedDel.Click += new System.EventHandler(this.EncryptedDel_Click);
            // 
            // PlainDel
            // 
            this.PlainDel.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.PlainDel.Location = new System.Drawing.Point(14, 489);
            this.PlainDel.Name = "PlainDel";
            this.PlainDel.Size = new System.Drawing.Size(114, 36);
            this.PlainDel.TabIndex = 18;
            this.PlainDel.Text = "Xóa bản rõ";
            this.PlainDel.UseVisualStyleBackColor = true;
            this.PlainDel.Click += new System.EventHandler(this.PlainDel_Click);
            // 
            // PXH_Vigenere_Hill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1231, 791);
            this.Controls.Add(this.Tab);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "PXH_Vigenere_Hill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phạm Xuân Hoàn";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.Tab.ResumeLayout(false);
            this.Vigenere.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Hill.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox PlainText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Key1;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Decrypted;
        private System.Windows.Forms.Button Encrypted;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TabControl Tab;
        private System.Windows.Forms.TabPage Vigenere;
        private System.Windows.Forms.TabPage Hill;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox EncryptedText;
        private System.Windows.Forms.Button PlainTextDelBtn;
        private System.Windows.Forms.Button EncryptedTextDelBtn;
        private System.Windows.Forms.TextBox Key2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button RandomKey;
        private System.Windows.Forms.Button HillRandomKey;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox HillEncryptedTxt;
        private System.Windows.Forms.Button HillDecrypted;
        private System.Windows.Forms.Button HillDelete;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox HillPlainTxt;
        private System.Windows.Forms.Button HillEncrypted;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox01;
        private System.Windows.Forms.TextBox textBox00;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button PlainDel;
        private System.Windows.Forms.Button EncryptedDel;
    }
}

