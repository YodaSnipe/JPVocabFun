using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace JPVocabFun
{
    public partial class frmSettings : Form
    {
        bool jpQuestion = Properties.Settings.Default.jpQuestion;
        bool jpRomaji = Properties.Settings.Default.jpRomaji;
        bool jpHiragana = Properties.Settings.Default.jpHiragana;
        bool engQuestion = Properties.Settings.Default.engQuestion;
        bool engRomaji = Properties.Settings.Default.engRomaji;
        bool engHiragana = Properties.Settings.Default.engHiragana;
        JPVocabFunForm JPVocabFunForm = null;

        public frmSettings(JPVocabFunForm JPVocabFunForm)
        {
            InitializeComponent();
            userSettings();
            this.FormClosed += new FormClosedEventHandler(frmSettings_FormClosed);
            this.JPVocabFunForm = JPVocabFunForm;
        }

        void frmSettings_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.Save();
            this.JPVocabFunForm.display(JPVocabFunForm.getQuestion());
        }

        private void userSettings()
        {
            //Japanese question
            if (jpQuestion)
            {
                rbJapanese.Checked = true;
                //Both
                if (jpRomaji && jpHiragana)
                {
                    rbJPRomaji.Checked = true;
                }
                //Romaji
                else if (jpRomaji)
                {
                    rbJPRomaji.Checked = true;
                }
                //Hiragana
                else if (jpHiragana)
                {
                    rbJPHiragana.Checked = true;
                }
            }
            //English question
            else if (engQuestion)
            {
                rbEnglish.Checked = true;
                //Romaji
                if (engRomaji)
                {
                    rbERomaji.Checked = true;
                }
                //Hiragana
                else if (engHiragana)
                {
                    rbEHiragana.Checked = true;
                }
            }
        }

        private void rbJapanese_CheckedChanged(object sender, EventArgs e)
        {
            if (rbEnglish.Checked)
            {
                groupBox1.Enabled = false;
                groupBox2.Enabled = true;
            }
        }

        private void rbEnglish_CheckedChanged(object sender, EventArgs e)
        {
            if (rbJapanese.Checked)
            {
                groupBox2.Enabled = false;
                groupBox1.Enabled = true;
            }
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdAccept_Click(object sender, EventArgs e)
        {
            //Japanese question
            if (rbJapanese.Checked)
            {
                Properties.Settings.Default.jpQuestion = true;
                Properties.Settings.Default.engQuestion = false;
                //Both
                if (rbJPBoth.Checked)
                {
                    Properties.Settings.Default.jpRomaji = true;
                    Properties.Settings.Default.jpHiragana = true;
                }
                //Romaji
                else if (rbJPRomaji.Checked)
                {
                    Properties.Settings.Default.jpRomaji = true;
                    Properties.Settings.Default.jpHiragana = false;
                }
                //Hiragana
                else if (rbJPHiragana.Checked)
                {
                    Properties.Settings.Default.jpHiragana = true;
                    Properties.Settings.Default.jpRomaji = false;
                }
            }
            //English question
            else if (rbEnglish.Checked)
            {
                Properties.Settings.Default.engQuestion = true;
                Properties.Settings.Default.jpQuestion = false;
                //Romaji
                if (rbERomaji.Checked)
                {
                    Properties.Settings.Default.engRomaji = true;
                    Properties.Settings.Default.engHiragana = false;
                }
                //Hiragana
                else if (rbEHiragana.Checked)
                {
                    Properties.Settings.Default.engHiragana = true;
                    Properties.Settings.Default.engRomaji = false;
                }
            }
            //this.JPVocabFunForm.display(JPVocabFunForm.getQuestion());
            this.Close();
        }
    }
}
