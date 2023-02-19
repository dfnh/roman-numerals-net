using System;
using System.Drawing;
using System.Windows.Forms;

namespace roman_numerals_net.Forms
{
    public partial class PracticeForm : Form
    {
        public PracticeForm()
        {
            InitializeComponent();

            label_score.Text = "0";
            label_number.Text = "";
            label_message.Text = "";

            #region exit button

            Button btn_exit = new Button() { Size = new Size(0, 0), TabStop = false };
            btn_exit.Click += (s, e) => Close();
            Controls.Add(btn_exit);
            CancelButton = btn_exit;

            #endregion exit button

            KeyPreview = true;
            KeyDown += (s, e) =>
            {
                ResetRoman();
                if (e.KeyValue == (char)Keys.Enter)
                {
                    e.SuppressKeyPress = true; // to disable bing sound
                    btn_check.PerformClick();
                }
            };
        }

        private readonly int min = 1;
        private readonly int max = 4000;
        private readonly Random rng = new Random();

        private int currentNumber = 0;
        private int score = 0;

        int GenerateNewNumber() => rng.Next(min, max);

        int AddScore()
        {
            score++;
            label_score.Text = $"{score}";
            return score;
        }

        void SetHelperMessage(string message = "", Color? color = null)
        {
            label_message.ForeColor = color ?? Color.Blue;
            label_message.Text = message;
        }

        void SetRomanTxt(string romanStr = "", Color? color = null)
        {
            textBox_roman.Text = romanStr;
            textBox_roman.ForeColor = color ?? Color.Black;
        }

        void ResetRoman()
        {
            SetRomanTxt(textBox_roman.Text);
            SetHelperMessage();
        }

        void AnswerIsRight()
        {
            SetRomanTxt(textBox_roman.Text, Color.ForestGreen);
            SetHelperMessage("Congratulations!", Color.ForestGreen);

            btn_check.Enabled = false;
            textBox_roman.Enabled = false;
            AddScore();
        }

        void AnswerIsPartlyRight()
        {
            SetRomanTxt(textBox_roman.Text, Color.Olive);
            SetHelperMessage("Almost! Now you need to format it correctly ", Color.Olive);
        }

        void AnswerIsWrong()
        {
            SetRomanTxt(textBox_roman.Text, Color.Red);
            SetHelperMessage("Try again", Color.Red);
        }

        void AnswerWithError(string error = "error")
        {
            SetRomanTxt(textBox_roman.Text, Color.MediumVioletRed);
            SetHelperMessage(error, Color.MediumVioletRed);
        }

        void SetNewNumber(int number)
        {
            currentNumber = number;
            label_number.Text = currentNumber.ToString();
        }

        void PracticeForm_Load(object s, EventArgs e)
        {
            btn_next.PerformClick();
        }

        void btn_next_Click(object s, EventArgs e)
        {
            SetNewNumber(GenerateNewNumber());
            ResetRoman();

            textBox_roman.Enabled = true;
            btn_check.Enabled = true;
            textBox_roman.Focus();
        }

        void btn_check_Click(object s, EventArgs e)
        {
            string romanStr = textBox_roman.Text.ToUpper().Replace(" ", "");

            var (success, number, errorMessage) = RomanNumerals.ToIntSafe(romanStr);

            if (!success)
            {
                AnswerWithError(errorMessage);
                return;
            }

            if (currentNumber != number)
            {
                AnswerIsWrong();
                return;
            }

            string correctRoman = RomanNumerals.ToRoman(number);
            if (correctRoman != romanStr)
            {
                SetRomanTxt(romanStr);
                AnswerIsPartlyRight();
                return;
            }

            SetRomanTxt(romanStr);
            AnswerIsRight();
        }
    }
}