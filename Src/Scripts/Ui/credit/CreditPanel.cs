using System.Linq;
using DsUi;
using Godot;
using GTweens.Extensions;
using GTweensGodot.Extensions;

namespace NovaDrift.Scripts.Ui.Credit;

public partial class CreditPanel : Credit
{
    private readonly string[][] _infos = [
        ["编程", "花神", "AcidWallStudio", "B-TO-THE-R"],
        ["美术", "花神", "AcidWallStudio", "B-TO-THE-R"],
        ["设计", "花神", "AcidWallStudio", "B-TO-THE-R"],
        ["音频", "花神", "AcidWallStudio", "B-TO-THE-R"],
        ["市场", "花神", "AcidWallStudio", "B-TO-THE-R"],
        ["其他", "花神", "AcidWallStudio", "B-TO-THE-R"],
        ["特殊鸣谢", "Atelier Magicae @Itch", "Riria/Ririsaurus", "忘忧の Daylily-Zeleen"],
    ];

    public override void _Ready()
    {
        GenerateUi();
        S_CloseBtn.Instance.Pressed += () =>
        {
            this.ChangeTo(UiManager.Get_StartMenu_Instance().First());
        };
        PlayAnimation();
    }

    private async void PlayAnimation()
    {
        await ToSignal(GetTree().CreateTimer(1.0f), Timer.SignalName.Timeout);
        GTweenExtensions.Tween(
                () => S_Scroll.Instance.ScrollVertical,
                f => S_Scroll.Instance.ScrollVertical = (int)f,
                (float)S_Scroll.Instance.GetVScrollBar().MaxValue,
                20f
            )
            .Play();
    }

    private void GenerateUi()
    {
        var titleSetting = GD.Load<LabelSettings>("res://Assets/LabelSettings/SubTitleWhite.tres");
        var contentSetting = GD.Load<LabelSettings>("res://Assets/LabelSettings/BoldGray44.tres");
        
        foreach (var info in _infos)
        {
            var container = new Godot.VBoxContainer();
            container.Set("theme_override_constants/separation", 30f);
            S_Items.AddChild(container);

            var title = new Godot.Label()
            {
                HorizontalAlignment = HorizontalAlignment.Center,
                LabelSettings = titleSetting,
                Text = info[0],
            };
            
            container.AddChild(title);
            
            foreach (var item in info.Skip(1))
            {
                var content = new Godot.Label()
                {
                    HorizontalAlignment = HorizontalAlignment.Center,
                    LabelSettings = contentSetting,
                    Text = item,
                };
                
                container.AddChild(content);
            }
        }
    }

    public override void OnCreateUi()
    {
        
    }

    public override void OnDestroyUi()
    {
        
    }

}
