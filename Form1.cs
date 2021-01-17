using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;
using System.IO;
using System.Text;

namespace qwq
{
    public partial class Form1 : Form
    {
        [DllImport("user32")]
        private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
        [DllImport("user32")]
        private static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);
        [DllImport("user32.dll")]
        public static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll")]
        static extern uint GetWindowThreadProcessId(IntPtr hWnd, IntPtr ProcessId);

        [DllImport("User32.dll", EntryPoint = "keybd_event ")]
        public static extern void keybd_event(byte bVk, byte bScan, int dwFlags, int dwExtraInfo);

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private static extern int SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
        [DllImport("User32.dll")]
        static extern int SetForegroundWindow(IntPtr point);

        private const int SW_SHOWNORMAL = 1;
        private const int SW_RESTORE = 9;
        private const int SW_SHOWNOACTIVATE = 4;
        //SendMessage参数
        private const int WM_KEYDOWN = 0X100;
        private const int WM_KEYUP = 0X101;
        private const int WM_SYSCHAR = 0X106;
        private const int WM_SYSKEYUP = 0X105;
        private const int WM_SYSKEYDOWN = 0X104;
        private const int WM_CHAR = 0X102;

        readonly IntPtr current;

        void QueryForeGround()
        {
            while (true)
            {
                if (current != GetForegroundWindow() && GetForegroundWindow()!=(IntPtr)0)
                {
                    Foreground.foreground = GetForegroundWindow();
                }
                Thread.Sleep(70);
            }
        }

        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            current = this.Handle;

            //读文件
            //StreamReader sr = new StreamReader("data.txt", Encoding.Default);
            //String line;
            //while ((line = sr.ReadLine()) != null)
            //{
            //    Console.WriteLine(line.ToString());
            //}
            ToolTip p1 = new ToolTip();
            p1.ShowAlways = true;
            p1.SetToolTip(this.button1, "开心");
            ToolTip p3 = new ToolTip();
            p3.ShowAlways = true;
            p3.SetToolTip(this.button3, "加油");
            ToolTip p4 = new ToolTip();
            p4.ShowAlways = true;
            p4.SetToolTip(this.button4, "不屑");
            ToolTip p5 = new ToolTip();
            p5.ShowAlways = true;
            p5.SetToolTip(this.button5, "淡定");
            ToolTip p2 = new ToolTip();
            p2.ShowAlways = true;
            p2.SetToolTip(this.button2, "淡定喝茶");
            ToolTip p6 = new ToolTip();
            p6.ShowAlways = true;
            p6.SetToolTip(this.button6, "惊讶");
            ToolTip p7 = new ToolTip();
            p7.ShowAlways = true;
            p7.SetToolTip(this.button7, "困");
            ToolTip p8 = new ToolTip();
            p8.ShowAlways = true;
            p8.SetToolTip(this.button8, "亲亲");
            ToolTip p9 = new ToolTip();
            p9.ShowAlways = true;
            p9.SetToolTip(this.button9, "呆");
            ToolTip p10 = new ToolTip();
            p10.ShowAlways = true;
            p10.SetToolTip(this.button10, "困惑");
            ToolTip p11 = new ToolTip();
            p11.ShowAlways = true;
            p11.SetToolTip(this.button11, "斜眼");
            ToolTip p12 = new ToolTip();
            p12.ShowAlways = true;
            p12.SetToolTip(this.button12, "努力");
            ToolTip p13 = new ToolTip();
            p13.ShowAlways = true;
            p13.SetToolTip(this.button13, "卖萌");
            ToolTip p14 = new ToolTip();
            p14.ShowAlways = true;
            p14.SetToolTip(this.button14, "惊呆");
            ToolTip p15 = new ToolTip();
            p15.ShowAlways = true;
            p15.SetToolTip(this.button15, "暗暗开心");
            ToolTip p16 = new ToolTip();
            p16.ShowAlways = true;
            p16.SetToolTip(this.button16, "好吃");
            ToolTip p17 = new ToolTip();
            p17.ShowAlways = true;
            p17.SetToolTip(this.button17, "馋");
            ToolTip p18 = new ToolTip();
            p18.ShowAlways = true;
            p18.SetToolTip(this.button18, "生气");
            ToolTip p19 = new ToolTip();
            p19.ShowAlways = true;
            p19.SetToolTip(this.button19, "委屈");
            ToolTip p20 = new ToolTip();
            p20.ShowAlways = true;
            p20.SetToolTip(this.button20, "爽");
            ToolTip p25 = new ToolTip();
            p25.ShowAlways = true;
            p25.SetToolTip(this.button25, "无语");
            ToolTip p24 = new ToolTip();
            p24.ShowAlways = true;
            p24.SetToolTip(this.button24, "侧目而视");
            ToolTip p23 = new ToolTip();
            p23.ShowAlways = true;
            p23.SetToolTip(this.button23, "哭了");
            ToolTip p22 = new ToolTip();
            p22.ShowAlways = true;
            p22.SetToolTip(this.button22, "咦？");

