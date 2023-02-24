using System;
using System.Windows.Forms;
using roman_numerals_net.Forms;

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
                    e.SuppressKeyPress = true; // to disable bing sound
                    ConvertNumbers(null, null);
                }
            };

            textBox_roman.KeyUp += (s, e) => { if (textBox_roman.Text.Length == 0) SetErrorLabel(); };
        }

        void SetErrorLabel(string message = "") => label_error.Text = message;

        void SetResultTxt(string result) => textBox_result.Text = result;

        void CorrectRomanTxt(int number)
        {
            textBox_roman.Text = RomanNumerals.ToRoman(number);
            textBox_roman.Select(textBox_roman.Text.Length, 0);
        }

        void Form1_Load(object s, EventArgs e)
        {
            textBox_roman.Focus();
        }

        void ConvertNumbers(object s, EventArgs e)
        {
            // converting
            string romanStr = textBox_roman.Text.ToUpper().Replace(" ", "");

            var (success, number, errorMessage) = RomanNumerals.ToIntSafe(romanStr);

            if (!success)
            {
                SetErrorLabel(errorMessage);
                SetResultTxt("0");
                return;
            }

            SetErrorLabel();
            SetResultTxt(number.ToString());
            CorrectRomanTxt(number);
        }

        void helpToolStripMenuItem_Click(object s, EventArgs e)
        {
            Ext.OpenOnlyOneForm<HelpForm>();
        }

        void PracticeToRoman(object sender, EventArgs e)
        {
            Ext.OpenOnlyOneForm<PracticeToRomanForm>();
        }

        void PracticeToArabic(object sender, EventArgs e)
        {
            Ext.OpenOnlyOneForm<PracticeToArabicForm>();
        }
    }
}