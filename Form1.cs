using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Translator
{
    public partial class Form1 : Form
    {
        YandexTranslator yt;

        public Form1()
        {
            InitializeComponent();

            yt = new YandexTranslator();
        }

        private void translateButton_Click(object sender, EventArgs e)
        {
            string lang;

            if (radioButton1.Checked == true)
            {
                lang = "ru-en";
            }
            else
            {
                lang = "en-ru";
            }

            textBox2.Text = yt.Translate(textBox1.Text, lang);
        }

        private void linkLabel1_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                VisitLink();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to open link that was clicked.");
            }
        }
        private void VisitLink()
        {
            // Change the color of the link text by setting LinkVisited
            // to true.
            linkLabel1.LinkVisited = true;
            //Call the Process.Start method to open the default browser
            //with a URL:
            System.Diagnostics.Process.Start("https://github.com/Max-Sir");
        }
    }
}