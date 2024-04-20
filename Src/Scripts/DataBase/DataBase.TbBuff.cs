
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
public partial class TbBuff
{
    private readonly System.Collections.Generic.Dictionary<int, Buff> _dataMap;
    private readonly System.Collections.Generic.List<Buff> _dataList;
    
    public TbBuff(JsonElement _buf)
    {
        _dataMap = new System.Collections.Generic.Dictionary<int, Buff>();
        _dataList = new System.Collections.Generic.List<Buff>();
        
        foreach(JsonElement _ele in _buf.EnumerateArray())
        {
            Buff _v;
            _v = Buff.DeserializeBuff(_ele);
            _dataList.Add(_v);
            _dataMap.Add(_v.Id, _v);
        }
    }

    public System.Collections.Generic.Dictionary<int, Buff> DataMap => _dataMap;
    public System.Collections.Generic.List<Buff> DataList => _dataList;

    public Buff GetOrDefault(int key) => _dataMap.TryGetValue(key, out var v) ? v : null;
    public Buff Get(int key) => _dataMap[key];
    public Buff this[int key] => _dataMap[key];

    public void ResolveRef(Tables tables)
    {
        foreach(var _v in _dataList)
        {
            _v.ResolveRef(tables);
        }
    }

}

}

