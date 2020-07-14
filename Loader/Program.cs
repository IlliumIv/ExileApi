using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;

namespace Loader
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                AskToKillOtherRunningProcesses();
            }
            catch
            {
                //
            }

            var loader = new Loader();
            loader.Load(args);
        }

        private static void AskToKillOtherRunningProcesses()
        {
            var currentProcess = Process.GetCurrentProcess();
            var processes = Process.GetProcessesByName(currentProcess.ProcessName);

            var repeatAsk = true;

            while (repeatAsk)
            {
                repeatAsk = false;
                if (processes.Length > 1)
                {
                    var text = "Kill already running HUD process? No- wait 3sec until hud is closed";
                    var caption = "Hud process is already running";

                    var msgBoxResult = MessageBox.Show(text, caption, MessageBoxButtons.YesNoCancel);

                    if (msgBoxResult == DialogResult.Retry)
                    {
                        var tries = 0;
                        while (processes.Length > 1 && tries < 10)
                        {
                            processes = Process.GetProcessesByName(currentProcess.ProcessName);
                            if (processes.Length == 1)
                                break;

                            Thread.Sleep(300);
                            tries++;
                        }

                        repeatAsk = processes.Length > 1;
                    }
                    else if (msgBoxResult == DialogResult.OK)
                    {
                        foreach (var process in processes)
                        {
                            if (process.Id != currentProcess.Id && !process.HasExited)
                            {
                                process.Kill();
                            }
                        }
                    }
                    else if (msgBoxResult == DialogResult.Cancel)
                    {
                        currentProcess.Kill();
                    }
                }
            }
        }
    }
}