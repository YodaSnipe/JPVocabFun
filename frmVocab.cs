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
    public partial class frmVocab : Form
    {
        JPVocabFunForm JPVocabFunForm = null;
        string vocab = null;
        public frmVocab(JPVocabFunForm JPVocabFunForm, string VocabOptions)
        {
            InitializeComponent();
            this.JPVocabFunForm = JPVocabFunForm;
            vocab = VocabOptions.Remove(0, 1);
            vocab = vocab.Remove(VocabOptions.Length-3, 2);
            
            CheckOptions(this);
        }

        #region Hiragana Check/Uncheck all
        //User Select all Hiragana
        private void cmdSelectAll_Click(object sender, EventArgs e)
        {
            AllChecked(this);
        }
        //User Select no Hiragana
        private void cmdSelectNone_Click(object sender, EventArgs e)
        {
            AllUnchecked(this);
        }
        //Check all CheckBoxes
        public void AllChecked(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c is CheckBox)
                {
                    ((CheckBox)c).Checked = true;
                }
            }
        }
        //Uncheck all CheckBoxes
        public void AllUnchecked(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c is CheckBox)
                {
                    ((CheckBox)c).Checked = false;
                }
            }
        }
        #endregion

        //Check the previous options
        public void CheckOptions(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c is CheckBox)
                {
                    if (vocab.Contains(((CheckBox)c).Text))
                    {
                        ((CheckBox)c).Checked = true;
                    }
                }
            }
        }

        public string removeDuplicates(string vocab)
        {
            string encountered = "";
            string result = "";

            foreach (char hiragana in vocab)
            {
                if (encountered.IndexOf(hiragana) == -1)
                {
                    encountered += hiragana;
                    result += hiragana;
                }
            }


            return result;
        }

        //Populate the vocab List with the Hiragana to practice
        public string PopulateStatus(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c is CheckBox)
                {
                    if (((CheckBox)c).Checked)
                    {
                        vocab += ((CheckBox)c).Text;
                    }
                }
            }
            return ("[" + removeDuplicates(vocab) + "]%");
        }

        //Get new list of questions
        private void cmdAccept_Click(object sender, EventArgs e)
        {
            this.JPVocabFunForm.getAllQuestions(PopulateStatus(this));
            this.Close();
        }

        //Cancelchanges
        private void cmdCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
