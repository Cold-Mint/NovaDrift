namespace NovaDrift.Scripts.Ui.GoodsItem;

using DsUi;

/// <summary>
/// Ui代码, 该类是根据ui场景自动生成的, 请不要手动编辑该类, 以免造成代码丢失
/// </summary>
public abstract partial class GoodsItem : UiBase
{
    /// <summary>
    /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.PanelContainer"/>, 节点路径: GoodsItem.PanelContainer
    /// </summary>
    public PanelContainer L_PanelContainer
    {
        get
        {
            if (_L_PanelContainer == null) _L_PanelContainer = new PanelContainer((GoodsItemPanel)this, GetNode<Godot.PanelContainer>("PanelContainer"));
            return _L_PanelContainer;
        }
    }
    private PanelContainer _L_PanelContainer;


    public GoodsItem() : base(nameof(GoodsItem))
    {
    }

    public sealed override void OnInitNestedUi()
    {

    }

    /// <summary>
    /// 类型: <see cref="Godot.Control"/>, 路径: GoodsItem.PanelContainer.MarginContainer.VBoxContainer.Control
    /// </summary>
    public class Control : UiNode<GoodsItemPanel, Godot.Control, Control>
    {
        public Control(GoodsItemPanel uiPanel, Godot.Control node) : base(uiPanel, node) {  }
        public override Control Clone() => new (UiPanel, (Godot.Control)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.Label"/>, 路径: GoodsItem.PanelContainer.MarginContainer.VBoxContainer.TypeLabel
    /// </summary>
    public class TypeLabel : UiNode<GoodsItemPanel, Godot.Label, TypeLabel>
    {
        public TypeLabel(GoodsItemPanel uiPanel, Godot.Label node) : base(uiPanel, node) {  }
        public override TypeLabel Clone() => new (UiPanel, (Godot.Label)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.Label"/>, 路径: GoodsItem.PanelContainer.MarginContainer.VBoxContainer.NameLabel
    /// </summary>
    public class NameLabel : UiNode<GoodsItemPanel, Godot.Label, NameLabel>
    {
        public NameLabel(GoodsItemPanel uiPanel, Godot.Label node) : base(uiPanel, node) {  }
        public override NameLabel Clone() => new (UiPanel, (Godot.Label)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.VBoxContainer"/>, 路径: GoodsItem.PanelContainer.MarginContainer.VBoxContainer
    /// </summary>
    public class VBoxContainer : UiNode<GoodsItemPanel, Godot.VBoxContainer, VBoxContainer>
    {
        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.Control"/>, 节点路径: GoodsItem.PanelContainer.MarginContainer.Control
        /// </summary>
        public Control L_Control
        {
            get
            {
                if (_L_Control == null) _L_Control = new Control(UiPanel, Instance.GetNode<Godot.Control>("Control"));
                return _L_Control;
            }
        }
        private Control _L_Control;

        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.Label"/>, 节点路径: GoodsItem.PanelContainer.MarginContainer.TypeLabel
        /// </summary>
        public TypeLabel L_TypeLabel
        {
            get
            {
                if (_L_TypeLabel == null) _L_TypeLabel = new TypeLabel(UiPanel, Instance.GetNode<Godot.Label>("TypeLabel"));
                return _L_TypeLabel;
            }
        }
        private TypeLabel _L_TypeLabel;

        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.Label"/>, 节点路径: GoodsItem.PanelContainer.MarginContainer.NameLabel
        /// </summary>
        public NameLabel L_NameLabel
        {
            get
            {
                if (_L_NameLabel == null) _L_NameLabel = new NameLabel(UiPanel, Instance.GetNode<Godot.Label>("NameLabel"));
                return _L_NameLabel;
            }
        }
        private NameLabel _L_NameLabel;

        public VBoxContainer(GoodsItemPanel uiPanel, Godot.VBoxContainer node) : base(uiPanel, node) {  }
        public override VBoxContainer Clone() => new (UiPanel, (Godot.VBoxContainer)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.MarginContainer"/>, 路径: GoodsItem.PanelContainer.MarginContainer
    /// </summary>
    public class MarginContainer : UiNode<GoodsItemPanel, Godot.MarginContainer, MarginContainer>
    {
        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.VBoxContainer"/>, 节点路径: GoodsItem.PanelContainer.VBoxContainer
        /// </summary>
        public VBoxContainer L_VBoxContainer
        {
            get
            {
                if (_L_VBoxContainer == null) _L_VBoxContainer = new VBoxContainer(UiPanel, Instance.GetNode<Godot.VBoxContainer>("VBoxContainer"));
                return _L_VBoxContainer;
            }
        }
        private VBoxContainer _L_VBoxContainer;

        public MarginContainer(GoodsItemPanel uiPanel, Godot.MarginContainer node) : base(uiPanel, node) {  }
        public override MarginContainer Clone() => new (UiPanel, (Godot.MarginContainer)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.PanelContainer"/>, 路径: GoodsItem.PanelContainer
    /// </summary>
    public class PanelContainer : UiNode<GoodsItemPanel, Godot.PanelContainer, PanelContainer>
    {
        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.MarginContainer"/>, 节点路径: GoodsItem.MarginContainer
        /// </summary>
        public MarginContainer L_MarginContainer
        {
            get
            {
                if (_L_MarginContainer == null) _L_MarginContainer = new MarginContainer(UiPanel, Instance.GetNode<Godot.MarginContainer>("MarginContainer"));
                return _L_MarginContainer;
            }
        }
        private MarginContainer _L_MarginContainer;

        public PanelContainer(GoodsItemPanel uiPanel, Godot.PanelContainer node) : base(uiPanel, node) {  }
        public override PanelContainer Clone() => new (UiPanel, (Godot.PanelContainer)Instance.Duplicate());
    }


    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.Control"/>, 节点路径: GoodsItem.PanelContainer.MarginContainer.VBoxContainer.Control
    /// </summary>
    public Control S_Control => L_PanelContainer.L_MarginContainer.L_VBoxContainer.L_Control;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.Label"/>, 节点路径: GoodsItem.PanelContainer.MarginContainer.VBoxContainer.TypeLabel
    /// </summary>
    public TypeLabel S_TypeLabel => L_PanelContainer.L_MarginContainer.L_VBoxContainer.L_TypeLabel;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.Label"/>, 节点路径: GoodsItem.PanelContainer.MarginContainer.VBoxContainer.NameLabel
    /// </summary>
    public NameLabel S_NameLabel => L_PanelContainer.L_MarginContainer.L_VBoxContainer.L_NameLabel;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.VBoxContainer"/>, 节点路径: GoodsItem.PanelContainer.MarginContainer.VBoxContainer
    /// </summary>
    public VBoxContainer S_VBoxContainer => L_PanelContainer.L_MarginContainer.L_VBoxContainer;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.MarginContainer"/>, 节点路径: GoodsItem.PanelContainer.MarginContainer
    /// </summary>
    public MarginContainer S_MarginContainer => L_PanelContainer.L_MarginContainer;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.PanelContainer"/>, 节点路径: GoodsItem.PanelContainer
    /// </summary>
    public PanelContainer S_PanelContainer => L_PanelContainer;

}