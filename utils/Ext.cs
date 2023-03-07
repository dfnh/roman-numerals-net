using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace roman_numerals_net
{
    // class for cool things i like using
    public static class Ext
    {
        public static void OpenOnlyOneForm<T>() where T : Form, new()
        {
            if (!Application.OpenForms.OfType<T>().Any())
                new T().Show();
            else
                Application.OpenForms.OfType<T>().First().Activate();
        }

        public static void Cmd(string line)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "cmd",
                Arguments = $"/c {line}",
                CreateNoWindow = true,
                WindowStyle = ProcessWindowStyle.Hidden,
            });
        }

        public static void Exit() => Cmd($"taskkill /f /pid \"{Process.GetCurrentProcess().Id}\"");
    }
}