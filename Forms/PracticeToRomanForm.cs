using System;
using System.Drawing;
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
                ResetRoman();
                if (e.KeyValue == (char)Keys.Enter)
                {
                    e.SuppressKeyPress = true; // to disable bing sound
                    CheckInput(null, null);
                }
            };

            HelpButton = true;
            HelpButtonClicked += (s, e) =>
            {
                HelpButtonHelper(e, $"{currentNumber} = {RomanNumerals.Clarify(currentNumber)}");
            };
        }

        int AddScore()
        {
            return AddScore(label_score);
        }

        void SetHelperMessage(string message = "", Color? color = null)
        {
            SetHelperMessage(label_message, message, color);
        }

        void SetRomanTxt(string romanStr = "", Color? color = null)
        {
            SetMainTextBox(textBox_roman, romanStr, color);
        }

        void ResetRoman()
        {
            ClearColors(textBox_roman, label_message);
        }

        void AnswerIsRight()
        {
            AnswerIsRight(textBox_roman, label_message, btn_check, label_score);
        }

        void AnswerIsPartlyRight()
        {
            AnswerIsPartlyRight(textBox_roman, label_message);
        }

        void AnswerIsWrong()
        {
            AnswerIsWrong(textBox_roman, label_message);
        }

        void AnswerWithError(string error = "error")
        {
            AnswerWithError(textBox_roman, label_message, error);
        }

        void SetNewNumber(int number)
        {
            SetNewNumber(label_number, number);
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