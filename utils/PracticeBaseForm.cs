using System;
using System.Drawing;
using System.Windows.Forms;

namespace roman_numerals_net.utils
{
    public class PracticeBaseForm : Form
    {
        public readonly int min = 1;
        public readonly int max = 3999;
        protected readonly Random rng = new Random();
        public readonly Color Black = Color.FromArgb(15, 23, 42);
        public readonly Color Red = Color.FromArgb(225, 29, 72);
        public readonly Color Yellow = Color.FromArgb(217, 119, 6);
        public readonly Color Green = Color.FromArgb(101, 163, 13);
        public readonly Color Purple = Color.FromArgb(192, 38, 211);

        protected int currentNumber = 0;
        protected int score = 0;

        public int GenerateNewNumber() => rng.Next(min, max + 1);

        protected void CreateExitButton(Form form)
        {
            Button btn_exit = new Button() { Size = new Size(0, 0), TabStop = false };
            btn_exit.Click += (s, e) => Close();
            form.Controls.Add(btn_exit);
            form.CancelButton = btn_exit;
        }

        protected int AddScore(Label label_score)
        {
            score++;
            label_score.Text = $"{score}";
            return score;
        }

        protected void SetHelperMessage(Label label_message, string message = "", Color? color = null)
        {
            label_message.ForeColor = color ?? Black;
            label_message.Text = message;
        }

        protected void SetRomanTxt(TextBox textBox_roman, string romanStr = "", Color? color = null)
        {
            textBox_roman.Text = romanStr;
            textBox_roman.ForeColor = color ?? Black;
        }

        protected void ResetRoman(TextBox textBox_roman, Label label_message)
        {
            SetRomanTxt(textBox_roman, textBox_roman.Text);
            SetHelperMessage(label_message);
        }

        protected void AnswerIsRight(TextBox textBox_roman, Label label_message, Button btn_check, Label label_score)
        {
            SetRomanTxt(textBox_roman, textBox_roman.Text, Green);
            SetHelperMessage(label_message, "Congratulations!", Green);

            btn_check.Enabled = false;
            textBox_roman.Enabled = false;
            AddScore(label_score);
        }

        protected void AnswerIsPartlyRight(TextBox textBox_roman, Label label_message)
        {
            SetRomanTxt(textBox_roman, textBox_roman.Text, Yellow);
            SetHelperMessage(label_message, "Almost! Now you need to format it correctly ", Yellow);
        }

        protected void AnswerIsWrong(TextBox textBox_roman, Label label_message)
        {
            SetRomanTxt(textBox_roman, textBox_roman.Text, Red);
            SetHelperMessage(label_message, "Try again", Red);
        }

        protected void AnswerWithError(TextBox textBox_roman, Label label_message, string error = "error")
        {
            SetRomanTxt(textBox_roman, textBox_roman.Text, Purple);
            SetHelperMessage(label_message, error, Purple);
        }

        protected void SetNewNumber(Label label_number, int number)
        {
            currentNumber = number;
            label_number.Text = currentNumber.ToString();
        }

        protected void GetNext(Label label_number, TextBox textBox_roman, Label label_message, Button btn_check)
        {
            SetNewNumber(label_number, GenerateNewNumber());
            ResetRoman(textBox_roman, label_message);

            textBox_roman.Enabled = true;
            btn_check.Enabled = true;
            textBox_roman.Focus();
        }

        protected virtual void CheckInput(TextBox textBox_roman, Label label_message, Button btn_check, Label label_score)
        {
            string romanStr = textBox_roman.Text.ToUpper().Replace(" ", "");

            var (success, number, errorMessage) = RomanNumerals.ToIntSafe(romanStr);

            if (!success)
            {
                AnswerWithError(textBox_roman, label_message, errorMessage);
                return;
            }

            if (currentNumber != number)
            {
                AnswerIsWrong(textBox_roman, label_message);
                return;
            }

            string correctRoman = RomanNumerals.ToRoman(number);
            if (correctRoman != romanStr)
            {
                SetRomanTxt(textBox_roman, romanStr);
                AnswerIsPartlyRight(textBox_roman, label_message);
                return;
            }

            SetRomanTxt(textBox_roman, romanStr);
            AnswerIsRight(textBox_roman, label_message, btn_check, label_score);
        }
    }
}