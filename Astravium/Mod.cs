using Astravium.Helpers;
using StardewModdingAPI;
using StardewModdingAPI.Events;
using StardewValley;

namespace Astravium;

internal sealed class Mod : StardewModdingAPI.Mod
{
    public override void Entry(IModHelper helper)
    {
        Log.Configure(Monitor);
        helper.Events.Input.ButtonPressed += this.OnButtonPressed;
    }

    private void OnButtonPressed(object? sender, ButtonPressedEventArgs e)
    {
        if (!Context.IsWorldReady) return;

        if(e.Button == SButton.L)
        {
            Log.Info("L was pressed!");
            new Helpers.UI.UIBook().Open();
        }
    }
}