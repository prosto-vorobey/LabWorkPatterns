using System.Collections.Generic;
using System.Drawing;

public static class ColorFormStyle
{
    private static Dictionary<string, string> _colorsDictionary = new Dictionary<string, string>()
    {
        { "colorLightFormBack", "#f3e3ff" },
        { "colorLightPanelSideMenu", "#f0dbff" },
        { "colorLightPanelSubMenu", "#eacdff" },
        { "colorLightPanelDrawing", "#fbf5ff"},
        { "colorLightFont", "#2c2b2c" },
        { "colorDarkFormBack", "#0a111c" },
        { "colorDarkPanelSideMenu", "#0e1828" },
        { "colorDarkPanelSubMenu", "#232c4c" },
        { "colorDarkPanelDrawing", "#272f3d"},
        { "colorDarkFont", "#fafff2" },

    };
    public static Color GetColorStyle (string keyString)
    {
        return ColorTranslator.FromHtml(_colorsDictionary[keyString]);

    }

}