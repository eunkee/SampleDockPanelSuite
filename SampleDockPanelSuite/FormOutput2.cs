using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SampleDockPanelSuite
{
    public partial class FormOutput2 : ToolWindow
    {
        //제한 라인 수
        const int nLimitLines = 1000;
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool HideCaret(IntPtr hWnd);

        public FormOutput2()
        {
            InitializeComponent();
        }

        private void TextBox1_MouseDown(object sender, MouseEventArgs e)
        {
            HideCaret(this.Handle);
        }

        delegate void CrossThreadSafetyText(string text);
        public void SetLogTextBox1(string text)
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
                        string AppendMessage = $"{DateTime.Now:HH:mm:ss.fff} {text}\r\n";
                        TextBox1.AppendText(AppendMessage);

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
            TextBox1.Text = string.Empty;
        }
    }
}