using Microsoft.Win32;
using System;

namespace SampleDockPanelSuite
{
    public enum CUSTOM_THEME
    {
        BLACK = 0,
        BLUE = 1,
        LIGHT = 2
    }
    public class RegistryDockSample
    {
        private static readonly RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\DockSample", true);
        private static readonly RegistryKey RegKey = registryKey;
        private static readonly object regObject = new();

        //Set 2015테마 0:Black 1:Blue 2:Light
        public static CUSTOM_THEME Theme
        {
            get
            {
                CUSTOM_THEME rslt = CUSTOM_THEME.BLACK;
                if (RegKey != null)
                {
                    lock (regObject)
                    {
                        try
                        {
                            rslt = (CUSTOM_THEME)Convert.ToInt32(RegKey.GetValue("Theme", "0"));
                        }
                        catch { }
                    }
                }
                return rslt;
            }
            set
            {
                lock (regObject)
                {
                    if (RegKey != null)
                    {
                        try
                        {
                            RegKey.SetValue("Theme", value.ToString());
                        }
                        catch { }
                    }
                }
            }
        }

        //레이아웃 패널 이동 true:허용 false:락
        public static bool AllowEndUserDocking
        {
            get
            {
                bool rslt = true;
                if (RegKey != null)
                {
                    lock (regObject)
                    {
                        try
                        {
                            if (Convert.ToString(RegKey.GetValue("AllowDocking", "True")) == "True")
                            {
                                rslt = true;
                            }
                            else
                            {
                                rslt = false;
                            }
                        }
                        catch { }
                    }
                }
                return rslt;
            }
            set
            {
                lock (regObject)
                {
                    if (RegKey != null)
                    {
                        try
                        {
                            RegKey.SetValue("AllowDocking", value.ToString());
                        }
                        catch { }
                    }
                }
            }
        }
    }
}
