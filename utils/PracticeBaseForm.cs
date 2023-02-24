using System;
using System.ComponentModel;
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

        protected void HelpButtonHelper(CancelEventArgs e, string str)
        {
            e.Cancel = true;
            if (currentNumber <= 0) return;

            MessageBox.Show(str, "Clarification", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        protected void SetMainTextBox(TextBox textBox_main, string romanStr = "", Color? color = null)
        {
            textBox_main.Text = romanStr;
            textBox_main.ForeColor = color ?? Black;
        }

        protected void ClearColors(TextBox textBox_main, Label label_message)
        {
            SetMainTextBox(textBox_main, textBox_main.Text);
            SetHelperMessage(label_message);
        }

        protected void AnswerIsRight(TextBox textBox_main, Label label_message, Button btn_check, Label label_score)
        {
            SetMainTextBox(textBox_main, textBox_main.Text, Green);
            SetHelperMessage(label_message, "Congratulations!", Green);

            DisableAllAfterIsRight(textBox_main, btn_check);
            AddScore(label_score);
        }

        protected void DisableAllAfterIsRight(TextBox textBox_main, Button btn_check)
        {
            btn_check.Enabled = false;
            textBox_main.Enabled = false;
        }

        protected void AnswerIsPartlyRight(TextBox textBox_main, Label label_message)
        {
            SetMainTextBox(textBox_main, textBox_main.Text, Yellow);
            SetHelperMessage(label_message, "Almost! Now you need to format it correctly ", Yellow);
        }

        protected void AnswerIsWrong(TextBox textBox_main, Label label_message)
        {
            SetMainTextBox(textBox_main, textBox_main.Text, Red);
            SetHelperMessage(label_message, "Try again", Red);
        }

        protected void AnswerWithError(TextBox textBox_main, Label label_message, string error = "error")
        {
            SetMainTextBox(textBox_main, textBox_main.Text, Purple);
            SetHelperMessage(label_message, error, Purple);
        }

        protected virtual void SetNewNumber(Label label_main, int number)
        {
            currentNumber = number;
            label_main.Text = currentNumber.ToString();
        }

        protected virtual void GetNext(Label label_main, TextBox textBox_main, Label label_message, Button btn_check)
        {
            SetNewNumber(label_main, GenerateNewNumber());
            ClearColors(textBox_main, label_message);

            EnableAllAfterGetNext(textBox_main, btn_check);
        }

        protected void EnableAllAfterGetNext(TextBox textBox_main, Button btn_check)
        {
            textBox_main.Enabled = true;
            btn_check.Enabled = true;
            textBox_main.Focus();
        }

        protected virtual void CheckInput(TextBox textBox_main, Label label_message, Button btn_check, Label label_score)
        {
            string romanStr = textBox_main.Text.ToUpper().Replace(" ", "");

            var (success, number, errorMessage) = RomanNumerals.ToIntSafe(romanStr);

            if (!success)
            {
                AnswerWithError(textBox_main, label_message, errorMessage);
                return;
            }

            if (currentNumber != number)
            {
                AnswerIsWrong(textBox_main, label_message);
                return;
            }

            string correctRoman = RomanNumerals.ToRoman(number);
            if (correctRoman != romanStr)
            {
                SetMainTextBox(textBox_main, romanStr);
                AnswerIsPartlyRight(textBox_main, label_message);
                return;
            }

            SetMainTextBox(textBox_main, romanStr);
            AnswerIsRight(textBox_main, label_message, btn_check, label_score);
        }
    }
}