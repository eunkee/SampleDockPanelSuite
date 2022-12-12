using System;
using WeifenLuo.WinFormsUI.Docking;
using WeifenLuo.WinFormsUI.ThemeVS2012;

namespace SampleDockPanelSuite
{
    public class VS2015DarkThemeChild : VS2015DarkTheme
    {
        public void SetImageService(VS2015DarkThemeChild childTheme)
        {
            ImageService = new ImageService(childTheme);
        }
    }
}
