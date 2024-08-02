using System;
using System.Collections.Generic;
using System.Net;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Psiholog
{
    public partial class loginForm : Form
    {
        private static readonly string client_version = "1.0.0.RC-1";
        public static readonly string versionUrl = "https://raw.githubusercontent.com/Akulav/AkulavMCLauncher/main/version.txt";

        public loginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            FMainPsiholog fmain = new FMainPsiholog(passwordBox.Text);
            fmain.Show();
            Hide();
        }

        private void passwordBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loginButton.PerformClick();
            }
        }

        public void CheckUpdate(string version, Label packVersion)
        {
            try
            {
                var metadata = new List<string>();
                using (WebClient client = new WebClient())
                {
                    string updateData = client.DownloadString(Paths.versionUrl);
                    metadata.AddRange(Regex.Split(updateData, "\r\n|\r|\n"));
                }

                if (version != metadata[0])
                {
                    var client = new WebClient();
                    client.DownloadFileCompleted += Client_DownloadFileCompleted;
                    client.DownloadFileAsync(new Uri(metadata[1]), Paths.update);
                }
                else
                {
                    File.Delete(Paths.update);
                }
            }
            catch
            {
                setControlText(nameLabel, "Server could not be reached.");
                setControlText(packVersion, "");
            }
        }
}
