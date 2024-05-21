using System.ComponentModel.Design;
using System.Diagnostics;

namespace test
{
    internal class Program
    {
        static void Main(string[] args)
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
            adobe.StartInfo.WorkingDirectory = @"\\mts1\InformationTechnology\software";
            try
            {
                Process.Start(a);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            //Splashtop
            Process splashtop = new Process();
            ProcessStartInfo b = new ProcessStartInfo
            {
                FileName = "msiexec.exe",
                Arguments = "/i Splashtop.msi",
                UseShellExecute = false,
                RedirectStandardOutput = true,
                CreateNoWindow = true,
                Verb = "runas"
            };
            splashtop.StartInfo = b;
            splashtop.StartInfo.WorkingDirectory = @"\\mts1\InformationTechnology\software\ccInstaller";
            try
            {
                Process.Start(b);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
