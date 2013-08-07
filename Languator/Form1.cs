using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Languator
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Dictionary with the words in (English, Polski)
        /// </summary>
        private Dictionary<string, string> trans = new Dictionary<string, string>();

        public Form1()
        {
            InitializeComponent();
            // Start the dicts
            InitializeDictionary();
        }

        /// <summary>
        /// Initialize the dictionaries. Add here new translations.
        /// </summary>
        private void InitializeDictionary()
        {
            // ENGLISH to POLSKI
            trans.Add("hello", "cześć");
            trans.Add("bye", "cześć");
            trans.Add("goodbye", "da widzanie");
        }
   
        private void translatePolskiEnglish(String text)
        {
            if (trans.ContainsValue(text))
            {
                List<string> matches = new List<string>();
                foreach (var pair in trans)
                {
                    if (pair.Value == text)
                    {
                        matches.Add(CultureInfo.CurrentCulture.TextInfo.ToTitleCase(pair.Key));
                    }
                }
                String allthematches = String.Join(", ", matches.ToArray());
                textBox1.Text = allthematches;
            }
            else
            {
                MessageBox.Show("Translation not found", "Error", MessageBoxButtons.OK ,MessageBoxIcon.Error);
            }
        }
        private void translateEnglishPolski(String text)
        {
            if (trans.ContainsKey(text))
            {
                textBox2.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(trans[text]);
            }
            else
            {
                MessageBox.Show("Translation not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This program has been develop by the Zayn Malik lovers team in Poland.",
                            "Vas happenin?", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                MessageBox.Show("Please, void one of both textboxes.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBox1.Text == "" && textBox2.Text != "")
            {
                translatePolskiEnglish(textBox2.Text.ToLower());
            }
            else if (textBox2.Text == "" && textBox1.Text != "")
            {
                translateEnglishPolski(textBox1.Text.ToLower());
            }
            else
            {
                MessageBox.Show("You must write something in either one of both textboxes!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