            ToolTip p21 = new ToolTip();
            p21.ShowAlways = true;
            p21.SetToolTip(this.button21, "微笑");
            ToolTip p26 = new ToolTip();
            p26.ShowAlways = true;
            p26.SetToolTip(this.button26, "WTF?");
            ToolTip p27 = new ToolTip();
            p27.ShowAlways = true;
            p27.SetToolTip(this.button27, "愤怒");
            ToolTip p28 = new ToolTip();
            p28.ShowAlways = true;
            p28.SetToolTip(this.button28, "爱心");
            ToolTip p29 = new ToolTip();
            p29.ShowAlways = true;
            p29.SetToolTip(this.button29, "额…");

            ToolTip p30 = new ToolTip();
            p30.ShowAlways = true;
            p30.SetToolTip(this.button30, "干杯");
            ToolTip p35 = new ToolTip();
            p35.ShowAlways = true;
            p35.SetToolTip(this.button35, "瞪眼");
            ToolTip p40 = new ToolTip();
            p40.ShowAlways = true;
            p40.SetToolTip(this.button40, "可爱盯住");
            ToolTip p39 = new ToolTip();
            p39.ShowAlways = true;
            p39.SetToolTip(this.button39, "没办法");
            ToolTip p38 = new ToolTip();
            p38.ShowAlways = true;
            p38.SetToolTip(this.button38, "左顾右盼");
            ToolTip p37 = new ToolTip();
            p37.ShowAlways = true;
            p37.SetToolTip(this.button37, "伤心");
            ToolTip p36 = new ToolTip();
            p36.ShowAlways = true;
            p36.SetToolTip(this.button36, "没睡醒");
            ToolTip p31 = new ToolTip();
            p31.ShowAlways = true;
            p31.SetToolTip(this.button31, "什么?!");
            ToolTip p32 = new ToolTip();
            p32.ShowAlways = true;
            p32.SetToolTip(this.button32, "趴");
            ToolTip p33 = new ToolTip();
            p33.ShowAlways = true;
            p33.SetToolTip(this.button33, "无所谓");

            ToolTip p34 = new ToolTip();
            p34.ShowAlways = true;
            p34.SetToolTip(this.button34, "爽到");
            ToolTip p45 = new ToolTip();
            p45.ShowAlways = true;
            p45.SetToolTip(this.button45, "呆住");

