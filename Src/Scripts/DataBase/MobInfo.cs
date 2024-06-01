
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Luban;
using System.Text.Json;


namespace cfg
{
public sealed partial class MobInfo : Luban.BeanBase
{
    public MobInfo(JsonElement _buf) 
    {
        Id = _buf.GetProperty("id").GetInt32();
        Name = _buf.GetProperty("name").GetString();
        SceneName = _buf.GetProperty("scene_name").GetString();
        Health = _buf.GetProperty("health").GetSingle();
        Speed = _buf.GetProperty("speed").GetSingle();
        Damage = _buf.GetProperty("damage").GetSingle();
        Targeting = _buf.GetProperty("targeting").GetSingle();
        ShootCd = _buf.GetProperty("shoot_cd").GetSingle();
        BulletCount = _buf.GetProperty("bullet_count").GetSingle();
        Size = _buf.GetProperty("size").GetSingle();
        DangerFactor = _buf.GetProperty("danger_factor").GetInt32();
    }

    public static MobInfo DeserializeMobInfo(JsonElement _buf)
    {
        return new MobInfo(_buf);
    }

    /// <summary>
    /// 这是id
    /// </summary>
    public readonly int Id;
    /// <summary>
    /// 名称
    /// </summary>
    public readonly string Name;
    /// <summary>
    /// 场景名
    /// </summary>
    public readonly string SceneName;
    /// <summary>
    /// 血量
    /// </summary>
    public readonly float Health;
    /// <summary>
    /// 移动速度
    /// </summary>
    public readonly float Speed;
    /// <summary>
    /// 伤害
    /// </summary>
    public readonly float Damage;
    /// <summary>
    /// 转向速度
    /// </summary>
    public readonly float Targeting;
    /// <summary>
    /// 攻击CD
    /// </summary>
    public readonly float ShootCd;
    /// <summary>
    /// 子弹数量
    /// </summary>
    public readonly float BulletCount;
    /// <summary>
    /// 大小
    /// </summary>
    public readonly float Size;
    /// <summary>
    /// 危险系数
    /// </summary>
    public readonly int DangerFactor;
   
    public const int __ID__ = -1406036050;
    public override int GetTypeId() => __ID__;

    public  void ResolveRef(Tables tables)
    {
        
        
        
        
        
        
        
        
        
        
        
    }

    public override string ToString()
    {
        return "{ "
        + "id:" + Id + ","
        + "name:" + Name + ","
        + "sceneName:" + SceneName + ","
        + "health:" + Health + ","
        + "speed:" + Speed + ","
        + "damage:" + Damage + ","
        + "targeting:" + Targeting + ","
        + "shootCd:" + ShootCd + ","
        + "bulletCount:" + BulletCount + ","
        + "size:" + Size + ","
        + "dangerFactor:" + DangerFactor + ","
        + "}";
    }
}

}
