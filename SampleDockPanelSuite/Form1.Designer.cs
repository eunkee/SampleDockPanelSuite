
namespace SampleDockPanelSuite
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.menuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemView = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemLockLayout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemDefaultLayout = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemSaveLayout = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemLoadLayout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemViewLog1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemViewLog2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemTools = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemSchemaVS2015Light = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemSchemaVS2015Blue = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemSchemaVS2015Dark = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.vS2015LightTheme1 = new WeifenLuo.WinFormsUI.Docking.VS2015LightTheme();
            this.vS2015BlueTheme1 = new WeifenLuo.WinFormsUI.Docking.VS2015BlueTheme();
            this.vS2015DarkTheme1 = new WeifenLuo.WinFormsUI.Docking.VS2015DarkTheme();
            this.dockPanel = new WeifenLuo.WinFormsUI.Docking.DockPanel();
            this.mainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(15)))), ((int)(((byte)(27)))));
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemFile,
            this.menuItemView,
            this.menuItemTools,
            this.menuItemHelp});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(579, 24);
            this.mainMenu.TabIndex = 1;
            this.mainMenu.Text = "menuStrip1";
            this.mainMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.mainMenu_ItemClicked);
            // 
            // menuItemFile
            // 
            this.menuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemExit});
            this.menuItemFile.Name = "menuItemFile";
            this.menuItemFile.Size = new System.Drawing.Size(57, 20);
            this.menuItemFile.Text = "파일(&F)";
            // 
            // menuItemExit
            // 
            this.menuItemExit.Name = "menuItemExit";
            this.menuItemExit.Size = new System.Drawing.Size(124, 22);
            this.menuItemExit.Text = "끝내기(&E)";
            this.menuItemExit.Click += new System.EventHandler(this.MenuItemExit_Click);
            // 
            // menuItemView
            // 
            this.menuItemView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemLockLayout,
            this.toolStripSeparator2,
            this.menuItemDefaultLayout,
            this.menuItemSaveLayout,
            this.menuItemLoadLayout,
            this.toolStripSeparator1,
            this.menuItemViewLog1,
            this.menuItemViewLog2});
            this.menuItemView.MergeIndex = 1;
            this.menuItemView.Name = "menuItemView";
            this.menuItemView.Size = new System.Drawing.Size(59, 20);
            this.menuItemView.Text = "보기(&V)";
            // 
            // menuItemLockLayout
            // 
            this.menuItemLockLayout.Name = "menuItemLockLayout";
            this.menuItemLockLayout.Size = new System.Drawing.Size(231, 22);
            this.menuItemLockLayout.Text = "레이아웃 잠그기(&O)";
            this.menuItemLockLayout.Click += new System.EventHandler(this.MenuItemLockLayout_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(228, 6);
            // 
            // menuItemDefaultLayout
            // 
            this.menuItemDefaultLayout.Name = "menuItemDefaultLayout";
            this.menuItemDefaultLayout.Size = new System.Drawing.Size(231, 22);
            this.menuItemDefaultLayout.Text = "기본 레이아웃(&D)";
            this.menuItemDefaultLayout.Click += new System.EventHandler(this.MenuItemDefaultLayout_Click);
            // 
            // menuItemSaveLayout
            // 
            this.menuItemSaveLayout.Name = "menuItemSaveLayout";
            this.menuItemSaveLayout.Size = new System.Drawing.Size(231, 22);
            this.menuItemSaveLayout.Text = "현재 레이아웃 저장(&C)";
            this.menuItemSaveLayout.Click += new System.EventHandler(this.MenuItemSaveLayout_Click);
            // 
            // menuItemLoadLayout
            // 
            this.menuItemLoadLayout.Name = "menuItemLoadLayout";
            this.menuItemLoadLayout.Size = new System.Drawing.Size(231, 22);
            this.menuItemLoadLayout.Text = "저장된 레이아웃 불러오기(&D)";
            this.menuItemLoadLayout.Click += new System.EventHandler(this.MenuItemLoadLayout_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(228, 6);
            // 
            // menuItemViewLog1
            // 
            this.menuItemViewLog1.Name = "menuItemViewLog1";
            this.menuItemViewLog1.Size = new System.Drawing.Size(231, 22);
            this.menuItemViewLog1.Text = "로그1보기";
            this.menuItemViewLog1.Click += new System.EventHandler(this.MenuItemViewLog1_Click);
            // 
            // menuItemViewLog2
            // 
            this.menuItemViewLog2.Name = "menuItemViewLog2";
            this.menuItemViewLog2.Size = new System.Drawing.Size(231, 22);
            this.menuItemViewLog2.Text = "로그2보기";
            this.menuItemViewLog2.Click += new System.EventHandler(this.MenuItemViewLog2_Click);
            // 
            // menuItemTools
            // 
            this.menuItemTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemSchemaVS2015Light,
            this.menuItemSchemaVS2015Blue,
            this.menuItemSchemaVS2015Dark});
            this.menuItemTools.MergeIndex = 2;
            this.menuItemTools.Name = "menuItemTools";
            this.menuItemTools.Size = new System.Drawing.Size(57, 20);
            this.menuItemTools.Text = "도구(&T)";
            // 
            // menuItemSchemaVS2015Light
            // 
            this.menuItemSchemaVS2015Light.Name = "menuItemSchemaVS2015Light";
            this.menuItemSchemaVS2015Light.Size = new System.Drawing.Size(203, 22);
            this.menuItemSchemaVS2015Light.Text = "테마적용: VS2015 Light";
            this.menuItemSchemaVS2015Light.Click += new System.EventHandler(this.SetSchema);
            // 
            // menuItemSchemaVS2015Blue
            // 
            this.menuItemSchemaVS2015Blue.Name = "menuItemSchemaVS2015Blue";
            this.menuItemSchemaVS2015Blue.Size = new System.Drawing.Size(203, 22);
            this.menuItemSchemaVS2015Blue.Text = "테마적용: VS2015 Blue";
            this.menuItemSchemaVS2015Blue.Click += new System.EventHandler(this.SetSchema);
            // 
            // menuItemSchemaVS2015Dark
            // 
            this.menuItemSchemaVS2015Dark.Name = "menuItemSchemaVS2015Dark";
            this.menuItemSchemaVS2015Dark.Size = new System.Drawing.Size(203, 22);
            this.menuItemSchemaVS2015Dark.Text = "테마적용: VS2015 Dark";
            this.menuItemSchemaVS2015Dark.Click += new System.EventHandler(this.SetSchema);
            // 
            // menuItemHelp
            // 
            this.menuItemHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemAbout});
            this.menuItemHelp.MergeIndex = 3;
            this.menuItemHelp.Name = "menuItemHelp";
            this.menuItemHelp.Size = new System.Drawing.Size(72, 20);
            this.menuItemHelp.Text = "도움말(&H)";
            // 
            // menuItemAbout
            // 
            this.menuItemAbout.Name = "menuItemAbout";
            this.menuItemAbout.Size = new System.Drawing.Size(114, 22);
            this.menuItemAbout.Text = "정보(&A)";
            this.menuItemAbout.Click += new System.EventHandler(this.MenuItemAbout_Click);
            // 
            // dockPanel
            // 
            this.dockPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(15)))), ((int)(((byte)(27)))));
            this.dockPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dockPanel.DockBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(15)))), ((int)(((byte)(27)))));
            this.dockPanel.DockBottomPortion = 150D;
            this.dockPanel.DockLeftPortion = 200D;
            this.dockPanel.DockRightPortion = 200D;
            this.dockPanel.DockTopPortion = 150D;
            this.dockPanel.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.dockPanel.Location = new System.Drawing.Point(0, 24);
            this.dockPanel.Name = "dockPanel";
            this.dockPanel.RightToLeftLayout = true;
            this.dockPanel.Size = new System.Drawing.Size(579, 385);
            this.dockPanel.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(579, 409);
            this.Controls.Add(this.dockPanel);
            this.Controls.Add(this.mainMenu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mainMenu;
            this.Name = "Form1";
            this.Text = "Sample DockPanelSuite";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WeifenLuo.WinFormsUI.Docking.DockPanel dockPanel;
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem menuItemFile;
        private System.Windows.Forms.ToolStripMenuItem menuItemExit;
        private System.Windows.Forms.ToolStripMenuItem menuItemTools;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem menuItemHelp;
        private System.Windows.Forms.ToolStripMenuItem menuItemAbout;
        private System.Windows.Forms.ToolStripMenuItem menuItemSchemaVS2015Light;
        private System.Windows.Forms.ToolStripMenuItem menuItemSchemaVS2015Blue;
        private System.Windows.Forms.ToolStripMenuItem menuItemSchemaVS2015Dark;
        private WeifenLuo.WinFormsUI.Docking.VS2015LightTheme vS2015LightTheme1;
        private WeifenLuo.WinFormsUI.Docking.VS2015BlueTheme vS2015BlueTheme1;
        private WeifenLuo.WinFormsUI.Docking.VS2015DarkTheme vS2015DarkTheme1;
        private System.Windows.Forms.ToolStripMenuItem menuItemView;
        private System.Windows.Forms.ToolStripMenuItem menuItemLockLayout;
        private System.Windows.Forms.ToolStripMenuItem menuItemDefaultLayout;
        private System.Windows.Forms.ToolStripMenuItem menuItemSaveLayout;
        private System.Windows.Forms.ToolStripMenuItem menuItemLoadLayout;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuItemViewLog1;
        private System.Windows.Forms.ToolStripMenuItem menuItemViewLog2;
    }
}

