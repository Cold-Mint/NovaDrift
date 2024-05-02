namespace DsUi;

// 该类为自动生成的, 请不要手动编辑, 以免造成代码丢失
public static partial class UiManager
{

    public static class UiName
    {
        public const string AbilityItem = "AbilityItem";
        public const string AbilityPanel = "AbilityPanel";
        public const string AbilityTree = "AbilityTree";
        public const string DamageLabel = "DamageLabel";
        public const string GalleryBtn = "GalleryBtn";
        public const string GameOver = "GameOver";
        public const string Hud = "Hud";
        public const string PausedMenu = "PausedMenu";
        public const string SalvoBulletCount = "SalvoBulletCount";
        public const string SelectAbility = "SelectAbility";
        public const string Setting = "Setting";
        public const string StartMenu = "StartMenu";
        public const string StatsMonitor = "StatsMonitor";
        public const string StatsMonitorItem = "StatsMonitorItem";
    }

    /// <summary>
    /// 创建 AbilityItem, 并返回UI实例, 该函数不会打开 Ui
    /// </summary>
    public static NovaDrift.Scripts.Ui.AbilityItem.AbilityItemPanel Create_AbilityItem()
    {
        return CreateUi<NovaDrift.Scripts.Ui.AbilityItem.AbilityItemPanel>(UiName.AbilityItem);
    }

    /// <summary>
    /// 打开 AbilityItem, 并返回UI实例
    /// </summary>
    public static NovaDrift.Scripts.Ui.AbilityItem.AbilityItemPanel Open_AbilityItem()
    {
        return OpenUi<NovaDrift.Scripts.Ui.AbilityItem.AbilityItemPanel>(UiName.AbilityItem);
    }

    /// <summary>
    /// 隐藏 AbilityItem 的所有实例
    /// </summary>
    public static void Hide_AbilityItem()
    {
        var uiInstance = Get_AbilityItem_Instance();
        foreach (var uiPanel in uiInstance)
        {
            uiPanel.HideUi();
        }
    }

    /// <summary>
    /// 销毁 AbilityItem 的所有实例
    /// </summary>
    public static void Destroy_AbilityItem()
    {
        var uiInstance = Get_AbilityItem_Instance();
        foreach (var uiPanel in uiInstance)
        {
            uiPanel.Destroy();
        }
    }

    /// <summary>
    /// 获取所有 AbilityItem 的实例, 如果没有实例, 则返回一个空数组
    /// </summary>
    public static NovaDrift.Scripts.Ui.AbilityItem.AbilityItemPanel[] Get_AbilityItem_Instance()
    {
        return GetUiInstance<NovaDrift.Scripts.Ui.AbilityItem.AbilityItemPanel>(nameof(NovaDrift.Scripts.Ui.AbilityItem.AbilityItem));
    }

    /// <summary>
    /// 创建 AbilityPanel, 并返回UI实例, 该函数不会打开 Ui
    /// </summary>
    public static NovaDrift.Scripts.Ui.AbilityPanel.AbilityPanelPanel Create_AbilityPanel()
    {
        return CreateUi<NovaDrift.Scripts.Ui.AbilityPanel.AbilityPanelPanel>(UiName.AbilityPanel);
    }

    /// <summary>
    /// 打开 AbilityPanel, 并返回UI实例
    /// </summary>
    public static NovaDrift.Scripts.Ui.AbilityPanel.AbilityPanelPanel Open_AbilityPanel()
    {
        return OpenUi<NovaDrift.Scripts.Ui.AbilityPanel.AbilityPanelPanel>(UiName.AbilityPanel);
    }

    /// <summary>
    /// 隐藏 AbilityPanel 的所有实例
    /// </summary>
    public static void Hide_AbilityPanel()
    {
        var uiInstance = Get_AbilityPanel_Instance();
        foreach (var uiPanel in uiInstance)
        {
            uiPanel.HideUi();
        }
    }

    /// <summary>
    /// 销毁 AbilityPanel 的所有实例
    /// </summary>
    public static void Destroy_AbilityPanel()
    {
        var uiInstance = Get_AbilityPanel_Instance();
        foreach (var uiPanel in uiInstance)
        {
            uiPanel.Destroy();
        }
    }

    /// <summary>
    /// 获取所有 AbilityPanel 的实例, 如果没有实例, 则返回一个空数组
    /// </summary>
    public static NovaDrift.Scripts.Ui.AbilityPanel.AbilityPanelPanel[] Get_AbilityPanel_Instance()
    {
        return GetUiInstance<NovaDrift.Scripts.Ui.AbilityPanel.AbilityPanelPanel>(nameof(NovaDrift.Scripts.Ui.AbilityPanel.AbilityPanel));
    }

