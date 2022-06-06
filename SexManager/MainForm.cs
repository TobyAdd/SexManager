using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace SexManager
{
    public partial class MainForm : Form
    {
        List<int> suspendList = new List<int>();

        [Flags]
        public enum ThreadAccess : int
        {
            TERMINATE = (0x0001),
            SUSPEND_RESUME = (0x0002),
            GET_CONTEXT = (0x0008),
            SET_CONTEXT = (0x0010),
            SET_INFORMATION = (0x0020),
            QUERY_INFORMATION = (0x0040),
            SET_THREAD_TOKEN = (0x0080),
            IMPERSONATE = (0x0100),
            DIRECT_IMPERSONATION = (0x0200)
        }

        [DllImport("kernel32.dll")]
        static extern IntPtr OpenThread(ThreadAccess dwDesiredAccess, bool bInheritHandle, uint dwThreadId);
        [DllImport("kernel32.dll")]
        static extern uint SuspendThread(IntPtr hThread);
        [DllImport("kernel32.dll")]
        static extern int ResumeThread(IntPtr hThread);
        [DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
        static extern bool CloseHandle(IntPtr handle);
        public MainForm()
        {
            InitializeComponent();
            UpdateSlaves();

        }

        void UpdateSlaves()
        {
            sexView.Items.Clear();
            foreach (Process list in Process.GetProcesses())
            {
                string[] row = { list.ProcessName + ".exe", list.Id.ToString() };
                var listViewItem = new ListViewItem(row);
                sexView.Items.Add(listViewItem);
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            UpdateSlaves();
        }

        bool KillProcess(int pid)
        {
            try
            {
                Process proc = Process.GetProcessById(pid);
                proc.Kill();
                proc.WaitForExit();
                proc.Dispose();
                return true;
            }
            catch
            {
                return false;
            }

        }
        bool SuspendProcess(int pid)
        {
            try
            {
                var process = Process.GetProcessById(pid);

                foreach (ProcessThread pT in process.Threads)
                {
                    IntPtr pOpenThread = OpenThread(ThreadAccess.SUSPEND_RESUME, false, (uint)pT.Id);

                    if (pOpenThread == IntPtr.Zero)
                    {
                        continue;
                    }

                    SuspendThread(pOpenThread);

                    CloseHandle(pOpenThread);
                }
                return true;
            }
            catch
            {
                return false;
            }

        }

        bool ResumeProcess(int pid)
        {
            try
            {
                var process = Process.GetProcessById(pid);

                if (process.ProcessName == string.Empty)
                {
                    return false;
                }

                foreach (ProcessThread pT in process.Threads)
                {
                    IntPtr pOpenThread = OpenThread(ThreadAccess.SUSPEND_RESUME, false, (uint)pT.Id);

                    if (pOpenThread == IntPtr.Zero)
                    {
                        continue;
                    }

                    var suspendCount = 0;
                    do
                    {
                        suspendCount = ResumeThread(pOpenThread);
                    } while (suspendCount > 0);

                    CloseHandle(pOpenThread);
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void buttonHeadshot_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in sexView.SelectedItems)
            {
                if (suspendList.Contains(Int32.Parse(item.SubItems[1].Text)))
                {
                    suspendList.Remove(Int32.Parse(item.SubItems[1].Text));
                }
                KillProcess(Int32.Parse(item.SubItems[1].Text));
            }
            UpdateSlaves();
        }

        private void buttonKO_Click(object sender, EventArgs e)
        {
            if (buttonKO.Text == "K.O.")
            {
                foreach (ListViewItem item in sexView.SelectedItems)
                {
                    if (!suspendList.Contains(Int32.Parse(item.SubItems[1].Text)))
                    {
                        suspendList.Add(Int32.Parse(item.SubItems[1].Text));
                        SuspendProcess(Int32.Parse(item.SubItems[1].Text));
                    }
                    buttonKO.Text = "Wake up!";
                    kOToolStripMenuItem.Text = "Wake up!";
                }
            }
            else
            {
                foreach (ListViewItem item in sexView.SelectedItems)
                {
                    if (suspendList.Contains(Int32.Parse(item.SubItems[1].Text)))
                    {
                        suspendList.Remove(Int32.Parse(item.SubItems[1].Text));
                        ResumeProcess(Int32.Parse(item.SubItems[1].Text));
                    }
                    buttonKO.Text = "K.O.";
                    kOToolStripMenuItem.Text = "K.O.";
                }
            }
        }

        private void sexView_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool check = false;

            foreach (ListViewItem item in sexView.SelectedItems)
            {
                if (suspendList.Contains(Int32.Parse(item.SubItems[1].Text)))
                {
                    check = true;
                    break;
                }
            }

            if (check)
            {
                buttonKO.Text = "Wake up!";
                kOToolStripMenuItem.Text = "Wake up!";
            }
            else
            {
                buttonKO.Text = "K.O.";
                kOToolStripMenuItem.Text = "K.O.";
            }
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            List<string> about = new List<string>();
            about.Add("Cum inside me! ahh");
            about.Add("My developer is TobyAdd, I love him ~uwu");
            about.Add("I am a fight girl who can kill any process! UwU");
            about.Add("You are so cool >W<");
            about.Add("I am your Sex Manager");
            about.Add("I am coded in C# OwO");
            about.Add("Hello! UwU");

            MessageBox.Show(about.OrderBy(_ => Guid.NewGuid()).First(), "Sex Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        string GetProcessNameByPid(int pid)
        {
            try
            {
                Process proc = Process.GetProcessById(pid);
                return proc.ProcessName;
            }
            catch
            {
                return "Unknown";
            }
        }

        string GetStartTime(int pid)
        {
            try
            {
                Process proc = Process.GetProcessById(pid);
                return $"{proc.StartTime.ToLongDateString()} {proc.StartTime.ToLongTimeString()}";
            }
            catch
            {
                return "Unknown";
            }
        }

        string GetProcessPriority(int pid)
        {
            try
            {
                Process proc = Process.GetProcessById(pid);
                return $"{proc.PriorityClass}({proc.BasePriority})";
            }
            catch
            {
                return "Unknown";
            }
        }

        string GetSessionID(int pid)
        {
            try
            {
                Process proc = Process.GetProcessById(pid);
                return $"{proc.SessionId}";
            }
            catch
            {
                return "Unknown";
            }
        }





        private void buttonAboutSlave_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in sexView.SelectedItems)
            {
                Process proc = Process.GetProcessById(Int32.Parse(item.SubItems[1].Text));
                if (MessageBox.Show($"Name: {GetProcessNameByPid(Int32.Parse(item.SubItems[1].Text))}\nPID: {item.SubItems[1].Text}\nStart Time: {GetStartTime(Int32.Parse(item.SubItems[1].Text))}\nProcess priority: {GetProcessPriority(Int32.Parse(item.SubItems[1].Text))}\nSession ID: {GetSessionID(Int32.Parse(item.SubItems[1].Text))}",
                     $"About {GetProcessNameByPid(Int32.Parse(item.SubItems[1].Text))}", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                {
                    break;
                }
            }
        }
    }
}
