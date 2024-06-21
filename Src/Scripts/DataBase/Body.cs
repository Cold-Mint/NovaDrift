
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
public sealed partial class Body : Luban.BeanBase
{
    public Body(JsonElement _buf) 
    {
        Id = _buf.GetProperty("id").GetInt32();
        Name = _buf.GetProperty("name").GetString();
        Desc = _buf.GetProperty("desc").GetString();
        { var __json0 = _buf.GetProperty("values"); Values = new System.Collections.Generic.List<float>(__json0.GetArrayLength()); foreach(JsonElement __e0 in __json0.EnumerateArray()) { float __v0;  __v0 = __e0.GetSingle();  Values.Add(__v0); }   }
        Health = _buf.GetProperty("health").GetSingle();
        IconName = _buf.GetProperty("icon_name").GetString();
        ClassName = _buf.GetProperty("class_name").GetString();
        Acceleration = _buf.GetProperty("acceleration").GetSingle();
        Deceleration = _buf.GetProperty("deceleration").GetSingle();
    }

    public static Body DeserializeBody(JsonElement _buf)
    {
        return new Body(_buf);
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
    /// 描述
    /// </summary>
    public readonly string Desc;
    /// <summary>
    /// 数值
    /// </summary>
    public readonly System.Collections.Generic.List<float> Values;
    /// <summary>
    /// 生命值
    /// </summary>
    public readonly float Health;
    /// <summary>
    /// 图片
    /// </summary>
    public readonly string IconName;
    /// <summary>
    /// 类名
    /// </summary>
    public readonly string ClassName;
    /// <summary>
    /// 加速度
    /// </summary>
    public readonly float Acceleration;
    /// <summary>
    /// 减速度
    /// </summary>
    public readonly float Deceleration;
   
    public const int __ID__ = 2076098;
    public override int GetTypeId() => __ID__;

    public  void ResolveRef(Tables tables)
    {
        
        
        
        
        
        
        
        
        
    }

    public override string ToString()
    {
        return "{ "
        + "id:" + Id + ","
        + "name:" + Name + ","
        + "desc:" + Desc + ","
        + "values:" + Luban.StringUtil.CollectionToString(Values) + ","
        + "health:" + Health + ","
        + "iconName:" + IconName + ","
        + "className:" + ClassName + ","
        + "acceleration:" + Acceleration + ","
        + "deceleration:" + Deceleration + ","
        + "}";
    }
}

}
