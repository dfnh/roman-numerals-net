using System;
using System.Windows.Forms;

namespace roman_numerals_net.Forms
{
    public partial class HelpForm : Form
    {
        public HelpForm()
        {
            InitializeComponent();
            CancelButton = button1;

            HelpButton = true;
            HelpButtonClicked += (s, e) =>
            {
                Ext.Cmd(" start \"\" \"https://en.wikipedia.org/wiki/Roman_numerals\" ");
                e.Cancel = true;
            };
        }

        void button1_Click(object s, EventArgs e)
        {
            this.Close();
        }
    }
}