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
                if (currentNumber > 0)
                {
                    MessageBox.Show($"{currentNumber} = {RomanNumerals.Clarify(currentNumber)}",
                        "Clarification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                e.Cancel = true;
            };
        }

        protected int AddScore()
        {
            //score++;
            //label_score.Text = $"{score}";
            //return score;
            return AddScore(label_score);
        }

        protected void SetHelperMessage(string message = "", Color? color = null)
        {
            //label_message.ForeColor = color ?? Black;
            //label_message.Text = message;
            SetHelperMessage(label_message, message, color);
        }

        protected void SetRomanTxt(string romanStr = "", Color? color = null)
        {
            //textBox_roman.Text = romanStr;
            //textBox_roman.ForeColor = color ?? Black;
            SetRomanTxt(textBox_roman, romanStr, color);
        }

        protected void ResetRoman()
        {
            //SetRomanTxt(textBox_roman.Text);
            //SetHelperMessage();
            ResetRoman(textBox_roman, label_message);
        }

        protected void AnswerIsRight()
        {
            //SetRomanTxt(textBox_roman.Text, Green);
            //SetHelperMessage("Congratulations!", Green);

            //btn_check.Enabled = false;
            //textBox_roman.Enabled = false;
            //AddScore();
            AnswerIsRight(textBox_roman, label_message, btn_check, label_score);
        }

        protected void AnswerIsPartlyRight()
        {
            //SetRomanTxt(textBox_roman.Text, Yellow);
            //SetHelperMessage("Almost! Now you need to format it correctly ", Yellow);
            AnswerIsPartlyRight(textBox_roman, label_message);
        }

        protected void AnswerIsWrong()
        {
            //SetRomanTxt(textBox_roman.Text, Red);
            //SetHelperMessage("Try again", Red);
            AnswerIsWrong(textBox_roman, label_message);
        }

        protected void AnswerWithError(string error = "error")
        {
            //SetRomanTxt(textBox_roman.Text, Purple);
            //SetHelperMessage(error, Purple);
            AnswerWithError(textBox_roman, label_message, error);
        }

        protected void SetNewNumber(int number)
        {
            //currentNumber = number;
            //label_number.Text = currentNumber.ToString();
            SetNewNumber(label_number, number);
        }

        protected void PracticeForm_Load(object s, EventArgs e)
        {
            GetNext(null, null);
        }

        protected void GetNext(object s, EventArgs e)
        {
            //SetNewNumber(GenerateNewNumber());
            //ResetRoman();

            //textBox_roman.Enabled = true;
            //btn_check.Enabled = true;
            //textBox_roman.Focus();
            GetNext(label_number, textBox_roman, label_message, btn_check);
        }

        protected void CheckInput(object s, EventArgs e)
        {
            //string romanStr = textBox_roman.Text.ToUpper().Replace(" ", "");

            //var (success, number, errorMessage) = RomanNumerals.ToIntSafe(romanStr);

            //if (!success)
            //{
            //    AnswerWithError(errorMessage);
            //    return;
            //}

            //if (currentNumber != number)
            //{
            //    AnswerIsWrong();
            //    return;
            //}

            //string correctRoman = RomanNumerals.ToRoman(number);
            //if (correctRoman != romanStr)
            //{
            //    SetRomanTxt(romanStr);
            //    AnswerIsPartlyRight();
            //    return;
            //}

            //SetRomanTxt(romanStr);
            //AnswerIsRight();
            CheckInput(textBox_roman, label_message, btn_check, label_score);
        }
    }
}