    /// <summary>
    /// 创建 AbilityTree, 并返回UI实例, 该函数不会打开 Ui
    /// </summary>
    public static NovaDrift.Scripts.Ui.AbilityTree.AbilityTreePanel Create_AbilityTree()
    {
        return CreateUi<NovaDrift.Scripts.Ui.AbilityTree.AbilityTreePanel>(UiName.AbilityTree);
    }

    /// <summary>
    /// 打开 AbilityTree, 并返回UI实例
    /// </summary>
    public static NovaDrift.Scripts.Ui.AbilityTree.AbilityTreePanel Open_AbilityTree()
    {
        return OpenUi<NovaDrift.Scripts.Ui.AbilityTree.AbilityTreePanel>(UiName.AbilityTree);
    }

    /// <summary>
    /// 隐藏 AbilityTree 的所有实例
    /// </summary>
    public static void Hide_AbilityTree()
    {
        var uiInstance = Get_AbilityTree_Instance();
        foreach (var uiPanel in uiInstance)
        {
            uiPanel.HideUi();
        }
    }

    /// <summary>
    /// 销毁 AbilityTree 的所有实例
    /// </summary>
    public static void Destroy_AbilityTree()
    {
        var uiInstance = Get_AbilityTree_Instance();
        foreach (var uiPanel in uiInstance)
        {
            uiPanel.Destroy();
        }
    }

    /// <summary>
    /// 获取所有 AbilityTree 的实例, 如果没有实例, 则返回一个空数组
    /// </summary>
    public static NovaDrift.Scripts.Ui.AbilityTree.AbilityTreePanel[] Get_AbilityTree_Instance()
    {
        return GetUiInstance<NovaDrift.Scripts.Ui.AbilityTree.AbilityTreePanel>(nameof(NovaDrift.Scripts.Ui.AbilityTree.AbilityTree));
    }

    /// <summary>
    /// 创建 DamageLabel, 并返回UI实例, 该函数不会打开 Ui
    /// </summary>
    public static NovaDrift.Scripts.Ui.DamageLabel.DamageLabelPanel Create_DamageLabel()
    {
        return CreateUi<NovaDrift.Scripts.Ui.DamageLabel.DamageLabelPanel>(UiName.DamageLabel);
    }

    /// <summary>
    /// 打开 DamageLabel, 并返回UI实例
    /// </summary>
    public static NovaDrift.Scripts.Ui.DamageLabel.DamageLabelPanel Open_DamageLabel()
    {
        return OpenUi<NovaDrift.Scripts.Ui.DamageLabel.DamageLabelPanel>(UiName.DamageLabel);
    }

    /// <summary>
    /// 隐藏 DamageLabel 的所有实例
    /// </summary>
    public static void Hide_DamageLabel()
    {
        var uiInstance = Get_DamageLabel_Instance();
        foreach (var uiPanel in uiInstance)
        {
            uiPanel.HideUi();
        }
    }

    /// <summary>
    /// 销毁 DamageLabel 的所有实例
    /// </summary>
    public static void Destroy_DamageLabel()
    {
        var uiInstance = Get_DamageLabel_Instance();
        foreach (var uiPanel in uiInstance)
        {
            uiPanel.Destroy();
        }
    }

    /// <summary>
    /// 获取所有 DamageLabel 的实例, 如果没有实例, 则返回一个空数组
    /// </summary>
    public static NovaDrift.Scripts.Ui.DamageLabel.DamageLabelPanel[] Get_DamageLabel_Instance()
    {
        return GetUiInstance<NovaDrift.Scripts.Ui.DamageLabel.DamageLabelPanel>(nameof(NovaDrift.Scripts.Ui.DamageLabel.DamageLabel));
    }

    /// <summary>
    /// 创建 GalleryBtn, 并返回UI实例, 该函数不会打开 Ui
    /// </summary>
    public static NovaDrift.Scripts.Ui.GalleryBtn.GalleryBtnPanel Create_GalleryBtn()
    {
        return CreateUi<NovaDrift.Scripts.Ui.GalleryBtn.GalleryBtnPanel>(UiName.GalleryBtn);
    }

