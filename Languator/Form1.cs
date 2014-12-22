using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Languator
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Dictionary with the words in (English, Polski)
        /// </summary>
        private Dictionary<string, string> trans = new Dictionary<string, string>();
        /// <summary>
        /// Array with the strings of the easter eggs.
        /// </summary>
        private String[] easter = new String[6] {"Vas happenin'?", "Hello", "Cześć", "Zayn rules", "Zaynlator", "Languator by Zayn"};
        
        public Form1()
        {
            InitializeComponent();
            // Start the dicts
            InitializeDictionary();
        }

        private string getEasterEgg()
        {
            Random rnd = new Random();
            string[] easterTemp = easter.OrderBy(x => rnd.Next()).ToArray();
            if (helloLabel.Text != easterTemp[0])
            {
                return easterTemp[0];
            }
            else
            {
                return easterTemp[1];
            }
        }

        /// <summary>
        /// Initialize the dictionaries. Add here new translations.
        /// </summary>
        private void InitializeDictionary()
        {
            #region Translations (add yours here)

            #region Greetings (built-in)
            trans.Add("hello", "cześć");
            trans.Add("bye", "cześć");
            trans.Add("goodbye", "da widzanie");
            trans.Add("good morning", "dzień dobry");
            trans.Add("good evening", "dobry wieczór");
            trans.Add("good night", "dobranoc");
            #endregion

            #region Simple phrases (built-in)
            trans.Add("my name is", "mam na imię...");
            trans.Add("my name is...", "mam na imię...");
            trans.Add("you're very attractive", "bardzo mi się podobasz");
            trans.Add("i love you", "kocham Cię");
            trans.Add("i don't understand", "nie rozumiem");
            trans.Add("what's your name?", "jak masz na imię?");
            trans.Add("nice to meet you", "miło mi cię poznać");
            trans.Add("how old are you?", "ile masz ma lat?");
            trans.Add("good", "dobrze");
            trans.Add("bad", "źle");
            trans.Add("whore", "kurwa");
            trans.Add("bitch", "kurwa");
            trans.Add("fuck", "kurwa");
            trans.Add("asshole", "dupek");
            trans.Add("fuck off", "spierdalaj");
            trans.Add("gay", "cwel");
            trans.Add("queer", "cwel");
            trans.Add("faggot", "cwel");
            trans.Add("shit", "gowno");
            #endregion

            #region Pronouns (nominative) (built-in)
            trans.Add("i", "ja");
            trans.Add("you", "ty, wy (pl.)");
            trans.Add("he", "on");
            trans.Add("she", "ona");
            trans.Add("it", "ono");
            trans.Add("we", "my");
            trans.Add("you (plural", "wy");
            trans.Add("they", "oni (at least one male), one (no male)");
            #endregion

            #region Grammar (built-in)
            trans.Add("nominative", "mianownik");
            trans.Add("genitive", "dopełniacz");
            trans.Add("dative", "celownik");
            trans.Add("accusative", "biernik");
            trans.Add("instrumental", "narzędnik");
            trans.Add("locative", "miejscownik");
            trans.Add("vocative", "wołacz");
            #endregion

            /*
             * Insert custom translations below. Please, follow the pattern.
             * Template: trans.Add("english word/phrase", "polish word/phrase");
             * IMPORTANT: Use lowercase!
             */

            #region Custom (add here!)
            trans.Add("example", "przykład");
            #endregion
            #endregion
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
                        matches.Add(char.ToUpper(pair.Key[0]) + pair.Key.Substring(1));
                    }
                }
                String allthematches = String.Join(", ", matches.ToArray());
                textEnglish.Text = allthematches;
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
                textPolski.Text = char.ToUpper(trans[text][0]) + trans[text].Substring(1);
            }
            else
            {
                MessageBox.Show("Translation not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mainPicture_Click(object sender, EventArgs e)
        {
            /*MessageBox.Show("This program has been develop by the Zayn Malik lovers team in Joska's heart.",
                            "Vas happenin?", MessageBoxButtons.OK, MessageBoxIcon.Information);*/
            // Change the picture
            if ((string)mainPicture.Tag == "resumé")
            {
                mainPicture.Image = Languator.Properties.Resources.kate_moss_nude;
                mainPicture.Tag = "kate_moss_nude";
            }
            else
            {
                mainPicture.Image = Languator.Properties.Resources.resumé;
                mainPicture.Tag = "resumé";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textEnglish.Text != "" && textPolski.Text != "")
            {
                MessageBox.Show("Please, void one of both textboxes.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textEnglish.Text == "" && textPolski.Text != "")
            {
                translatePolskiEnglish(textPolski.Text.ToLower());
            }
            else if (textPolski.Text == "" && textEnglish.Text != "")
            {
                translateEnglishPolski(textEnglish.Text.ToLower());
            }
            else
            {
                MessageBox.Show("You must write something in either one of both textboxes!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void labelEnglish_Click(object sender, EventArgs e)
        {
            textEnglish.Text = "";
        }

        private void labelPolski_Click(object sender, EventArgs e)
        {
            textPolski.Text = "";
        }

        private void helloLabel_Click(object sender, EventArgs e)
        {
            helloLabel.Text = getEasterEgg();
        }

        private void aboutLanguatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 ab = new AboutBox1();
            ab.Show();
        }


        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }





    }
}
