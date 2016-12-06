using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace QuanLi
{
    public partial class Form1 : Form
    {
        string[] filePahts1;
        string callPWD = Directory.GetCurrentDirectory().Replace(@"\", @"\\");
        public Form1()
        {
            checkDic();
            InitializeComponent();
        }
        #region checkToStart
        private void checkDic()
        {
            checkSystem();
            creatDic("old_apk");
            creatDic("apk_ing");
            creatDic("apk_new");
        }
        private void checkSystem()
        {
            if (!checkExit("system"))
            {
                MessageBox.Show("Chưa có thư mục \"system\"\nChương trình sẽ không chạy nếu thiếu\nApktool và testsign", "Cảnh báo", MessageBoxButtons.OK);
            }
        }
        private void creatDic(string st)
        {
            if (!checkExit(st))
            {
                creat(st);
            }
        }
        private bool checkExit(string st)
        {
            return Directory.Exists(callPWD+"\\" +st);
        }
        private void creat(string st)
        {
            Directory.CreateDirectory(callPWD + "\\" + st);
        }
        #endregion

        #region CORE
        private void import(string st)
        {
            //startInfo.Arguments = "/c java -jar " + callPWD + "\\system\\apktool.jar if " + callPWD + "\\old_apk\\" +st;
            runAPK("if ", "\\old_apk\\" + st);
        }
        private void decom(string st)
        {
            runAPK("d ", "\\old_apk\\" + st + " -f -o " + callPWD + "\\apk_ing\\" + st);
        }
        private void recom(string st)
        {
            runAPK("b ", "\\apk_ing\\" + st + " -f -o " + callPWD + "\\apk_new\\" + st);
        }
        private void runAPK(string code, string stt)
        {
            pnWorking.Enabled = false;
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.RedirectStandardOutput = true;
            startInfo.RedirectStandardError = true;
            startInfo.UseShellExecute = false;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "/c java -jar " + callPWD + "\\system\\apktool.jar " + code + callPWD + stt;
            process.StartInfo = startInfo;
            process.Start();
            show(process);
            process.WaitForExit();
            
            pnWorking.Enabled = true;
        }
        private void show(Process pr)
        {
            string q = "";
            while (!pr.HasExited)
            {
                q += "error:\n" + pr.StandardError.ReadToEnd();
                q += "\nResult:\n\n" + pr.StandardOutput.ReadToEnd();
            }
            MessageBox.Show(q);
        }
        private void sign(string st)
        {
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.RedirectStandardOutput = true;
            startInfo.RedirectStandardError = true;
            startInfo.UseShellExecute = false;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "/c java -jar " + callPWD + "\\system\\testsign.jar " + callPWD + "\\apk_new\\" + st;
            process.StartInfo = startInfo;
            process.Start();
            show(process);
            process.WaitForExit();
        }
        #endregion

        

        private void btnIP_Click(object sender, EventArgs e)
        {
            pnWorking.Controls.Clear();
            try
            {
                filePahts1 = Directory.GetFiles(callPWD + "\\old_apk", "*.apk", SearchOption.TopDirectoryOnly);
            }
            catch
            {
                return;
            }
            for (int i = 0; i < filePahts1.Length; i++)
            {
                filePahts1[i] = filePahts1[i].Remove(0, callPWD.Length + 9);
                Button newButton = new Button()
                {
                    Size = new Size(250, 40),
                    Text = filePahts1[i],
                    Location = new Point(10, 50 * i)
                };
                newButton.Click += importbtn;
                pnWorking.Controls.Add(newButton);
            }
        }
        void importbtn(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            lbStt.Text = "Đang import " + filePahts1[btn.Location.Y / 50];
            import(btn.Text);
            lbStt.Text = "Import " + filePahts1[btn.Location.Y / 50] + " xong";
        }

        private void btnDC_Click(object sender, EventArgs e)
        {
            pnWorking.Controls.Clear();
            filePahts1 = Directory.GetFiles(callPWD + "\\old_apk", "*.apk", SearchOption.TopDirectoryOnly);
            for (int i = 0; i < filePahts1.Length; i++)
            {
                filePahts1[i] = filePahts1[i].Remove(0, callPWD.Length + 9);
                Button newButton = new Button()
                {
                    Size = new Size(250, 40),
                    Text = filePahts1[i],
                    Location = new Point(10, 50 * i)
                };
                newButton.Click += decombtn;
                pnWorking.Controls.Add(newButton);
            }
        }
        void decombtn(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            lbStt.Text = "Đang decom " + filePahts1[btn.Location.Y / 50];
            decom(btn.Text);
            lbStt.Text = "Decom " + filePahts1[btn.Location.Y / 50] + " xong";
        }

        private void btnRC_Click(object sender, EventArgs e)
        {
            pnWorking.Controls.Clear();
            filePahts1 = Directory.GetDirectories(callPWD + "\\apk_ing", "*.apk", SearchOption.TopDirectoryOnly);
            for (int i = 0; i < filePahts1.Length; i++)
            {
                filePahts1[i] = filePahts1[i].Remove(0, callPWD.Length + 9);
                Button newButton = new Button()
                {
                    Size = new Size(250, 40),
                    Text = filePahts1[i],
                    Location = new Point(10, 50 * i)
                };
                newButton.Click += recombtn;
                pnWorking.Controls.Add(newButton);
            }
        }
        void recombtn(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            lbStt.Text = "Đang recom " + filePahts1[btn.Location.Y / 50];
            recom(btn.Text);
            lbStt.Text = "Recom " + filePahts1[btn.Location.Y / 50] + " hoàn thành";
        }

        private void btnSA_Click(object sender, EventArgs e)
        {
            pnWorking.Controls.Clear();
            filePahts1 = Directory.GetFiles(callPWD + "\\apk_new", "*.apk", SearchOption.TopDirectoryOnly);
            for (int i = 0; i < filePahts1.Length; i++)
            {
                filePahts1[i] = filePahts1[i].Remove(0, callPWD.Length + 9);
                Button newButton = new Button()
                {
                    Size = new Size(250, 40),
                    Text = filePahts1[i],
                    Location = new Point(10, 50 * i)
                };
                newButton.Click += signbtn;
                pnWorking.Controls.Add(newButton);
            }
        }
        void signbtn(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            lbStt.Text = "Đang Sign " + filePahts1[btn.Location.Y / 50];
            sign(btn.Text);
            lbStt.Text = "Sign " + filePahts1[btn.Location.Y / 50] + " hoàn thành";
        }

        private void vScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            panel2.VerticalScroll.Value = vScrollBar.Value;
        }

    }
}
