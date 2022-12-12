using System;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using System.Drawing;

namespace SampleDockPanelSuite
{
    public partial class FormDashboard : DockContent
    {
        private readonly int PINT = 3;

        private Form1 parentForm;

        public FormDashboard(Form1 parentForm)
        {
            InitializeComponent();
            AutoScaleMode = AutoScaleMode.Dpi;
            this.parentForm = parentForm;
        }

        private void FormDashboard_Load(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(PINT, PINT);
        }

        //Refresh
        private void RefreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
        }

        //control change size
        private void FormDashboard_SizeChanged(object sender, EventArgs e)
        {
            pictureBox1.Size = new Size((this.Width) - (PINT * 2), this.Height - (PINT * 2));
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}