    /// <summary>
    /// 打开 GalleryBtn, 并返回UI实例
    /// </summary>
    public static NovaDrift.Scripts.Ui.GalleryBtn.GalleryBtnPanel Open_GalleryBtn()
    {
        return OpenUi<NovaDrift.Scripts.Ui.GalleryBtn.GalleryBtnPanel>(UiName.GalleryBtn);
    }

    /// <summary>
    /// 隐藏 GalleryBtn 的所有实例
    /// </summary>
    public static void Hide_GalleryBtn()
    {
        var uiInstance = Get_GalleryBtn_Instance();
        foreach (var uiPanel in uiInstance)
        {
            uiPanel.HideUi();
        }
    }

    /// <summary>
    /// 销毁 GalleryBtn 的所有实例
    /// </summary>
    public static void Destroy_GalleryBtn()
    {
        var uiInstance = Get_GalleryBtn_Instance();
        foreach (var uiPanel in uiInstance)
        {
            uiPanel.Destroy();
        }
    }

    /// <summary>
    /// 获取所有 GalleryBtn 的实例, 如果没有实例, 则返回一个空数组
    /// </summary>
    public static NovaDrift.Scripts.Ui.GalleryBtn.GalleryBtnPanel[] Get_GalleryBtn_Instance()
    {
        return GetUiInstance<NovaDrift.Scripts.Ui.GalleryBtn.GalleryBtnPanel>(nameof(NovaDrift.Scripts.Ui.GalleryBtn.GalleryBtn));
    }

    /// <summary>
    /// 创建 GameOver, 并返回UI实例, 该函数不会打开 Ui
    /// </summary>
    public static NovaDrift.Scripts.Ui.GameOver.GameOverPanel Create_GameOver()
    {
        return CreateUi<NovaDrift.Scripts.Ui.GameOver.GameOverPanel>(UiName.GameOver);
    }

    /// <summary>
    /// 打开 GameOver, 并返回UI实例
    /// </summary>
    public static NovaDrift.Scripts.Ui.GameOver.GameOverPanel Open_GameOver()
    {
        return OpenUi<NovaDrift.Scripts.Ui.GameOver.GameOverPanel>(UiName.GameOver);
    }

    /// <summary>
    /// 隐藏 GameOver 的所有实例
    /// </summary>
    public static void Hide_GameOver()
    {
        var uiInstance = Get_GameOver_Instance();
        foreach (var uiPanel in uiInstance)
        {
            uiPanel.HideUi();
        }
    }

    /// <summary>
    /// 销毁 GameOver 的所有实例
    /// </summary>
    public static void Destroy_GameOver()
    {
        var uiInstance = Get_GameOver_Instance();
        foreach (var uiPanel in uiInstance)
        {
            uiPanel.Destroy();
        }
    }

    /// <summary>
    /// 获取所有 GameOver 的实例, 如果没有实例, 则返回一个空数组
    /// </summary>
    public static NovaDrift.Scripts.Ui.GameOver.GameOverPanel[] Get_GameOver_Instance()
    {
        return GetUiInstance<NovaDrift.Scripts.Ui.GameOver.GameOverPanel>(nameof(NovaDrift.Scripts.Ui.GameOver.GameOver));
    }

    /// <summary>
    /// 创建 Hud, 并返回UI实例, 该函数不会打开 Ui
    /// </summary>
    public static NovaDrift.Scripts.Ui.Hud.HudPanel Create_Hud()
    {
        return CreateUi<NovaDrift.Scripts.Ui.Hud.HudPanel>(UiName.Hud);
    }

    /// <summary>
    /// 打开 Hud, 并返回UI实例
    /// </summary>
    public static NovaDrift.Scripts.Ui.Hud.HudPanel Open_Hud()
    {
        return OpenUi<NovaDrift.Scripts.Ui.Hud.HudPanel>(UiName.Hud);
    }

    /// <summary>
    /// 隐藏 Hud 的所有实例
    /// </summary>
    public static void Hide_Hud()
    {
        var uiInstance = Get_Hud_Instance();
        foreach (var uiPanel in uiInstance)
        {
            uiPanel.HideUi();
        }
    }

    /// <summary>
    /// 销毁 Hud 的所有实例
    /// </summary>
    public static void Destroy_Hud()
    {
        var uiInstance = Get_Hud_Instance();
        foreach (var uiPanel in uiInstance)
        {
            uiPanel.Destroy();
        }
    }

