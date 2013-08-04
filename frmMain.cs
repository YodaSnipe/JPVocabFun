using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Data.SqlClient;

namespace JPVocabFun
{
    public partial class JPVocabFunForm : Form
    {
        #region Global Variables
        string answer = null;
        ArrayList JWords = new ArrayList();
        ArrayList EWords = new ArrayList();
        ArrayList JWordsHiragana = new ArrayList();
        string VocabOptions = "[あ]%";
        int length = 0;
        #endregion

        #region Main
        public JPVocabFunForm()
        {
            InitializeComponent();
            getAllQuestions(VocabOptions);
            display(getQuestion());
            txtAnswer.Focus();
        }
        #endregion

        #region Populate Arrays
        //get all questions
        public void getAllQuestions(string VocabOptions)
        {
            JWords = new ArrayList();
            EWords = new ArrayList();
            JWordsHiragana = new ArrayList();
            //get all words
            string connStr = "Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\JPVocabFun\\JPVocabFun\\JWordDB.mdf;Integrated Security=True;User Instance=True";
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection(connStr);
                conn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                
                cmd.CommandText = "SELECT * FROM [JWordTB] WHERE [Hiragana] LIKE '" + VocabOptions + "' ORDER BY [Hiragana] ASC";

                //bind and display
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    //Japanese Word
                    string JWord = dr.GetString(1);

                    //English Word
                    string EWord = dr.GetString(2);

                    //Japanese Hiragana
                    string JWordHiragana = dr.GetString(3);

                    JWords.Add(JWord);
                    EWords.Add(EWord);
                    JWordsHiragana.Add(JWordHiragana);
                }

                dr.Close();
                conn.Close();

                length = JWords.Count;
            }
            catch (SqlException ex)
            {
                if (conn != null)
                {
                    conn.Close();
                }
                lblIncorrect.Text = ex.Message;
            }
        }
        #endregion

        #region Menu Bar
        //settings form
        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create a new instance of the SettingsForm class
            frmSettings settingsForm = new frmSettings(this);

            // Show the settings form
            settingsForm.ShowDialog();
        }

        private void setVocabularyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create a new instance of the Vocabulary Options class
            frmVocab vocabForm = new frmVocab(this, VocabOptions);

            // Show the Vocabulary form
            vocabForm.ShowDialog();
        }

        //exit program
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Answer Submission
        //submit answer
        private void txtAnswer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                submitAnswer();
            }
        }

        //submit answer
        private void cmdEnter_Click(object sender, EventArgs e)
        {
            submitAnswer();
        }

        //submits answer for checking
        private void submitAnswer()
        {
            if (txtAnswer.Text == "")
            {
                display(getQuestion());
                lblIncorrect.Visible = false;
            }
            else if (txtAnswer.Text.ToLower() == answer.ToLower())
            {
                display(getQuestion());
                txtAnswer.Text = "";
                lblIncorrect.Visible = false;
                lblCorrectCount.Text = (Convert.ToInt32(lblCorrectCount.Text) + 1).ToString();
            }
            else
            {
                lblIncorrect.Visible = true;
                lblIncorrectCount.Text = (Convert.ToInt32(lblIncorrectCount.Text) + 1).ToString();
            }
            txtAnswer.Focus();
        }
        #endregion

        #region Display Next Question
        //display question and determine answer given settings
        public void display(int index)
        {
            bool jpQuestion = Properties.Settings.Default.jpQuestion;
            bool jpRomaji = Properties.Settings.Default.jpRomaji;
            bool jpHiragana = Properties.Settings.Default.jpHiragana;
            bool engQuestion = Properties.Settings.Default.engQuestion;
            bool engRomaji = Properties.Settings.Default.engRomaji;
            bool engHiragana = Properties.Settings.Default.engHiragana;
            //Japanese question
            if (jpQuestion)
            {
                answer = EWords[index].ToString();
                //Both
                if (jpRomaji && jpHiragana)
                {
                    lblQuestion.Text = JWords[index].ToString() + " - " + JWordsHiragana[index].ToString();
                }
                //Romaji
                else if (jpRomaji)
                {
                    lblQuestion.Text = JWords[index].ToString();
                }
                //Hiragana
                else if (jpHiragana)
                {
                    lblQuestion.Text = JWordsHiragana[index].ToString();
                }
            }
            //English question
            else if (engQuestion)
            {
                lblQuestion.Text = EWords[index].ToString();
                //Romaji
                if (engRomaji)
                {
                    answer = JWords[index].ToString();
                }
                //Hiragana
                else if (engHiragana)
                {
                    answer = JWordsHiragana[index].ToString();
                }
            }
        }

        //get a word and display as question
        public int getQuestion()
        {
            Random random = new Random();
            int index = random.Next(0, length);
            return index;
        }
        #endregion
    }
}