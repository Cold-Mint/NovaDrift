
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
    public DataBase.TbShield TbShield {get; }
    public DataBase.TbBossMobInfo TbBossMobInfo {get; }
    public DataBase.TbPlayerBuild TbPlayerBuild {get; }
    public DataBase.TbStoreInfo TbStoreInfo {get; }
    public DataBase.TbDroneInfo TbDroneInfo {get; }
    public DataBase.TbPowertUpInfo TbPowertUpInfo {get; }

    public Tables(System.Func<string, JsonElement> loader)
    {
        TbAbility = new DataBase.TbAbility(loader("database_tbability"));
        TbWeapon = new DataBase.TbWeapon(loader("database_tbweapon"));
        TbBody = new DataBase.TbBody(loader("database_tbbody"));
        TbMobInfo = new DataBase.TbMobInfo(loader("database_tbmobinfo"));
        TbBuff = new DataBase.TbBuff(loader("database_tbbuff"));
        TbConstants = new DataBase.TbConstants(loader("database_tbconstants"));
        TbAbilityTree = new DataBase.TbAbilityTree(loader("database_tbabilitytree"));
        TbShield = new DataBase.TbShield(loader("database_tbshield"));
        TbBossMobInfo = new DataBase.TbBossMobInfo(loader("database_tbbossmobinfo"));
        TbPlayerBuild = new DataBase.TbPlayerBuild(loader("database_tbplayerbuild"));
        TbStoreInfo = new DataBase.TbStoreInfo(loader("database_tbstoreinfo"));
        TbDroneInfo = new DataBase.TbDroneInfo(loader("database_tbdroneinfo"));
        TbPowertUpInfo = new DataBase.TbPowertUpInfo(loader("database_tbpowertupinfo"));
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
        TbShield.ResolveRef(this);
        TbBossMobInfo.ResolveRef(this);
        TbPlayerBuild.ResolveRef(this);
        TbStoreInfo.ResolveRef(this);
        TbDroneInfo.ResolveRef(this);
        TbPowertUpInfo.ResolveRef(this);
    }
}

}
