using System;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using System.Drawing;

namespace SampleDockPanelSuite
{
    public partial class FormDashboard : DockContent
    {
        private readonly int PINT = 3;

        public FormDashboard()
        {
            InitializeComponent();
            AutoScaleMode = AutoScaleMode.Dpi;
        }

        private void FormDashboard_Load(object sender, EventArgs e)
        {
            listView1.Location = new Point(PINT, PINT);
        }

        //Refresh
        private void RefreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.Refresh();
        }

        //control change size
        private void FormDashboard_SizeChanged(object sender, EventArgs e)
        {
            listView1.Size = new Size((this.Width) - (PINT * 2), this.Height - (PINT * 2));
        }
    }
}