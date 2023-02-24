using System;
using System.Windows.Forms;
using roman_numerals_net.utils;

namespace roman_numerals_net.Forms
{
    public partial class PracticeToRomanForm : PracticeBaseForm
    {
        public PracticeToRomanForm()
        {
            InitializeComponent();

            label_score.Text = "0";
            label_number.Text = "";
            label_message.Text = "";

            CreateExitButton(this);

            KeyPreview = true;
            KeyDown += (s, e) =>
            {
                ClearColors();
                if (e.KeyValue == (char)Keys.Enter)
                {
                    e.SuppressKeyPress = true; // to disable bing sound
                    CheckInput(null, null);
                }
            };

            HelpButton = true;
            HelpButtonClicked += (s, e) =>
            {
                HelpButtonHelper(e, RomanNumerals.Clarify(currentNumber, false));
            };
        }

        void ClearColors()
        {
            ClearColors(textBox_roman, label_message);
        }

        void PracticeForm_Load(object s, EventArgs e)
        {
            GetNext(null, null);
        }

        void GetNext(object s, EventArgs e)
        {
            GetNext(label_number, textBox_roman, label_message, btn_check);
        }

        void CheckInput(object s, EventArgs e)
        {
            CheckInput(textBox_roman, label_message, btn_check, label_score);
        }
    }
}