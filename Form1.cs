using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PublicProxyScraper
{
    public partial class formMain : Form
    {

        public formMain()
        {
            InitializeComponent();
            StatusLabel.Text = GlobalVariables.SetStatusLabel[0];
        }

        public class GlobalVariables
        {
            public static string gitHubUrl;
            public static string gitHubInputPlaceholder = "GitHub Raw URL";
            public static string gitHubRawURLCheck = "https://raw.githubusercontent.com/";
            public static string AuthorUrl = "https://t.me/trepang666";
            private static string pStatusLabel = "Status: ";
            public static string[] SetStatusLabel = new string[]
            {
                pStatusLabel + "Idle",
                pStatusLabel + "Getting Proxies",
                pStatusLabel + "Saving Proxies",
                pStatusLabel + "Saved",
            };
            public static string[] gitHubRandomUrls = new string[]
            {
                "https://raw.githubusercontent.com/TheSpeedX/PROXY-List/master/socks4.txt",
                "https://raw.githubusercontent.com/prxchk/proxy-list/main/http.txt",
                "https://raw.githubusercontent.com/prxchk/proxy-list/main/socks4.txt",
                "https://raw.githubusercontent.com/prxchk/proxy-list/main/socks5.txt",
                "https://raw.githubusercontent.com/TheSpeedX/PROXY-List/master/http.txt",
                "https://raw.githubusercontent.com/TheSpeedX/PROXY-List/master/socks5.txt",
                "https://raw.githubusercontent.com/monosans/proxy-list/main/proxies/http.txt",
                "https://raw.githubusercontent.com/monosans/proxy-list/main/proxies/socks4.txt",
                "https://raw.githubusercontent.com/monosans/proxy-list/main/proxies/socks5.txt",
                "https://raw.githubusercontent.com/monosans/proxy-list/main/proxies_anonymous/http.txt",
                "https://raw.githubusercontent.com/monosans/proxy-list/main/proxies_anonymous/socks4.txt",
                "https://raw.githubusercontent.com/monosans/proxy-list/main/proxies_anonymous/socks5.txt",
                "https://raw.githubusercontent.com/mmpx12/proxy-list/master/http.txt",
                "https://raw.githubusercontent.com/mmpx12/proxy-list/master/https.txt",
                "https://raw.githubusercontent.com/mmpx12/proxy-list/master/socks4.txt",
                "https://raw.githubusercontent.com/mmpx12/proxy-list/master/socks5.txt",
                "https://raw.githubusercontent.com/sunny9577/proxy-scraper/master/proxies.txt",
            };
        }

        private void MenuAuthorBtn_Click(object sender, EventArgs e)
        {
            Process.Start(GlobalVariables.AuthorUrl);
        }

        //GITHUB WHOLE FUNCTION STARTS HERE
        private void txtGitHubUrl_Enter(object sender, EventArgs e)
        {
            if (txtGitHubUrl.Text == GlobalVariables.gitHubInputPlaceholder)
            {
                txtGitHubUrl.Text = string.Empty;
            }
        }

        private void txtGitHubUrl_Leave(object sender, EventArgs e)
        {
            txtGitHubUrl.Text = txtGitHubUrl.Text;
        }

        private void txtGitHubUrl_TextChanged(object sender, EventArgs e)
        {
            SaveGitProxies.Enabled = false;

            // Получить URL-адрес GitHub из текстового поля
            GlobalVariables.gitHubUrl = txtGitHubUrl.Text;

            if (GlobalVariables.gitHubUrl.StartsWith(GlobalVariables.gitHubRawURLCheck))
            {
                SaveGitProxies.Enabled = true;
            }
        }

        private void SaveGitProxies_Click(object sender, EventArgs e)
        {
            // Получить URL-адрес GitHub из текстового поля
            GlobalVariables.gitHubUrl = txtGitHubUrl.Text;

            // Проверка на валидность ссылки в поле ввода
            if (string.IsNullOrEmpty(GlobalVariables.gitHubUrl)) 
            {
                MessageBox.Show("GitHub input field is empty. You must paste the raw link to GitHub Proxies page.");
                return;
            }

            if (!GlobalVariables.gitHubUrl.StartsWith(GlobalVariables.gitHubRawURLCheck))
            {
                MessageBox.Show("Invalid GitHub URL. The link must start with:\n" + GlobalVariables.gitHubRawURLCheck);
                return;
            }

            else
            {
                StatusLabel.Text = GlobalVariables.SetStatusLabel[1];
                // Создать WebClient для загрузки данных
                WebClient webClient = new WebClient();

                // Скачать текст из GitHub
                string proxyListText = webClient.DownloadString(GlobalVariables.gitHubUrl);

                // Разделить текст на строки
                string[] proxyLines = proxyListText.Split(new[] { "\r\n", "\n" }, StringSplitOptions.RemoveEmptyEntries);

                // Сохранить список прокси в файл
                SaveProxiesToFile(proxyLines);
            }
        }

        private async void SaveProxiesToFile(string[] proxyLines)
        {
            StatusLabel.Text = GlobalVariables.SetStatusLabel[2];
            // Выбрать путь к файлу
            string filePath = GetSaveFilePath();

            // Создать StreamWriter для записи в файл
            // Проверить имя файла
            if (string.IsNullOrEmpty(filePath))
            {
                StatusLabel.Text = GlobalVariables.SetStatusLabel[0];
                return;
            }

            // Сохранить список прокси в файл
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (string proxyLine in proxyLines)
                {
                    writer.WriteLine(proxyLine);
                }
            }
            // Отобразить сообщение о сохранении
            MessageBox.Show("Proxy list saved in: " + filePath);
            StatusLabel.Text = GlobalVariables.SetStatusLabel[3];
            await Task.Delay(2000);
            StatusLabel.Text = GlobalVariables.SetStatusLabel[0];
        }

        private string GetSaveFilePath()
        {
            // Отобразить диалоговое окно сохранения файла
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text files (*.txt)|*.txt";
            saveFileDialog.Title = "Save proxy list";
            saveFileDialog.FileName = "Proxies.txt";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                return saveFileDialog.FileName;
            }

            return string.Empty;
        }

        private void GetGitRandomLink_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int index = random.Next(GlobalVariables.gitHubRandomUrls.Length);

            GlobalVariables.gitHubUrl = GlobalVariables.gitHubRandomUrls[index];
            txtGitHubUrl.Text = GlobalVariables.gitHubUrl;
        }

        private void GetGitRandomLink_MouseEnter(object sender, EventArgs e)
        {
            Helper = new ToolTip();
            Helper.SetToolTip(GetGitRandomLink, "Get a random GitHub proxy URL from a prewritten list.");
        }

        private void txtGitHubUrl_MouseEnter(object sender, EventArgs e)
        {
            Helper = new ToolTip();
            Helper.SetToolTip(txtGitHubUrl, "GitHub link must starts as:\nhttps://raw.githubusercontent.com/");
        }
        //GITHUB WHOLE FUNCTION ENDS HERE
    }
}