namespace JPVocabFun
{
    partial class frmSettings
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
            this.rbJapanese = new System.Windows.Forms.RadioButton();
            this.rbEnglish = new System.Windows.Forms.RadioButton();
            this.rbJPHiragana = new System.Windows.Forms.RadioButton();
            this.rbJPRomaji = new System.Windows.Forms.RadioButton();
            this.rbJPBoth = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbERomaji = new System.Windows.Forms.RadioButton();
            this.rbEHiragana = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmdAccept = new System.Windows.Forms.Button();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbJapanese
            // 
            this.rbJapanese.AutoSize = true;
            this.rbJapanese.Checked = true;
            this.rbJapanese.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.rbJapanese.Location = new System.Drawing.Point(6, 43);
            this.rbJapanese.Name = "rbJapanese";
            this.rbJapanese.Size = new System.Drawing.Size(326, 21);
            this.rbJapanese.TabIndex = 2;
            this.rbJapanese.TabStop = true;
            this.rbJapanese.Text = "Japanese (Give English answer) - default";
            this.rbJapanese.UseVisualStyleBackColor = true;
            this.rbJapanese.CheckedChanged += new System.EventHandler(this.rbJapanese_CheckedChanged);
            // 
            // rbEnglish
            // 
            this.rbEnglish.AutoSize = true;
            this.rbEnglish.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.rbEnglish.Location = new System.Drawing.Point(6, 162);
            this.rbEnglish.Name = "rbEnglish";
            this.rbEnglish.Size = new System.Drawing.Size(260, 21);
            this.rbEnglish.TabIndex = 3;
            this.rbEnglish.Text = "English (Give Japanese answer)";
            this.rbEnglish.UseVisualStyleBackColor = true;
            this.rbEnglish.CheckedChanged += new System.EventHandler(this.rbEnglish_CheckedChanged);
            // 
            // rbJPHiragana
            // 
            this.rbJPHiragana.AutoSize = true;
            this.rbJPHiragana.BackColor = System.Drawing.Color.Transparent;
            this.rbJPHiragana.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.rbJPHiragana.Location = new System.Drawing.Point(27, 42);
            this.rbJPHiragana.Name = "rbJPHiragana";
            this.rbJPHiragana.Size = new System.Drawing.Size(68, 17);
            this.rbJPHiragana.TabIndex = 11;
            this.rbJPHiragana.Text = "Hiragana";
            this.rbJPHiragana.UseVisualStyleBackColor = false;
            // 
            // rbJPRomaji
            // 
            this.rbJPRomaji.AutoSize = true;
            this.rbJPRomaji.BackColor = System.Drawing.Color.Transparent;
            this.rbJPRomaji.Checked = true;
            this.rbJPRomaji.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.rbJPRomaji.Location = new System.Drawing.Point(27, 19);
            this.rbJPRomaji.Name = "rbJPRomaji";
            this.rbJPRomaji.Size = new System.Drawing.Size(98, 17);
            this.rbJPRomaji.TabIndex = 10;
            this.rbJPRomaji.TabStop = true;
            this.rbJPRomaji.Text = "Romaji - default";
            this.rbJPRomaji.UseVisualStyleBackColor = false;
            // 
            // rbJPBoth
            // 
            this.rbJPBoth.AutoSize = true;
            this.rbJPBoth.BackColor = System.Drawing.Color.Transparent;
            this.rbJPBoth.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.rbJPBoth.Location = new System.Drawing.Point(27, 65);
            this.rbJPBoth.Name = "rbJPBoth";
            this.rbJPBoth.Size = new System.Drawing.Size(47, 17);
            this.rbJPBoth.TabIndex = 12;
            this.rbJPBoth.Text = "Both";
            this.rbJPBoth.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbJPRomaji);
            this.groupBox1.Controls.Add(this.rbJPBoth);
            this.groupBox1.Controls.Add(this.rbJPHiragana);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.groupBox1.Location = new System.Drawing.Point(28, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 86);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Show question in:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbERomaji);
            this.groupBox2.Controls.Add(this.rbEHiragana);
            this.groupBox2.Enabled = false;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.groupBox2.Location = new System.Drawing.Point(28, 189);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 64);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Answer in:";
            // 
            // rbERomaji
            // 
            this.rbERomaji.AutoSize = true;
            this.rbERomaji.BackColor = System.Drawing.Color.Transparent;
            this.rbERomaji.Checked = true;
            this.rbERomaji.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.rbERomaji.Location = new System.Drawing.Point(27, 19);
            this.rbERomaji.Name = "rbERomaji";
            this.rbERomaji.Size = new System.Drawing.Size(98, 17);
            this.rbERomaji.TabIndex = 10;
            this.rbERomaji.TabStop = true;
            this.rbERomaji.Text = "Romaji - default";
            this.rbERomaji.UseVisualStyleBackColor = false;
            // 
            // rbEHiragana
            // 
            this.rbEHiragana.AutoSize = true;
            this.rbEHiragana.BackColor = System.Drawing.Color.Transparent;
            this.rbEHiragana.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.rbEHiragana.Location = new System.Drawing.Point(27, 42);
            this.rbEHiragana.Name = "rbEHiragana";
            this.rbEHiragana.Size = new System.Drawing.Size(68, 17);
            this.rbEHiragana.TabIndex = 11;
            this.rbEHiragana.Text = "Hiragana";
            this.rbEHiragana.UseVisualStyleBackColor = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbJapanese);
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Controls.Add(this.rbEnglish);
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.groupBox3.Location = new System.Drawing.Point(12, 14);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(336, 259);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Settings";
            // 
            // cmdAccept
            // 
            this.cmdAccept.Location = new System.Drawing.Point(18, 279);
            this.cmdAccept.Name = "cmdAccept";
            this.cmdAccept.Size = new System.Drawing.Size(75, 23);
            this.cmdAccept.TabIndex = 17;
            this.cmdAccept.Text = "Accept";
            this.cmdAccept.UseVisualStyleBackColor = true;
            this.cmdAccept.Click += new System.EventHandler(this.cmdAccept_Click);
            // 
            // cmdCancel
            // 
            this.cmdCancel.Location = new System.Drawing.Point(269, 279);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(75, 23);
            this.cmdCancel.TabIndex = 18;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 307);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdAccept);
            this.Controls.Add(this.groupBox3);
            this.Name = "frmSettings";
            this.Text = "Settings";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rbJapanese;
        private System.Windows.Forms.RadioButton rbEnglish;
        private System.Windows.Forms.RadioButton rbJPHiragana;
        private System.Windows.Forms.RadioButton rbJPRomaji;
        private System.Windows.Forms.RadioButton rbJPBoth;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbERomaji;
        private System.Windows.Forms.RadioButton rbEHiragana;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button cmdAccept;
        private System.Windows.Forms.Button cmdCancel;
    }
}