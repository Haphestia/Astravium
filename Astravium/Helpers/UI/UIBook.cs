namespace Astravium.Helpers.UI;

//note to self: look at ItemListMenu for a basic example
internal class UIBook : UI
{
    public override void Open()
    {
        Log.Info("Book opened!");
        base.Open();
    }
}