            ToolTip p44 = new ToolTip();
            p44.ShowAlways = true;
            p44.SetToolTip(this.button44, "指着骂");
            ToolTip p43 = new ToolTip();
            p43.ShowAlways = true;
            p43.SetToolTip(this.button43, "迷惑");
            ToolTip p42 = new ToolTip();
            p42.ShowAlways = true;
            p42.SetToolTip(this.button42, "认真");
            ToolTip p41 = new ToolTip();
            p41.ShowAlways = true;
            p41.SetToolTip(this.button41, "嘻嘻");
            ToolTip p46 = new ToolTip();
            p46.ShowAlways = true;
            p46.SetToolTip(this.button46, "猪头");
            ToolTip p47 = new ToolTip();
            p47.ShowAlways = true;
            p47.SetToolTip(this.button47, "蜗牛");
            ToolTip p48 = new ToolTip();
            p48.ShowAlways = true;
            p48.SetToolTip(this.button48, "章鱼");
            ToolTip p49 = new ToolTip();
            p49.ShowAlways = true;
            p49.SetToolTip(this.button49, "毛毛虫");
            ToolTip p50 = new ToolTip();
            p50.ShowAlways = true;
            p50.SetToolTip(this.button50, "蝌蚪");

            Thread t = new Thread(QueryForeGround);
            t.Start();
        }



        private void TableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            //
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void CreditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form2().ShowDialog();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(button1.Text);
            SetForegroundWindow(Foreground.foreground); 
            SendKeys.Send("^v");
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(button3.Text);
            SetForegroundWindow(Foreground.foreground);
            SendKeys.Send("^v");
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(button4.Text);
            
            SetForegroundWindow(Foreground.foreground);
            SendKeys.Send("^v");
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(button5.Text);
            
            SetForegroundWindow(Foreground.foreground);
            SendKeys.Send("^v");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(button2.Text);
            
            SetForegroundWindow(Foreground.foreground);
            SendKeys.Send("^v");
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(button6.Text);
            
            SetForegroundWindow(Foreground.foreground);
            SendKeys.Send("^v");
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(button7.Text);
            
            SetForegroundWindow(Foreground.foreground);
            SendKeys.Send("^v");
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(button8.Text);
            
            SetForegroundWindow(Foreground.foreground);
            SendKeys.Send("^v");
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(button9.Text);
            
            SetForegroundWindow(Foreground.foreground);
            SendKeys.Send("^v");
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(button10.Text);
            
            SetForegroundWindow(Foreground.foreground);
            SendKeys.Send("^v");
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(button11.Text);
            
            SetForegroundWindow(Foreground.foreground);
            SendKeys.Send("^v");
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(button12.Text);
            
            SetForegroundWindow(Foreground.foreground);
            SendKeys.Send("^v");
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(button13.Text);
            
            SetForegroundWindow(Foreground.foreground);
            SendKeys.Send("^v");
        }

        private void Button14_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(button14.Text);
            
            SetForegroundWindow(Foreground.foreground);
            SendKeys.Send("^v");
        }

        private void Button15_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(button15.Text);
            
            SetForegroundWindow(Foreground.foreground);
            SendKeys.Send("^v");
        }

        private void Button16_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(button16.Text);
            
            SetForegroundWindow(Foreground.foreground);
            SendKeys.Send("^v");
        }

        private void Button17_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(button17.Text);
            
            SetForegroundWindow(Foreground.foreground);
            SendKeys.Send("^v");
        }

        private void Button18_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(button18.Text);
            
            SetForegroundWindow(Foreground.foreground);
            SendKeys.Send("^v");
        }

        private void Button19_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(button19.Text);
            
            SetForegroundWindow(Foreground.foreground);
            SendKeys.Send("^v");
        }

        private void Button20_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(button20.Text);
            
            SetForegroundWindow(Foreground.foreground);
            SendKeys.Send("^v");
        }

        private void Button25_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(button25.Text);
            
            SetForegroundWindow(Foreground.foreground);
            SendKeys.Send("^v");
        }

        private void Button24_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(button24.Text);
            
            SetForegroundWindow(Foreground.foreground);
            SendKeys.Send("^v");
        }

        private void Button23_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(button23.Text);
            
            SetForegroundWindow(Foreground.foreground);
            SendKeys.Send("^v");
        }

        private void Button22_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(button22.Text);
            
            SetForegroundWindow(Foreground.foreground);
            SendKeys.Send("^v");
        }

        private void Button21_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(button21.Text);
            
            SetForegroundWindow(Foreground.foreground);
            SendKeys.Send("^v");
        }

        private void Button26_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(button26.Text);
            
            SetForegroundWindow(Foreground.foreground);
            SendKeys.Send("^v");
        }

        private void Button27_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(button27.Text);
            
            SetForegroundWindow(Foreground.foreground);
            SendKeys.Send("^v");
        }

        private void Button28_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(button28.Text);
            
            SetForegroundWindow(Foreground.foreground);
            SendKeys.Send("^v");
        }

        private void Button29_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(button29.Text);
            
            SetForegroundWindow(Foreground.foreground);
            SendKeys.Send("^v");
        }

        private void Button30_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(button30.Text);
           
            SetForegroundWindow(Foreground.foreground);
            SendKeys.Send("^v");
        }

        private void Button35_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(button35.Text);
            
            SetForegroundWindow(Foreground.foreground);
            SendKeys.Send("^v");
        }

        private void Button40_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(button40.Text);
            
            SetForegroundWindow(Foreground.foreground);
            SendKeys.Send("^v");
        }

        private void Button39_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(button39.Text);
            
            SetForegroundWindow(Foreground.foreground);
            SendKeys.Send("^v");
        }

        private void Button38_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(button38.Text);
            
            SetForegroundWindow(Foreground.foreground);
            SendKeys.Send("^v");
        }

        private void Button37_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(button37.Text);
            
            SetForegroundWindow(Foreground.foreground);
            SendKeys.Send("^v");
        }

        private void Button36_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(button36.Text);
            
            SetForegroundWindow(Foreground.foreground);
            SendKeys.Send("^v");
        }

        private void Button31_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(button31.Text);
            
            SetForegroundWindow(Foreground.foreground);
            SendKeys.Send("^v");
        }

        private void Button32_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(button32.Text);
            
            SetForegroundWindow(Foreground.foreground);
            SendKeys.Send("^v");
        }

        private void Button33_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(button33.Text);
            
            SetForegroundWindow(Foreground.foreground);
            SendKeys.Send("^v");
        }

        private void Button34_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(button34.Text);
            
            SetForegroundWindow(Foreground.foreground);
            SendKeys.Send("^v");
        }

        private void Button45_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(button45.Text);
            
            SetForegroundWindow(Foreground.foreground);
            SendKeys.Send("^v");
        }

        private void Button44_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(button44.Text);
            
            SetForegroundWindow(Foreground.foreground);
            SendKeys.Send("^v");
        }

        private void Button43_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(button43.Text);
            
            SetForegroundWindow(Foreground.foreground);
            SendKeys.Send("^v");
        }

        private void Button42_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(button42.Text);
            
            SetForegroundWindow(Foreground.foreground);
            SendKeys.Send("^v");
        }

        private void Button41_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(button41.Text);
            
            SetForegroundWindow(Foreground.foreground);
            SendKeys.Send("^v");
        }

        private void Button46_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(button46.Text);
            
            SetForegroundWindow(Foreground.foreground);
            SendKeys.Send("^v");
        }

        private void Button47_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(button47.Text);
            
            SetForegroundWindow(Foreground.foreground);
            SendKeys.Send("^v");
        }

        private void Button48_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(button48.Text);
            
            SetForegroundWindow(Foreground.foreground);
            SendKeys.Send("^v");
        }

        private void Button49_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(button49.Text);
            
            SetForegroundWindow(Foreground.foreground);
            SendKeys.Send("^v");
        }

        private void Button50_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(button50.Text);
            
            SetForegroundWindow(Foreground.foreground);
            SendKeys.Send("^v");
        }

        private void AddToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new Form3().ShowDialog();
        }

        private void ReportIssuesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("mailto: njdswhy@163.com");
        }
    }
}
