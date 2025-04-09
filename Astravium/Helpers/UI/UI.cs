using StardewValley.Menus;
using StardewValley;

namespace Astravium.Helpers.UI;

internal class UI : IClickableMenu
{
    private static List<UI> _openUis = new();
    public bool IsOpen { get; private set; } = false;

    public virtual void Open()
    {
        Open(this);
    }
    public static void Open(UI ui, bool force = false)
    {
        _openUis.Add(ui);
        if (force && Game1.activeClickableMenu != null)
        {
            Game1.activeClickableMenu.emergencyShutDown();
            Game1.activeClickableMenu = null;
        }
        if (Game1.activeClickableMenu == null)
        {
            Game1.activeClickableMenu = ui;
            ui.IsOpen = true;
        }
    }

    public virtual void Close()
    {
        Close(this);
    }
    public static void Close(UI ui)
    {
        if (Game1.activeClickableMenu == ui)
        {
            Game1.activeClickableMenu = null;
        }
        if (_openUis.Contains(ui)) _openUis.Remove(ui);
        ui.IsOpen = false;
    }

    public static void CloseAll()
    {
        foreach (var ui in _openUis) Close(ui);
    }

    public override void emergencyShutDown()
    {
        Close();
        base.emergencyShutDown();
    }
}
