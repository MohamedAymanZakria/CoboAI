using System.Collections.ObjectModel;

namespace CoboAI;

public partial class AiAssetsPage : ContentPage
{
    public ObservableCollection<Asset> Assets { get; } = new();

    public AiAssetsPage()
    {
        InitializeComponent();
        BindingContext = this;

        // Sample data
        Assets.Add(new Asset("Robot Model", "3D"));
        Assets.Add(new Asset("Car Dataset", "Images"));
        Assets.Add(new Asset("Vision Model", "AI"));
    }
}

public record Asset(string Name, string Type);