    /// <summary>
    /// 获取所有 Hud 的实例, 如果没有实例, 则返回一个空数组
    /// </summary>
    public static NovaDrift.Scripts.Ui.Hud.HudPanel[] Get_Hud_Instance()
    {
        return GetUiInstance<NovaDrift.Scripts.Ui.Hud.HudPanel>(nameof(NovaDrift.Scripts.Ui.Hud.Hud));
    }

    /// <summary>
    /// 创建 PausedMenu, 并返回UI实例, 该函数不会打开 Ui
    /// </summary>
    public static NovaDrift.Scripts.Ui.PausedMenu.PausedMenuPanel Create_PausedMenu()
    {
        return CreateUi<NovaDrift.Scripts.Ui.PausedMenu.PausedMenuPanel>(UiName.PausedMenu);
    }

    /// <summary>
    /// 打开 PausedMenu, 并返回UI实例
    /// </summary>
    public static NovaDrift.Scripts.Ui.PausedMenu.PausedMenuPanel Open_PausedMenu()
    {
        return OpenUi<NovaDrift.Scripts.Ui.PausedMenu.PausedMenuPanel>(UiName.PausedMenu);
    }

    /// <summary>
    /// 隐藏 PausedMenu 的所有实例
    /// </summary>
    public static void Hide_PausedMenu()
    {
        var uiInstance = Get_PausedMenu_Instance();
        foreach (var uiPanel in uiInstance)
        {
            uiPanel.HideUi();
        }
    }

    /// <summary>
    /// 销毁 PausedMenu 的所有实例
    /// </summary>
    public static void Destroy_PausedMenu()
    {
        var uiInstance = Get_PausedMenu_Instance();
        foreach (var uiPanel in uiInstance)
        {
            uiPanel.Destroy();
        }
    }

    /// <summary>
    /// 获取所有 PausedMenu 的实例, 如果没有实例, 则返回一个空数组
    /// </summary>
    public static NovaDrift.Scripts.Ui.PausedMenu.PausedMenuPanel[] Get_PausedMenu_Instance()
    {
        return GetUiInstance<NovaDrift.Scripts.Ui.PausedMenu.PausedMenuPanel>(nameof(NovaDrift.Scripts.Ui.PausedMenu.PausedMenu));
    }

    /// <summary>
    /// 创建 SalvoBulletCount, 并返回UI实例, 该函数不会打开 Ui
    /// </summary>
    public static NovaDrift.Scripts.Ui.SalvoBulletCount.SalvoBulletCountPanel Create_SalvoBulletCount()
    {
        return CreateUi<NovaDrift.Scripts.Ui.SalvoBulletCount.SalvoBulletCountPanel>(UiName.SalvoBulletCount);
    }

    /// <summary>
    /// 打开 SalvoBulletCount, 并返回UI实例
    /// </summary>
    public static NovaDrift.Scripts.Ui.SalvoBulletCount.SalvoBulletCountPanel Open_SalvoBulletCount()
    {
        return OpenUi<NovaDrift.Scripts.Ui.SalvoBulletCount.SalvoBulletCountPanel>(UiName.SalvoBulletCount);
    }

    /// <summary>
    /// 隐藏 SalvoBulletCount 的所有实例
    /// </summary>
    public static void Hide_SalvoBulletCount()
    {
        var uiInstance = Get_SalvoBulletCount_Instance();
        foreach (var uiPanel in uiInstance)
        {
            uiPanel.HideUi();
        }
    }

    /// <summary>
    /// 销毁 SalvoBulletCount 的所有实例
    /// </summary>
    public static void Destroy_SalvoBulletCount()
    {
        var uiInstance = Get_SalvoBulletCount_Instance();
        foreach (var uiPanel in uiInstance)
        {
            uiPanel.Destroy();
        }
    }

    /// <summary>
    /// 获取所有 SalvoBulletCount 的实例, 如果没有实例, 则返回一个空数组
    /// </summary>
    public static NovaDrift.Scripts.Ui.SalvoBulletCount.SalvoBulletCountPanel[] Get_SalvoBulletCount_Instance()
    {
        return GetUiInstance<NovaDrift.Scripts.Ui.SalvoBulletCount.SalvoBulletCountPanel>(nameof(NovaDrift.Scripts.Ui.SalvoBulletCount.SalvoBulletCount));
    }

    /// <summary>
    /// 创建 SelectAbility, 并返回UI实例, 该函数不会打开 Ui
    /// </summary>
    public static NovaDrift.Scripts.Ui.SelectAbility.SelectAbilityPanel Create_SelectAbility()
    {
        return CreateUi<NovaDrift.Scripts.Ui.SelectAbility.SelectAbilityPanel>(UiName.SelectAbility);
    }

