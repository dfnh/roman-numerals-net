using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using roman_numerals_net.utils;

namespace roman_numerals_net.Forms
{
    public partial class PracticeToArabicForm : PracticeBaseForm
    {
        public PracticeToArabicForm()
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
                if (currentNumber > 0)
                {
                    MessageBox.Show($"{RomanNumerals.Clarify(currentNumber, true)}",
                        "Clarification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                e.Cancel = true;
            };
        }

        void ClearColors()
        {
            ClearColors(textBox_arabic, label_message);
        }

        void PracticeToArabicForm_Load(object sender, EventArgs e)
        {
            GetNext(null, null);
        }

        void GetNext(object sender, EventArgs e)
        {
            GetNext(label_number, textBox_arabic, label_message, btn_check);
        }

        protected override void SetNewNumber(Label label_number, int number)
        {
            currentNumber = number;
            label_number.Text = RomanNumerals.ToRoman(number);
        }

        void CheckInput(object sender, EventArgs e)
        {
            string arabicStr = textBox_arabic.Text.ToUpper().Replace(" ", "");

            if (!int.TryParse(arabicStr, out int arabic))
            {
                AnswerWithError(textBox_arabic, label_message, "Number must be int");
                return;
            }
            if (arabic != currentNumber)
            {
                AnswerIsWrong(textBox_arabic, label_message);
                return;
            }

            AnswerIsRight(textBox_arabic, label_message, btn_check, label_score);
        }
    }
}