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
        }

        private void PracticeToArabicForm_Load(object sender, EventArgs e)
        {
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
        }

        private void btn_check_Click(object sender, EventArgs e)
        {
        }
    }
}