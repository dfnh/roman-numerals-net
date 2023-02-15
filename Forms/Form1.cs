﻿using System;
using System.Linq;
using System.Windows.Forms;

namespace roman_numerals_net
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            label_error.Text = "";

            KeyPreview = true;
            KeyDown += (s, e) =>
            {
                if (e.KeyValue == (char)Keys.Enter)
                {
                    //e.Handled = true;
                    e.SuppressKeyPress = true; // to disable bing sound
                    button1.PerformClick();
                }
            };

            textBox_roman.KeyUp += (s, e) => { if (textBox_roman.Text.Length == 0) SetErrorLabel(); };
        }

        private void SetErrorLabel(string message = "") => label_error.Text = message;

        private void SetResultTxt(string result) => textBox_result.Text = result;

        private void CorrectRomanTxt(int number)
        {
            textBox_roman.Select(textBox_roman.Text.Length, 0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // converting
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void practiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
    }
}