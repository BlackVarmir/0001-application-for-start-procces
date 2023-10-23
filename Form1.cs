using System.Diagnostics;

namespace _0001_додаток_для_запуску_процесів
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            availableAppsListBox.Items.Add("Notepad");
            availableAppsListBox.Items.Add("control");
            availableAppsListBox.Items.Add("mspaint");
        }

        private void startbutton_Click(object sender, EventArgs e)
        {
            
            string selectedApp = availableAppsListBox.SelectedItem as string;

            if (!string.IsNullOrEmpty(selectedApp))
            {
                try
                {
                    Process.Start(selectedApp);

                    runningAppsListBox.Items.Add(selectedApp);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Помилка під час запуску додатка: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void stopbutton_Click(object sender, EventArgs e)
        {
            string selectedApp = runningAppsListBox.SelectedItem as string;

            if (!string.IsNullOrEmpty(selectedApp))
            {
                try
                {
                    foreach (var process in Process.GetProcessesByName(selectedApp.Replace(".exe", "")))
                    {
                        process.Kill();
                    }

                    runningAppsListBox.Items.Remove(selectedApp);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Помилка під час зупинки додатка: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}