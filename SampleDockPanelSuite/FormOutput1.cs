using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SampleDockPanelSuite
{
    public partial class FormOutput1 : ToolWindow
    {
        //제한 라인 수
        const int nLimitLines = 100;
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool HideCaret(IntPtr hWnd);

        public FormOutput1()
        {
            InitializeComponent();
        }

        private void TextBox1_MouseDown(object sender, MouseEventArgs e)
        {
            HideCaret(this.Handle);
        }

        delegate void CrossThreadSafetyText(List<string> text);
        public void SetLogTextBox1(List<string> text)
        {
            if (TextBox1 != null)
            {
                if (TextBox1.InvokeRequired)
                {
                    try
                    {
                        if (TextBox1 != null && this != null)
                        {
                            TextBox1.Invoke(new CrossThreadSafetyText(SetLogTextBox1), text);
                        }
                    }
                    finally { }
                }
                else
                {
                    try
                    {
                        TextBox1.AppendText(DateTime.Now.ToString("------------------ HH:mm:ss ------------------") + "\r\n");
                        int cnt = 1;
                        foreach(string txt in text)
                        {
                            TextBox1.AppendText($"{cnt}. {txt}\r\n");
                            cnt++;
                        }
                        TextBox1.AppendText(DateTime.Now.ToString("----------------------------------------------") + "\r\n");
                        //TextBox1.AppendText("\r\n");

                        if (TextBox1.Lines.Length > nLimitLines)
                        {
                            LinkedList<string> tempLines = new(TextBox1.Lines);

                            while ((tempLines.Count - nLimitLines) > 0)
                            {
                                tempLines.RemoveFirst();
                            }

                            TextBox1.Lines = tempLines.ToArray();
                        }
                        TextBox1.Select(TextBox1.Text.Length, 0);
                        TextBox1.ScrollToCaret();
                    }
                    finally { }
                }
            }
        }

        private void ClearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "";
        }
    }
}