using System;
using System.Windows.Forms;

namespace roman_numerals_net.Forms
{
    public partial class HelpForm : Form
    {
        public HelpForm()
        {
            InitializeComponent();
            CancelButton = btn_close;

            HelpButton = true;
            HelpButtonClicked += (s, e) =>
            {
                Ext.Cmd(" start \"\" \"https://en.wikipedia.org/wiki/Roman_numerals\" ");
                e.Cancel = true;
            };
        }

        void CloseForm(object s, EventArgs e)
        {
            this.Close();
        }
    }
}