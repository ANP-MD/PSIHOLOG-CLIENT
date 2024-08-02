using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Psiholog
{
    public partial class loginForm : Form
    {
        private static readonly string client_version = "1.0.1";
        public static readonly string versionUrl = "https://raw.githubusercontent.com/ANP-MD/PSIHOLOG-CLIENT/main/version.txt";
        public static readonly string update = @"C:\Psiholog\update.exe";
        public static readonly string updateFlag = @"C:\Psiholog\update.txt";


        public loginForm()
        {
            InitializeComponent();
            CheckUpdate(client_version);
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

        private void CheckUpdate(string version)
        {
            try
            {
                var metadata = new List<string>();
                using (WebClient client = new WebClient())
                {
                    string updateData = client.DownloadString(versionUrl);
                    metadata.AddRange(Regex.Split(updateData, "\r\n|\r|\n"));
                }

                if (version != metadata[0])
                {
                    var client = new WebClient();
                    client.DownloadFileCompleted += Client_DownloadFileCompleted;
                    client.DownloadFileAsync(new Uri(metadata[1]), update);
                }
                else
                {
                    File.Delete(update);
                }
            }
            catch
            {
                errorLabel.Text = "Update Error";
            }
        }

        private void Client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            File.WriteAllText(updateFlag, "INCOMING_UPDATE");
            var p = new Process();
            p.StartInfo.FileName = update;
            p.Start();
            Application.Exit();

        }
    }
}