    /// <summary>
    /// 打开 SelectAbility, 并返回UI实例
    /// </summary>
    public static NovaDrift.Scripts.Ui.SelectAbility.SelectAbilityPanel Open_SelectAbility()
    {
        return OpenUi<NovaDrift.Scripts.Ui.SelectAbility.SelectAbilityPanel>(UiName.SelectAbility);
    }

    /// <summary>
    /// 隐藏 SelectAbility 的所有实例
    /// </summary>
    public static void Hide_SelectAbility()
    {
        var uiInstance = Get_SelectAbility_Instance();
        foreach (var uiPanel in uiInstance)
        {
            uiPanel.HideUi();
        }
    }

    /// <summary>
    /// 销毁 SelectAbility 的所有实例
    /// </summary>
    public static void Destroy_SelectAbility()
    {
        var uiInstance = Get_SelectAbility_Instance();
        foreach (var uiPanel in uiInstance)
        {
            uiPanel.Destroy();
        }
    }

    /// <summary>
    /// 获取所有 SelectAbility 的实例, 如果没有实例, 则返回一个空数组
    /// </summary>
    public static NovaDrift.Scripts.Ui.SelectAbility.SelectAbilityPanel[] Get_SelectAbility_Instance()
    {
        return GetUiInstance<NovaDrift.Scripts.Ui.SelectAbility.SelectAbilityPanel>(nameof(NovaDrift.Scripts.Ui.SelectAbility.SelectAbility));
    }

    /// <summary>
    /// 创建 Setting, 并返回UI实例, 该函数不会打开 Ui
    /// </summary>
    public static NovaDrift.Scripts.Ui.Setting.SettingPanel Create_Setting()
    {
        return CreateUi<NovaDrift.Scripts.Ui.Setting.SettingPanel>(UiName.Setting);
    }

    /// <summary>
    /// 打开 Setting, 并返回UI实例
    /// </summary>
    public static NovaDrift.Scripts.Ui.Setting.SettingPanel Open_Setting()
    {
        return OpenUi<NovaDrift.Scripts.Ui.Setting.SettingPanel>(UiName.Setting);
    }

    /// <summary>
    /// 隐藏 Setting 的所有实例
    /// </summary>
    public static void Hide_Setting()
    {
        var uiInstance = Get_Setting_Instance();
        foreach (var uiPanel in uiInstance)
        {
            uiPanel.HideUi();
        }
    }

    /// <summary>
    /// 销毁 Setting 的所有实例
    /// </summary>
    public static void Destroy_Setting()
    {
        var uiInstance = Get_Setting_Instance();
        foreach (var uiPanel in uiInstance)
        {
            uiPanel.Destroy();
        }
    }

    /// <summary>
    /// 获取所有 Setting 的实例, 如果没有实例, 则返回一个空数组
    /// </summary>
    public static NovaDrift.Scripts.Ui.Setting.SettingPanel[] Get_Setting_Instance()
    {
        return GetUiInstance<NovaDrift.Scripts.Ui.Setting.SettingPanel>(nameof(NovaDrift.Scripts.Ui.Setting.Setting));
    }

    /// <summary>
    /// 创建 StartMenu, 并返回UI实例, 该函数不会打开 Ui
    /// </summary>
    public static NovaDrift.Scripts.Ui.StartMenu.StartMenuPanel Create_StartMenu()
    {
        return CreateUi<NovaDrift.Scripts.Ui.StartMenu.StartMenuPanel>(UiName.StartMenu);
    }

    /// <summary>
    /// 打开 StartMenu, 并返回UI实例
    /// </summary>
    public static NovaDrift.Scripts.Ui.StartMenu.StartMenuPanel Open_StartMenu()
    {
        return OpenUi<NovaDrift.Scripts.Ui.StartMenu.StartMenuPanel>(UiName.StartMenu);
    }

    /// <summary>
    /// 隐藏 StartMenu 的所有实例
    /// </summary>
    public static void Hide_StartMenu()
    {
        var uiInstance = Get_StartMenu_Instance();
        foreach (var uiPanel in uiInstance)
        {
            uiPanel.HideUi();
        }
    }

    /// <summary>
    /// 销毁 StartMenu 的所有实例
    /// </summary>
    public static void Destroy_StartMenu()
    {
        var uiInstance = Get_StartMenu_Instance();
        foreach (var uiPanel in uiInstance)
        {
            uiPanel.Destroy();
        }
    }

