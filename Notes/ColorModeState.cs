using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//https://metanit.com/sharp/patterns/2.3.php

namespace Notes;

class Colors
{
    static public Color lightPrimary = Color.FromArgb(255, 255, 255);
    static public Color lightSecondary = Color.FromArgb(238, 238, 238);
    static public Color darkPrimary = Color.FromArgb(39, 40, 41);
    static public Color darkSecondary = Color.FromArgb(57, 62, 70);
    static public Color accent = Color.FromArgb(253, 112, 20);
}

internal class ColorModeState
{
    private static ColorModeState instance;

    public string mode = "dark";

    public Color bgPrimary { get; private set; } = Colors.darkPrimary;
    public Color bgSecondary { get; private set; } = Colors.darkSecondary;
    public Color textPrimary { get; private set; } = Colors.lightPrimary;
    public Color textSecondary { get; private set; } = Colors.lightSecondary;
    public Color accent { get; private set; } = Colors.accent;

    private ColorModeState(string mode)
    {
        this.mode = mode;
        this.accent = Colors.accent;
        changeColorTheme();
    }

    private void changeColorTheme()
    {
        this.bgPrimary = this.mode == "dark" ? Colors.darkPrimary : Colors.lightPrimary;
        this.bgSecondary = this.mode == "dark" ? Colors.darkPrimary : Colors.lightPrimary;
        this.textPrimary = this.mode == "dark" ? Colors.lightPrimary : Colors.darkPrimary;
        this.textSecondary = this.mode == "dark" ? Colors.lightSecondary : Colors.darkSecondary;
    }

    public static ColorModeState getInstance()
    {
        return instance;
    }

    public static void createInstance(string mode)
    {
        instance = new ColorModeState(mode);
        instance.changeColorTheme();
    }

    public void setColorMode(string mode)
    {
        instance.mode = mode;
        changeColorTheme();
    }
}
