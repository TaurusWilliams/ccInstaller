using System.Diagnostics;

namespace pushd_testGUI
{
    public partial class Form1 : Form
    {
        string path = @"\\mts1\InformationTechnology\software\ccInstaller";
        public Form1()
        {
            InitializeComponent();

        }


        public void paperCutInstall()
        {
            //Papercut
            Process Papercut = new Process();
            ProcessStartInfo b = new ProcessStartInfo
            {
                FileName = "msiexec.exe",
                Arguments = "/i Papercut.msi",
                UseShellExecute = false,
                RedirectStandardOutput = true,
                CreateNoWindow = true,
                Verb = "runas"
            };
            Papercut.StartInfo = b;
            Papercut.StartInfo.WorkingDirectory = path;
            try
            {
                Process.Start(b);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void adobeInstall()
        {
            //Adobe
            Process adobe = new Process();
            ProcessStartInfo a = new ProcessStartInfo
            {
                FileName = "\\software\\ccInstaller\\Adobe.exe",
                UseShellExecute = true,
                CreateNoWindow = true,
                Verb = "runas"
            };
            adobe.StartInfo = a;
            adobe.StartInfo.WorkingDirectory = path;
            try
            {
                Process.Start(a);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void sophosInstall()
        {
            //Sophos
            Process Sophos = new Process();
            ProcessStartInfo b = new ProcessStartInfo
            {
                FileName = "\\software\\ccInstaller\\Sophos.exe",
                UseShellExecute = true,
                CreateNoWindow = true,
                Verb = "runas"
            };
            Sophos.StartInfo = b;
            Sophos.StartInfo.WorkingDirectory = path;
            try
            {
                Process.Start(b);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void splashtopInstall()
        {
            //Splashtop
            Process Splashtop = new Process();
            ProcessStartInfo b = new ProcessStartInfo
            {
                FileName = "msiexec.exe",
                Arguments = "/i Splashtop.msi",
                UseShellExecute = false,
                RedirectStandardOutput = true,
                CreateNoWindow = true,
                Verb = "runas"
            };
            Splashtop.StartInfo = b;
            Splashtop.StartInfo.WorkingDirectory = path;
            try
            {
                Process.Start(b);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void cloudflareInstall()
        {
            //CloudFlare
            Process CloudFlare = new Process();
            ProcessStartInfo b = new ProcessStartInfo
            {
                FileName = "msiexec.exe",
                Arguments = "/i CloudFlare.msi",
                UseShellExecute = false,
                RedirectStandardOutput = true,
                CreateNoWindow = true,
                Verb = "runas"
            };
            CloudFlare.StartInfo = b;
            CloudFlare.StartInfo.WorkingDirectory = path;
            try
            {
                Process.Start(b);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void Papercut_btn_Click(object sender, EventArgs e)
        {
            paperCutInstall();
        }

        private void Adobe_btn_Click(object sender, EventArgs e)
        {
            adobeInstall();
        }

        private void Sophos_btn_Click(object sender, EventArgs e)
        {
            sophosInstall();
        }

        private void Splashtop_btn_Click(object sender, EventArgs e)
        {
            splashtopInstall();
        }

        private void Cloudflare_btn_Click(object sender, EventArgs e)
        {
            cloudflareInstall();
        }

        private void Office365_btn_Click(object sender, EventArgs e)
        {

        }
    }
}