    /// <summary>
    /// 获取所有 StartMenu 的实例, 如果没有实例, 则返回一个空数组
    /// </summary>
    public static NovaDrift.Scripts.Ui.StartMenu.StartMenuPanel[] Get_StartMenu_Instance()
    {
        return GetUiInstance<NovaDrift.Scripts.Ui.StartMenu.StartMenuPanel>(nameof(NovaDrift.Scripts.Ui.StartMenu.StartMenu));
    }

    /// <summary>
    /// 创建 StatsMonitor, 并返回UI实例, 该函数不会打开 Ui
    /// </summary>
    public static NovaDrift.Scripts.Ui.StatsMonitor.StatsMonitorPanel Create_StatsMonitor()
    {
        return CreateUi<NovaDrift.Scripts.Ui.StatsMonitor.StatsMonitorPanel>(UiName.StatsMonitor);
    }

    /// <summary>
    /// 打开 StatsMonitor, 并返回UI实例
    /// </summary>
    public static NovaDrift.Scripts.Ui.StatsMonitor.StatsMonitorPanel Open_StatsMonitor()
    {
        return OpenUi<NovaDrift.Scripts.Ui.StatsMonitor.StatsMonitorPanel>(UiName.StatsMonitor);
    }

    /// <summary>
    /// 隐藏 StatsMonitor 的所有实例
    /// </summary>
    public static void Hide_StatsMonitor()
    {
        var uiInstance = Get_StatsMonitor_Instance();
        foreach (var uiPanel in uiInstance)
        {
            uiPanel.HideUi();
        }
    }

    /// <summary>
    /// 销毁 StatsMonitor 的所有实例
    /// </summary>
    public static void Destroy_StatsMonitor()
    {
        var uiInstance = Get_StatsMonitor_Instance();
        foreach (var uiPanel in uiInstance)
        {
            uiPanel.Destroy();
        }
    }

    /// <summary>
    /// 获取所有 StatsMonitor 的实例, 如果没有实例, 则返回一个空数组
    /// </summary>
    public static NovaDrift.Scripts.Ui.StatsMonitor.StatsMonitorPanel[] Get_StatsMonitor_Instance()
    {
        return GetUiInstance<NovaDrift.Scripts.Ui.StatsMonitor.StatsMonitorPanel>(nameof(NovaDrift.Scripts.Ui.StatsMonitor.StatsMonitor));
    }

    /// <summary>
    /// 创建 StatsMonitorItem, 并返回UI实例, 该函数不会打开 Ui
    /// </summary>
    public static NovaDrift.Scripts.Ui.StatsMonitorItem.StatsMonitorItemPanel Create_StatsMonitorItem()
    {
        return CreateUi<NovaDrift.Scripts.Ui.StatsMonitorItem.StatsMonitorItemPanel>(UiName.StatsMonitorItem);
    }

    /// <summary>
    /// 打开 StatsMonitorItem, 并返回UI实例
    /// </summary>
    public static NovaDrift.Scripts.Ui.StatsMonitorItem.StatsMonitorItemPanel Open_StatsMonitorItem()
    {
        return OpenUi<NovaDrift.Scripts.Ui.StatsMonitorItem.StatsMonitorItemPanel>(UiName.StatsMonitorItem);
    }

    /// <summary>
    /// 隐藏 StatsMonitorItem 的所有实例
    /// </summary>
    public static void Hide_StatsMonitorItem()
    {
        var uiInstance = Get_StatsMonitorItem_Instance();
        foreach (var uiPanel in uiInstance)
        {
            uiPanel.HideUi();
        }
    }

    /// <summary>
    /// 销毁 StatsMonitorItem 的所有实例
    /// </summary>
    public static void Destroy_StatsMonitorItem()
    {
        var uiInstance = Get_StatsMonitorItem_Instance();
        foreach (var uiPanel in uiInstance)
        {
            uiPanel.Destroy();
        }
    }

    /// <summary>
    /// 获取所有 StatsMonitorItem 的实例, 如果没有实例, 则返回一个空数组
    /// </summary>
    public static NovaDrift.Scripts.Ui.StatsMonitorItem.StatsMonitorItemPanel[] Get_StatsMonitorItem_Instance()
    {
        return GetUiInstance<NovaDrift.Scripts.Ui.StatsMonitorItem.StatsMonitorItemPanel>(nameof(NovaDrift.Scripts.Ui.StatsMonitorItem.StatsMonitorItem));
    }

}
