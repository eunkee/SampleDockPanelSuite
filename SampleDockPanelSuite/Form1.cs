using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace SampleDockPanelSuite
{
    public partial class Form1 : Form
    {
        private bool m_bSaveLayout = false;
        private DeserializeDockContent m_deserializeDockContent;
        private FormOutput1 m_outputWindow1;
        private FormOutput2 m_outputWindow2;
        private readonly VisualStudioToolStripExtender vsToolStripExtender1;

        public Form1()
        {
            this.components = new Container();
            vsToolStripExtender1 = new VisualStudioToolStripExtender(this.components)
            {
                DefaultRenderer = null
            };

            InitializeComponent();
            AutoScaleMode = AutoScaleMode.Dpi;
        }
        private void Form1_Load(object sender, EventArgs e)
        {


            m_deserializeDockContent = new DeserializeDockContent(GetContentFromPersistString);
            m_outputWindow1 = new FormOutput1();
            m_outputWindow2 = new FormOutput2();

            //테마 적용
            var theme = RegistryDockSample.Theme;
            if (theme == CUSTOM_THEME.BLACK)
            {
                SetSchema(this.menuItemSchemaVS2015Dark, null);
            }
            else if (theme == CUSTOM_THEME.BLUE)
            {
                SetSchema(this.menuItemSchemaVS2015Blue, null);
            }
            else if (theme == CUSTOM_THEME.LIGHT)
            {
                SetSchema(this.menuItemSchemaVS2015Light, null);
            }
            else
            {
                SetSchema(this.menuItemSchemaVS2015Dark, null);
            }

            //체크상태 적용
            menuItemSchemaVS2015Light.Checked = (sender == menuItemSchemaVS2015Light);
            menuItemSchemaVS2015Blue.Checked = (sender == menuItemSchemaVS2015Blue);
            menuItemSchemaVS2015Dark.Checked = (sender == menuItemSchemaVS2015Dark);


            SetAllowEndUserDocking(RegistryDockSample.AllowEndUserDocking);
            dockPanel.DocumentStyle = DocumentStyle.DockingSdi;


            //처음 메인 패널 없을 때 생성방법
            //FormDashboard formDashboard = new(this);
            //formDashboard.Show(dockPanel);

            //도킹패널 컨피그 로드
            string configFile = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "DockPanel.config");
            if (File.Exists(configFile))
                dockPanel.LoadFromXml(configFile, m_deserializeDockContent);

            m_bSaveLayout = true;

            //mainMenu.Visible = false;
        }

        private IDockContent GetContentFromPersistString(string persistString)
        {
            if (persistString == typeof(FormOutput1).ToString())
                return m_outputWindow1;
            else if (persistString == typeof(FormOutput2).ToString())
                return m_outputWindow2;
            else
            {
                FormDashboard formDashboard = new(this);
                return formDashboard;
            }
        }

        private void InitDockPanal()
        {
            if (m_outputWindow1 != null && m_outputWindow2 != null)
            {
                m_outputWindow1.DockPanel = null;
                m_outputWindow2.DockPanel = null;
                foreach (IDockContent document in dockPanel.DocumentsToArray())
                {
                    // IMPORANT: dispose all panes.
                    document.DockHandler.DockPanel = null;
                    document.DockHandler.Close();
                }
                foreach (var window in dockPanel.FloatWindows.ToList())
                    window.Dispose();
            }
        }

        private void SetSchema(object sender, System.EventArgs e)
        {
            //현재 닥 패널 상태 임시 저장
            string configFile = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "DockPanel.temp.config");
            dockPanel.SaveAsXml(configFile);

            //닥패널 초기화
            InitDockPanal();

            //테마 적용
            if (sender == this.menuItemSchemaVS2015Blue)
            {
                this.dockPanel.Theme = this.vS2015BlueTheme1;
                vsToolStripExtender1.SetStyle(this.mainMenu, VisualStudioToolStripExtender.VsVersion.Vs2015, vS2015BlueTheme1);
                RegistryDockSample.Theme = CUSTOM_THEME.BLUE;
            }
            else if (sender == this.menuItemSchemaVS2015Light)
            {
                this.dockPanel.Theme = this.vS2015LightTheme1;
                vsToolStripExtender1.SetStyle(this.mainMenu, VisualStudioToolStripExtender.VsVersion.Vs2015, vS2015LightTheme1);
                RegistryDockSample.Theme = CUSTOM_THEME.LIGHT;
            }
            else if (sender == this.menuItemSchemaVS2015Dark)
            {

                ThemeBase defaultTheme = CreateCustomDarkTheme();
                this.dockPanel.Theme = defaultTheme;

                //this.dockPanel.Theme = this.vS2015DarkTheme1;
                vsToolStripExtender1.SetStyle(this.mainMenu, VisualStudioToolStripExtender.VsVersion.Vs2015, this.dockPanel.Theme);
                RegistryDockSample.Theme = CUSTOM_THEME.BLACK;
            }

            //체크상태 적용
            menuItemSchemaVS2015Light.Checked = (sender == menuItemSchemaVS2015Light);
            menuItemSchemaVS2015Blue.Checked = (sender == menuItemSchemaVS2015Blue);
            menuItemSchemaVS2015Dark.Checked = (sender == menuItemSchemaVS2015Dark);

            //임시 저장했던 닥 패널 불러오기
            if (File.Exists(configFile))
                dockPanel.LoadFromXml(configFile, m_deserializeDockContent);
        }

        public static System.Drawing.Color LIGHT_COLOR = System.Drawing.Color.FromArgb(91, 190, 202);
        public static System.Drawing.Color LINE_COLOR = System.Drawing.Color.FromArgb(21, 32, 54);
        public static System.Drawing.Color BACKGROUND_COLOR = System.Drawing.Color.FromArgb(16, 15, 27);
        public static System.Drawing.Color BUTTON_BACKGROUND_COLOR = System.Drawing.Color.FromArgb(30, 34, 50);
        public static System.Drawing.Color TEXT_COLOR_NORMAL = System.Drawing.Color.FromArgb(152, 173, 192);
        public static System.Drawing.Color TEXT_COLOR_DARK = System.Drawing.Color.FromArgb(79, 90, 108);
        public static System.Drawing.Color TEXT_COLOR_WHITE = System.Drawing.Color.FromArgb(230, 232, 235);

        private VS2015DarkThemeChild CreateCustomDarkTheme()
        {
            VS2015DarkThemeChild customTheme = new VS2015DarkThemeChild();
            customTheme.ColorPalette.DockTarget.GlyphBorder = LIGHT_COLOR;
            customTheme.ColorPalette.CommandBarToolbarOverflowHovered.Background = Color.FromArgb(114, 91, 190, 202);
            customTheme.ColorPalette.MainWindowActive.Background = BACKGROUND_COLOR;

            // 바 캡션 타이틀
            customTheme.ColorPalette.ToolWindowCaptionActive.Text = LIGHT_COLOR;
            customTheme.ColorPalette.ToolWindowCaptionActive.Grip = LINE_COLOR;
            customTheme.ColorPalette.ToolWindowCaptionActive.Background = LINE_COLOR;
            customTheme.ColorPalette.ToolWindowCaptionInactive.Text = TEXT_COLOR_NORMAL;
            customTheme.ColorPalette.ToolWindowCaptionInactive.Grip = LINE_COLOR;
            customTheme.ColorPalette.ToolWindowCaptionInactive.Background = LINE_COLOR;

            // 바 캡션 버튼
            customTheme.ColorPalette.ToolWindowCaptionActive.Button = LIGHT_COLOR;
            customTheme.ColorPalette.ToolWindowCaptionInactive.Button = TEXT_COLOR_NORMAL;

            // 버튼 테두리
            customTheme.ColorPalette.TabButtonUnselectedTabHoveredButtonHovered.Background = LIGHT_COLOR;
            customTheme.ColorPalette.TabButtonUnselectedTabHoveredButtonHovered.Border = LIGHT_COLOR;
            customTheme.ColorPalette.ToolWindowCaptionButtonActiveHovered.Background = LIGHT_COLOR;
            customTheme.ColorPalette.ToolWindowCaptionButtonActiveHovered.Border = LIGHT_COLOR;

            // 탭 색상
            customTheme.ColorPalette.ToolWindowTabSelectedInactive.Background = BUTTON_BACKGROUND_COLOR;
            customTheme.ColorPalette.ToolWindowTabSelectedInactive.Text = TEXT_COLOR_WHITE;
            customTheme.ColorPalette.ToolWindowTabUnselected.Text = TEXT_COLOR_NORMAL;
            customTheme.ColorPalette.ToolWindowTabUnselectedHovered.Background = Color.FromArgb(66, 84, 119);
            customTheme.ColorPalette.ToolWindowTabUnselectedHovered.Text = TEXT_COLOR_WHITE;

            // Auto Hide
            customTheme.ColorPalette.AutoHideStripDefault.Background = BUTTON_BACKGROUND_COLOR;
            customTheme.ColorPalette.AutoHideStripDefault.Text = TEXT_COLOR_NORMAL;
            customTheme.ColorPalette.AutoHideStripDefault.Border = TEXT_COLOR_DARK;
            customTheme.ColorPalette.AutoHideStripHovered.Background = BUTTON_BACKGROUND_COLOR;
            customTheme.ColorPalette.AutoHideStripHovered.Text = TEXT_COLOR_NORMAL;
            customTheme.ColorPalette.AutoHideStripHovered.Border = LIGHT_COLOR;

            // 바 테두리
            customTheme.ColorPalette.ToolWindowBorder = Color.FromArgb(40, 41, 56);

            customTheme.Skin.AutoHideStripSkin.TextFont = new Font("Noto Sans CJK KR Regular", 9.75F);
            customTheme.Skin.DockPaneStripSkin.TextFont = new Font("Noto Sans CJK KR Regular", 9.75F);

            customTheme.Skin.AutoHideStripSkin.DockStripBackground.StartColor = BUTTON_BACKGROUND_COLOR;
            customTheme.Skin.AutoHideStripSkin.DockStripBackground.EndColor = BUTTON_BACKGROUND_COLOR;

            customTheme.ColorPalette.TabSelectedInactive.Background = BUTTON_BACKGROUND_COLOR;
            customTheme.ColorPalette.ToolWindowCaptionInactive.Background = BUTTON_BACKGROUND_COLOR;
            customTheme.ColorPalette.ToolWindowCaptionInactive.Grip = BUTTON_BACKGROUND_COLOR;
            customTheme.ColorPalette.ToolWindowTabUnselected.Background = BUTTON_BACKGROUND_COLOR;
            
            customTheme.SetImageService(customTheme);

            return customTheme;
        }

        private void MenuItemExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MenuItemLockLayout_Click(object sender, EventArgs e)
        {
            bool IsRunAllow = !dockPanel.AllowEndUserDocking;
            SetAllowEndUserDocking(IsRunAllow);
            RegistryDockSample.AllowEndUserDocking = IsRunAllow;
        }

        //레이아웃 패널 허용/잠그기 제어
        private void SetAllowEndUserDocking(bool IsAllow)
        {
            dockPanel.AllowEndUserDocking = IsAllow;
            menuItemLockLayout.Checked = !IsAllow;
        }

        private void MenuItemDefaultLayout_Click(object sender, EventArgs e)
        {
            //load dockpanel default config
            string configFile = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "DockPanel.default.config");
            if (File.Exists(configFile))
            {
                InitDockPanal();
                dockPanel.LoadFromXml(configFile, m_deserializeDockContent);
            }
        }

        private void MenuItemSaveLayout_Click(object sender, EventArgs e)
        {
            //save dockpanel config
            string configFile = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "DockPanel.custom.config");
            dockPanel.SaveAsXml(configFile);
        }

        private void MenuItemLoadLayout_Click(object sender, EventArgs e)
        {
            //load dockpanel saved config
            string configFile = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "DockPanel.custom.config");
            if (File.Exists(configFile))
            {
                InitDockPanal();
                dockPanel.LoadFromXml(configFile, m_deserializeDockContent);
            }
            else
            {
                MessageBox.Show("저장된 레이아웃이 없습니다.");
            }
        }

        private void MenuItemViewLog1_Click(object sender, EventArgs e)
        {
            m_outputWindow1.Show(dockPanel);
        }

        private void MenuItemViewLog2_Click(object sender, EventArgs e)
        {
            m_outputWindow2.Show(dockPanel);
        }

        private void MenuItemAbout_Click(object sender, EventArgs e)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            System.Diagnostics.FileVersionInfo fvi = System.Diagnostics.FileVersionInfo.GetVersionInfo(assembly.Location);
            string strmsg = $"{fvi.ProductName}\r\nVersion: {fvi.FileVersion}";
            MessageBox.Show(new Form() { WindowState = FormWindowState.Maximized, TopMost = true },
                        strmsg, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                //Save Config
                string configFile = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "DockPanel.config");
                if (m_bSaveLayout)
                {
                    dockPanel.SaveAsXml(configFile);
                }
            }
            catch { }
        }

        private void mainMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
