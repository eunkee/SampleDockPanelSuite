using System;

public class VS2015DarkThemeChild : VS2015DarkTheme
{
    public void SetImageService(VS2015DarkThemeChild childTheme)
    {
        ImageService = new ImageService(childTheme);
    }
}
