using System.Diagnostics;

namespace pushd_test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string strCmdText;
            strCmdText = "pushd" + " " + @"\\mts1\InformationTechnology\software";
            string cd = " cd ccInstaller";
            string paperCut = " msiexec /i Papercut.msi /qn /norestart ALLUSERS=1";

            Process.Start("CMD.exe", strCmdText += cd += paperCut);
            Console.WriteLine(strCmdText += cd += paperCut);
            
        }
    }
}
