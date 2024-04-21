
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Luban;
using System.Text.Json;


namespace cfg.DataBase
{
public partial class TbConstants
{

     private readonly Constants _data;

     public Constants Data => _data;

    public TbConstants(JsonElement _buf)
    {
        int n = _buf.GetArrayLength();
        if (n != 1) throw new SerializationException("table mode=one, but size != 1");
        _data = Constants.DeserializeConstants(_buf[0]);
    }


    /// <summary>
    /// 默认射击后坐力
    /// </summary>
     public float KnockBackShootDistance => _data.KnockBackShootDistance;
    /// <summary>
    /// 默认被打后坐力
    /// </summary>
     public float KnockBackOnhitDistance => _data.KnockBackOnhitDistance;
    
    public void ResolveRef(Tables tables)
    {
        _data.ResolveRef(tables);
    }
}

}

