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

        private readonly int min = 1;
        private readonly int max = 4000;
        private readonly Random rng = new Random();
        private readonly Color Black = Color.FromArgb(15, 23, 42);
        private readonly Color Red = Color.FromArgb(225, 29, 72);
        private readonly Color Yellow = Color.FromArgb(217, 119, 6);
        private readonly Color Green = Color.FromArgb(101, 163, 13);
        private readonly Color Purple = Color.FromArgb(192, 38, 211);

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
            label_message.ForeColor = color ?? Black;
            label_message.Text = message;
        }

        void SetRomanTxt(string romanStr = "", Color? color = null)
        {
            textBox_roman.Text = romanStr;
            textBox_roman.ForeColor = color ?? Black;
        }

        void ResetRoman()
        {
            SetRomanTxt(textBox_roman.Text);
            SetHelperMessage();
        }

        void AnswerIsRight()
        {
            SetRomanTxt(textBox_roman.Text, Green);
            SetHelperMessage("Congratulations!", Green);

            btn_check.Enabled = false;
            textBox_roman.Enabled = false;
            AddScore();
        }

        void AnswerIsPartlyRight()
        {
            SetRomanTxt(textBox_roman.Text, Yellow);
            SetHelperMessage("Almost! Now you need to format it correctly ", Yellow);
        }

        void AnswerIsWrong()
        {
            SetRomanTxt(textBox_roman.Text, Red);
            SetHelperMessage("Try again", Red);
        }

        void AnswerWithError(string error = "error")
        {
            SetRomanTxt(textBox_roman.Text, Purple);
            SetHelperMessage(error, Purple);
        }

        void SetNewNumber(int number)
        {
            currentNumber = number;
            label_number.Text = currentNumber.ToString();
        }

        void PracticeForm_Load(object s, EventArgs e)
        {
            GetNext(null, null);
        }

        void GetNext(object s, EventArgs e)
        {
            SetNewNumber(GenerateNewNumber());
            ResetRoman();

            textBox_roman.Enabled = true;
            btn_check.Enabled = true;
            textBox_roman.Focus();
        }

        void CheckInput(object s, EventArgs e)
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