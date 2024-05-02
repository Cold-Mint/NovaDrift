
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
public partial class Tables
{
    public DataBase.TbAbility TbAbility {get; }
    public DataBase.TbWeapon TbWeapon {get; }
    public DataBase.TbBody TbBody {get; }
    public DataBase.TbMobInfo TbMobInfo {get; }
    public DataBase.TbBuff TbBuff {get; }
    public DataBase.TbConstants TbConstants {get; }
    public DataBase.TbAbilityTree TbAbilityTree {get; }

    public Tables(System.Func<string, JsonElement> loader)
    {
        TbAbility = new DataBase.TbAbility(loader("database_tbability"));
        TbWeapon = new DataBase.TbWeapon(loader("database_tbweapon"));
        TbBody = new DataBase.TbBody(loader("database_tbbody"));
        TbMobInfo = new DataBase.TbMobInfo(loader("database_tbmobinfo"));
        TbBuff = new DataBase.TbBuff(loader("database_tbbuff"));
        TbConstants = new DataBase.TbConstants(loader("database_tbconstants"));
        TbAbilityTree = new DataBase.TbAbilityTree(loader("database_tbabilitytree"));
        ResolveRef();
    }
    
    private void ResolveRef()
    {
        TbAbility.ResolveRef(this);
        TbWeapon.ResolveRef(this);
        TbBody.ResolveRef(this);
        TbMobInfo.ResolveRef(this);
        TbBuff.ResolveRef(this);
        TbConstants.ResolveRef(this);
        TbAbilityTree.ResolveRef(this);
    }
}

}
